using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wfrm_RastreoVehiculos.vistas
{
    public partial class frm_Menu : Form
    {
        private string usuario;
        private string rol;

        public frm_Menu(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
        }


        private void btnVerMapa_Click(object sender, EventArgs e)
        {
            frm_Principal mapaForm = new frm_Principal();
            mapaForm.Show();
            this.Hide();    
        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            frm_RegistroVehiculos registroForm = new frm_RegistroVehiculos();
            registroForm.Show();
            this.Hide(); 
        }
        private void btnCalcularViaje_Click(object sender, EventArgs e)
        {
            frm_CalcularViaje calcularViajeForm = new frm_CalcularViaje();
            calcularViajeForm.Show();
            this.Hide();
        }


        private void frm_Menu_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido {usuario} ({rol})";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


    }
}


