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
using Wfrm_RastreoVehiculos.logica;


namespace Wfrm_RastreoVehiculos.vistas
{
    public partial class frm_RegistroVehiculos : Form
    {
        private cls_DBConnection dbConnection = new cls_DBConnection();
        BindingSource bindingSource = new BindingSource();

        public frm_RegistroVehiculos()
        {
            InitializeComponent();
        }

        private void frm_RegistroVehiculos_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().Replace("'", "''");
            if (bindingSource.DataSource is DataTable)
            {
                (bindingSource.DataSource as DataTable).DefaultView.RowFilter =
                    $"nombre LIKE '%{filtro}%' OR placa LIKE '%{filtro}%'";
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

        private void CargarVehiculos()
        {
            try
            {
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    string query = "SELECT id, nombre, marca, modelo, tipoVehiculo, placa, millasRecorridas, ultimoMantenimiento FROM vehiculos";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    bindingSource.DataSource = table;
                    dgvVehiculos.DataSource = bindingSource;
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


