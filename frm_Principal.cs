using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data.SqlClient;
namespace Wfrm_RastreoVehiculos
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
        }

        private void InicializarMapa()
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 10;
            gMapControl1.Dock = DockStyle.Fill;

            overlay = new GMapOverlay("ruta");
            gMapControl1.Overlays.Add(overlay);
        }

        private void InicializarTimer() // Actualizar
        {
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += ActualizarUbicacion;
            timer.Start();
        }

        private void ActualizarUbicacion(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT latitud, longitud FROM ubicaciones ORDER BY id DESC LIMIT 1;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                double lat = reader.GetDouble("latitud");
                                double lng = reader.GetDouble("longitud");

                                PointLatLng point = new PointLatLng(lat, lng);

                                
                                routePoints.Add(point);

                                if (marker == null)
                                {
                                    marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                                    overlay.Markers.Add(marker);
                                }
                                else
                                {
                                    marker.Position = point;
                                }

                                
                                var route = new GMapRoute(routePoints, "Ruta");
                                route.Stroke = new Pen(System.Drawing.Color.Red, 2);
                                overlay.Routes.Add(route);

                                gMapControl1.Position = point;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la ubicación: " + ex.Message);
            }
        }
    }
}

