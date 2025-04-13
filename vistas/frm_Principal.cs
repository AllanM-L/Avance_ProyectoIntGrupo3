using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Linq;
using Wfrm_RastreoVehiculos.logica;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace Wfrm_RastreoVehiculos.vistas
{
    public partial class frm_Principal : Form
    {
        private GMapOverlay overlay;
        private GMapMarker marker;
        private Timer timer;
        private List<PointLatLng> routePoints;
        private string connectionString = "Server=localhost;Database=vehiculos;Uid=root;Pwd=tu_contraseña;";

        public frm_Principal()
        {
            InitializeComponent();
            InicializarMapa();
            InicializarTimer();
            routePoints = new List<PointLatLng>();
            CargarVehiculos();

        }

        private void InicializarMapa()
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 10;

            overlay = new GMapOverlay("ruta");
            gMapControl1.Overlays.Add(overlay);
            gMapControl1.BackColor = Color.White;
        }

        private void InicializarTimer()
        {
            timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += ActualizarUbicacion;
            timer.Start();
        }

        private void CargarVehiculos()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, nombre FROM vehiculos";
                    using (var command = new MySqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        List<Vehiculo> vehiculos = new List<Vehiculo>();
                        while (reader.Read())
                        {
                            vehiculos.Add(new Vehiculo
                            {
                                Id = reader.GetInt32("id"),
                                Nombre = reader.GetString("nombre")
                            });
                        }

                        cmbVehiculos.DataSource = vehiculos;
                        cmbVehiculos.DisplayMember = "Nombre";
                        cmbVehiculos.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vehículos: " + ex.Message);
            }
        }



        private string ObtenerFiltroFecha()
        {
            string filtro = cmbFiltroFecha.SelectedItem?.ToString();
            if (filtro == "Hoy")
                return "DATE(fecha_hora) = CURDATE()";
            else if (filtro == "Ayer")
                return "DATE(fecha_hora) = CURDATE() - INTERVAL 1 DAY";
            else if (filtro == "Últimos 7 días")
                return "fecha_hora >= CURDATE() - INTERVAL 7 DAY";
            else
                return "1";
        }

        private async void ActualizarUbicacion(object sender, EventArgs e)
        {
            if (cmbVehiculos.SelectedItem == null) return;

            Vehiculo vehiculoSeleccionado = cmbVehiculos.SelectedItem as Vehiculo;
            if (vehiculoSeleccionado == null) return;

            int idVehiculo = vehiculoSeleccionado.Id;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string filtroFecha = ObtenerFiltroFecha();
                    string query = $@"
                SELECT u.latitud, u.longitud, u.fecha_hora,
                       v.nombre AS nombre_vehiculo, v.marca, v.modelo, v.tipoVehiculo, v.placa, v.estado
                FROM ubicaciones u
                JOIN vehiculos v ON u.id_vehiculo = v.id
                WHERE u.id_vehiculo = @idVehiculo AND {filtroFecha}
                ORDER BY u.id DESC
                LIMIT 100";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idVehiculo", idVehiculo);

                        using (var reader = command.ExecuteReader())
                        {
                            string nombreVehiculo = "", marca = "", modelo = "", tipo = "", placa = "", estado = "";
                            DateTime fechaInicio = DateTime.Now, fechaFin = DateTime.Now;
                            routePoints.Clear();

                            while (reader.Read())
                            {
                                double lat = reader.GetDouble("latitud");
                                double lng = reader.GetDouble("longitud");
                                DateTime fecha = reader.GetDateTime("fecha_hora");

                                PointLatLng point = new PointLatLng(lat, lng);
                                routePoints.Insert(0, point); // Invertido para mantener orden cronológico

                                if (routePoints.Count == 1)
                                {
                                    nombreVehiculo = reader.GetString("nombre_vehiculo");
                                    marca = reader.GetString("marca");
                                    modelo = reader.GetString("modelo");
                                    tipo = reader.GetString("tipoVehiculo");
                                    placa = reader.GetString("placa");
                                    estado = reader.GetString("estado");

                                    fechaFin = fecha;
                                }

                                fechaInicio = fecha; 
                            }

                            overlay.Markers.Clear();
                            overlay.Routes.Clear();

                            if (routePoints.Count > 0)
                            {
                                
                                var inicio = routePoints.First();
                                var fin = routePoints.Last();

                               
                                marker = new GMarkerGoogle(fin, GMarkerGoogleType.red_dot);
                                overlay.Markers.Add(marker);
                                gMapControl1.Position = fin;

                               
                                var route = new GMapRoute(routePoints, "Ruta");
                                route.Stroke = new Pen(Color.Red, 2);
                                overlay.Routes.Add(route);

                                
                                double distanciaKm = CalcularDistancia(inicio.Lat, inicio.Lng, fin.Lat, fin.Lng);
                                TimeSpan tiempoEstimado = fechaFin - fechaInicio;

                                
                                string nombreLugar = await ObtenerNombreLugar(fin.Lat, fin.Lng);
                                if (string.IsNullOrEmpty(nombreLugar)) nombreLugar = "Ruta desconocida";

                                
                                var markerInicio = new GMarkerGoogle(inicio, GMarkerGoogleType.green_dot);
                                overlay.Markers.Add(markerInicio);

                               
                                lblInfoVehiculo.Text = $"Vehículo: {nombreVehiculo} - {marca} {modelo} ({tipo}) | Placa: {placa} | Estado: {estado} | Últ. act: {fechaFin}";
                                lblRuta.Text = $"Ruta: {nombreLugar} | Desde: {inicio.Lat}, {inicio.Lng} hasta {fin.Lat}, {fin.Lng} | {Math.Round(distanciaKm, 2)} km - {Math.Round(tiempoEstimado.TotalMinutes, 1)} min";
                            }

                            else
                            {
                                lblInfoVehiculo.Text = $"No hay datos disponibles.";
                                lblRuta.Text = $"Ruta: -";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar ubicación: " + ex.Message);
            }
        }
        private double CalcularDistancia(double lat1, double lon1, double lat2, double lon2)
        {
            double R = 6371; // Radio de la tierra en km
            double dLat = (lat2 - lat1) * Math.PI / 180;
            double dLon = (lon2 - lon1) * Math.PI / 180;
            double a =
                Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(lat1 * Math.PI / 180) * Math.Cos(lat2 * Math.PI / 180) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        private async Task<string> ObtenerNombreLugar(double lat, double lng)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://nominatim.openstreetmap.org/reverse?format=json&lat={lat}&lon={lng}&zoom=14&addressdetails=1";
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0"); // Requerido por Nominatim
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<dynamic>(json);
                        return data.display_name;
                    }
                }
            }
            catch { }

            return null;
        }



        private void frm_Principal_Load(object sender, EventArgs e)
        {
            cmbFiltroFecha.SelectedIndex = 0;
        }

        private void cmbFiltroFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarUbicacion(null, null);
        }

        private void cmbVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarUbicacion(null, null);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu menu = new frm_Menu("Usuario", "Rol");
            menu.Show();
        }


    }
}




