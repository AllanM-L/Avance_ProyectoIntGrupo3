using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Wfrm_RastreoVehiculos.logica;
using Wfrm_RastreoVehiculos.vistas;

namespace Wfrm_RastreoVehiculos.vistas
{
    public partial class frm_Login : Form
    {
        private cls_DBConnection dbConnection = new cls_DBConnection();
        private List<Image> imagenes = new List<Image>();
        private int imagenActual = 0;
        private Timer timerImagenes;


        public frm_Login()
        {
            InitializeComponent();
        }
        private void CargarImagenes()
        {
            string rutaImagenes = Path.Combine(Application.StartupPath, "img");

            string[] archivos = Directory.GetFiles(rutaImagenes, "*.png")
                .Concat(Directory.GetFiles(rutaImagenes, "*.jpg"))
                .Concat(Directory.GetFiles(rutaImagenes, "*.jpeg"))
                .ToArray();

            foreach (string archivo in archivos)
            {
                imagenes.Add(Image.FromFile(archivo));
            }

            if (imagenes.Count > 0)
            {
                picture_Login.Image = imagenes[0];
            }
        }
        private void IniciarTimer()
        {
            timerImagenes = new Timer();
            timerImagenes.Interval = 3000; 
            timerImagenes.Tick += (s, e) => CambiarImagen();
            timerImagenes.Start();
        }
        private void CambiarImagen()
        {
            if (imagenes.Count == 0) return;

            imagenActual = (imagenActual + 1) % imagenes.Count;
            picture_Login.Image = imagenes[imagenActual];
        }


        private void frm_Login_Load(object sender, EventArgs e)
        {
            CargarImagenes();
            IniciarTimer();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            string username = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM usuarios WHERE nombre_usuario = @username AND contraseña = SHA2(@password, 256)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string role = reader["rol"].ToString();
                        MessageBox.Show($"¡Bienvenido {username} ({role})!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        frm_Menu mainForm = new frm_Menu(username, role);
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picture_Login_Click(object sender, EventArgs e)
        {
            CambiarImagen(); 
        }

    }
}



