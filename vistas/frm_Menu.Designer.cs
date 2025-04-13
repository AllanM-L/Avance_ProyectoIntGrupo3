using System.Windows.Forms;

namespace Wfrm_RastreoVehiculos.vistas
{
    partial class frm_Menu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnVerMapa;
        private System.Windows.Forms.Button btnRegistrarVehiculo;
        private System.Windows.Forms.Button btnCalcularViaje;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblBienvenida;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pnl_User = new System.Windows.Forms.Panel();
            this.pnl_Menuop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalcularViaje = new System.Windows.Forms.Button();
            this.btnRegistrarVehiculo = new System.Windows.Forms.Button();
            this.btnVerMapa = new System.Windows.Forms.Button();
            this.pnl_User.SuspendLayout();
            this.pnl_Menuop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Location = new System.Drawing.Point(0, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(172, 55);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(1, 2);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(306, 32);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido, Usuario (Rol)";
            // 
            // pnl_User
            // 
            this.pnl_User.BackColor = System.Drawing.Color.White;
            this.pnl_User.Controls.Add(this.lblBienvenida);
            this.pnl_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_User.Location = new System.Drawing.Point(0, 0);
            this.pnl_User.Name = "pnl_User";
            this.pnl_User.Size = new System.Drawing.Size(563, 36);
            this.pnl_User.TabIndex = 5;
            // 
            // pnl_Menuop
            // 
            this.pnl_Menuop.BackColor = System.Drawing.Color.Beige;
            this.pnl_Menuop.Controls.Add(this.btnCalcularViaje);
            this.pnl_Menuop.Controls.Add(this.btnRegistrarVehiculo);
            this.pnl_Menuop.Controls.Add(this.btnSalir);
            this.pnl_Menuop.Controls.Add(this.btnVerMapa);
            this.pnl_Menuop.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menuop.Location = new System.Drawing.Point(0, 36);
            this.pnl_Menuop.Name = "pnl_Menuop";
            this.pnl_Menuop.Size = new System.Drawing.Size(172, 340);
            this.pnl_Menuop.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(178, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 310);
            this.panel1.TabIndex = 7;
            // 
            // btnCalcularViaje
            // 
            this.btnCalcularViaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcularViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularViaje.Image = global::Wfrm_RastreoVehiculos.Properties.Resources.calculadora_viaje;
            this.btnCalcularViaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcularViaje.Location = new System.Drawing.Point(0, 168);
            this.btnCalcularViaje.Name = "btnCalcularViaje";
            this.btnCalcularViaje.Size = new System.Drawing.Size(172, 84);
            this.btnCalcularViaje.TabIndex = 2;
            this.btnCalcularViaje.Text = "Calcular Viaje";
            this.btnCalcularViaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcularViaje.UseVisualStyleBackColor = true;
            this.btnCalcularViaje.Click += new System.EventHandler(this.btnCalcularViaje_Click);
            // 
            // btnRegistrarVehiculo
            // 
            this.btnRegistrarVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVehiculo.Image = global::Wfrm_RastreoVehiculos.Properties.Resources.vehiculo_icono;
            this.btnRegistrarVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarVehiculo.Location = new System.Drawing.Point(0, 84);
            this.btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            this.btnRegistrarVehiculo.Size = new System.Drawing.Size(172, 84);
            this.btnRegistrarVehiculo.TabIndex = 3;
            this.btnRegistrarVehiculo.Text = "Registrar Vehículo";
            this.btnRegistrarVehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarVehiculo.UseVisualStyleBackColor = true;
            this.btnRegistrarVehiculo.Click += new System.EventHandler(this.btnRegistrarVehiculo_Click);
            // 
            // btnVerMapa
            // 
            this.btnVerMapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerMapa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerMapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMapa.Image = global::Wfrm_RastreoVehiculos.Properties.Resources.mapaGps2_0;
            this.btnVerMapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerMapa.Location = new System.Drawing.Point(0, 0);
            this.btnVerMapa.Name = "btnVerMapa";
            this.btnVerMapa.Size = new System.Drawing.Size(172, 84);
            this.btnVerMapa.TabIndex = 4;
            this.btnVerMapa.Text = "Ver Mapa";
            this.btnVerMapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerMapa.UseVisualStyleBackColor = true;
            this.btnVerMapa.Click += new System.EventHandler(this.btnVerMapa_Click);
            // 
            // frm_Menu
            // 
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(563, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Menuop);
            this.Controls.Add(this.pnl_User);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Menu";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.pnl_User.ResumeLayout(false);
            this.pnl_User.PerformLayout();
            this.pnl_Menuop.ResumeLayout(false);
            this.pnl_Menuop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel pnl_User;
        private Panel pnl_Menuop;
        private Panel panel1;
    }
}

