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

namespace Wfrm_RastreoVehiculos
{
    public partial class frm_RegistroVehiculos : Form
    {
        private string connectionString = "Server=localhost;Database=vehiculos;Uid=root;Pwd=tu_contraseña;";

        public frm_RegistroVehiculos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO vehiculos (nombre, marca, modelo) VALUES (@nombre, @marca, @modelo)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@marca", txtMarca.Text);
                        command.Parameters.AddWithValue("@modelo", txtModelo.Text);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Vehículo registrado exitosamente.");
                this.Close(); // Cerrar el formulario después de registrar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el vehículo: " + ex.Message);
            }
        }
    }
}

