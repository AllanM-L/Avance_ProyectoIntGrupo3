using System.Windows.Forms;

namespace Wfrm_RastreoVehiculos
{
    partial class frm_RegistroVehiculos
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNombre;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private Button btnRegistrar;
        private Label lblNombre;
        private Label lblMarca;
        private Label lblModelo;

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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(120, 70);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 22);
            this.txtMarca.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(120, 110);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(200, 22);
            this.txtModelo.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(120, 150);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(30, 70);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 16);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(30, 110);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(56, 16);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo:";
            // 
            // frm_RegistroVehiculos
            // 
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtNombre);
            this.Name = "frm_RegistroVehiculos";
            this.Text = "Registro de Vehículo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
