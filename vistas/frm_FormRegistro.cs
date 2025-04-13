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

namespace Wfrm_RastreoVehiculos.vistas
{
    public partial class frm_FormRegistro : Form
    {
        private string connectionString = "Server=localhost;Database=vehiculos;Uid=root;Pwd=tu_contraseña;";
        private int? idVehiculo = null;

        public frm_FormRegistro(int? idVehiculo = null)
        {
            InitializeComponent();
            this.idVehiculo = idVehiculo;

            if (idVehiculo != null)
                CargarDatosVehiculo();
        }

        private void CargarDatosVehiculo()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM vehiculos WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", idVehiculo);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtNombre.Text = reader["nombre"].ToString();
                        txtMarca.Text = reader["marca"].ToString();
                        txtModelo.Text = reader["modelo"].ToString();
                        txtTipoVehiculo.Text = reader["tipoVehiculo"]?.ToString() ?? "";
                        txtPlaca.Text = reader["placa"].ToString();
                        txtMillasRecorridas.Text = reader["millasRecorridas"].ToString();
                        if (!Convert.IsDBNull(reader["ultimoMantenimiento"]))
                        {
                            dtpUltimoMantenimiento.Value = Convert.ToDateTime(reader["ultimoMantenimiento"]);
                        }
                        else
                        {
                            dtpUltimoMantenimiento.Value = DateTime.Now; 
                        }
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query;

                    if (idVehiculo == null)
                    {
                        query = @"INSERT INTO vehiculos 
                            (nombre, marca, modelo, tipoVehiculo, placa, millasRecorridas, ultimoMantenimiento)
                            VALUES 
                            (@nombre, @marca, @modelo, @tipoVehiculo, @placa, @millas, @mantenimiento)";
                    }
                    else
                    {
                        query = @"UPDATE vehiculos 
                             SET nombre = @nombre, marca = @marca, modelo = @modelo, tipoVehiculo = @tipoVehiculo,
                             placa = @placa, millasRecorridas = @millas, ultimoMantenimiento = @mantenimiento 
                             WHERE id = @id";
                    }


                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@marca", txtMarca.Text);
                    command.Parameters.AddWithValue("@modelo", txtModelo.Text);
                    command.Parameters.AddWithValue("@tipoVehiculo", txtTipoVehiculo.Text);
                    command.Parameters.AddWithValue("@placa", txtPlaca.Text); 
                    command.Parameters.AddWithValue("@millas", int.Parse(txtMillasRecorridas.Text));
                    command.Parameters.AddWithValue("@mantenimiento", dtpUltimoMantenimiento.Value.Date);

                    if (idVehiculo != null)
                        command.Parameters.AddWithValue("@id", idVehiculo);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show(idVehiculo == null ? "Vehículo registrado." : "Vehículo actualizado.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frm_FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void txtTipoVehiculo_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
