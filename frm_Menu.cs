using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Wfrm_RastreoVehiculos
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
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
    }
}

