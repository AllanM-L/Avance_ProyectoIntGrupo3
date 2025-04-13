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
    public partial class frm_CalcularViaje : Form
    {
        public frm_CalcularViaje()
        {
            InitializeComponent();
        }

        private void btnCalcularEficiencia_Click(object sender, EventArgs e)
        {
            try
            {
                double kilometros = double.Parse(txtKilometros.Text);
                double gasolina = double.Parse(txtGasolina.Text);

                if (gasolina <= 0)
                {
                    MessageBox.Show("La gasolina debe ser mayor que 0.");
                    return;
                }

                double eficiencia = kilometros / gasolina;
                lblResultadoEficiencia.Text = $"Eficiencia: {eficiencia:F2} km/galón";
            }
            catch
            {
                MessageBox.Show("Ingresa valores válidos para kilometros y gasolina.");
            }
        }

        private void btnCalcularGasto_Click(object sender, EventArgs e)
        {
            try
            {
                double distancia = double.Parse(txtDistancia.Text);
                double eficiencia = double.Parse(txtEficiencia.Text);
                double costoGalon = double.Parse(txtCostoGalon.Text);

                if (eficiencia <= 0)
                {
                    MessageBox.Show("La eficiencia debe ser mayor que 0.");
                    return;
                }

                double gasto = (distancia / eficiencia) * costoGalon;
                lblResultadoGasto.Text = $"Gasto estimado: ${gasto:F2}";
            }
            catch
            {
                MessageBox.Show("Ingresa valores válidos para la distancia, eficiencia y costo.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu("Usuario", "Rol"); 
            menu.Show();
            this.Close();
        }


        private void frm_CalcularViaje_Load(object sender, EventArgs e)
        {

        }
    }
}

