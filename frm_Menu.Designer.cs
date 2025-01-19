using System.Windows.Forms;

namespace Wfrm_RastreoVehiculos
{
    partial class frm_Menu
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnVerMapa;
        private Button btnRegistrarVehiculo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnVerMapa = new System.Windows.Forms.Button();
            this.btnRegistrarVehiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerMapa
            // 
            this.btnVerMapa.Location = new System.Drawing.Point(100, 50);
            this.btnVerMapa.Name = "btnVerMapa";
            this.btnVerMapa.Size = new System.Drawing.Size(150, 50);
            this.btnVerMapa.TabIndex = 0;
            this.btnVerMapa.Text = "Ver Mapa";
            this.btnVerMapa.UseVisualStyleBackColor = true;
            this.btnVerMapa.Click += new System.EventHandler(this.btnVerMapa_Click);
            // 
            // btnRegistrarVehiculo
            // 
            this.btnRegistrarVehiculo.Location = new System.Drawing.Point(100, 120);
            this.btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            this.btnRegistrarVehiculo.Size = new System.Drawing.Size(150, 50);
            this.btnRegistrarVehiculo.TabIndex = 1;
            this.btnRegistrarVehiculo.Text = "Registrar Vehículo";
            this.btnRegistrarVehiculo.UseVisualStyleBackColor = true;
            this.btnRegistrarVehiculo.Click += new System.EventHandler(this.btnRegistrarVehiculo_Click);
            // 
            // frm_Menu
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.btnRegistrarVehiculo);
            this.Controls.Add(this.btnVerMapa);
            this.Name = "frm_Menu";
            this.Text = "Menú";
            this.ResumeLayout(false);
        }
    }
}
