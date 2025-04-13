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
    public partial class frm_RegistroVehiculos : Form
    {
        private string connectionString = "Server=localhost;Database=vehiculos;Uid=root;Pwd=tu_contraseña;";

        public frm_RegistroVehiculos()
        {
            InitializeComponent();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToLower();

            foreach (DataGridViewRow fila in dgvVehiculos.Rows)
            {
                if (fila.IsNewRow) continue;

                bool visible = fila.Cells["nombre"].Value.ToString().ToLower().Contains(filtro) ||
                               fila.Cells["placa"].Value.ToString().ToLower().Contains(filtro);

                fila.Visible = visible;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frm_FormRegistro frm = new frm_FormRegistro(); 
            frm.FormClosed += (s, args) => CargarVehiculos(); 
            frm.ShowDialog();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvVehiculos.SelectedRows[0];
                int idVehiculo = Convert.ToInt32(fila.Cells["id"].Value);

                frm_FormRegistro frm = new frm_FormRegistro(idVehiculo); 
                frm.FormClosed += (s, args) => CargarVehiculos();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para editar.");
            }
        }


        private void frm_RegistroVehiculos_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
        }

        private void CargarVehiculos()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id, nombre, marca, modelo, millasRecorridas, ultimoMantenimiento FROM vehiculos";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvVehiculos.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vehículos: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu("Usuario", "Rol");
            menu.Show();
            this.Close();
        }
    }
}

