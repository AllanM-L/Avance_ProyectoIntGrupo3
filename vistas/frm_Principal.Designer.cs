using System.Drawing;
using System.Windows.Forms;

namespace Wfrm_RastreoVehiculos.vistas
{
    partial class frm_Principal
    {
        private System.ComponentModel.IContainer components = null;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label lblInfoVehiculo;
        private System.Windows.Forms.ComboBox cmbFiltroFecha;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cmbVehiculos;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.PictureBox picAlerta;



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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cmbFiltroFecha = new System.Windows.Forms.ComboBox();
            this.lblInfoVehiculo = new System.Windows.Forms.Label();
            this.cmbVehiculos = new System.Windows.Forms.ComboBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.pnl_GPS = new System.Windows.Forms.Panel();
            this.picAlerta = new System.Windows.Forms.PictureBox();
            this.pnl_GPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlerta)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(21, 47);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 24;
            this.gMapControl1.MinZoom = 0;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(812, 430);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 10D;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(20, 487);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(85, 13);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Ver recorrido de:";
            // 
            // cmbFiltroFecha
            // 
            this.cmbFiltroFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroFecha.FormattingEnabled = true;
            this.cmbFiltroFecha.Items.AddRange(new object[] {
            "Hoy",
            "Ayer",
            "Últimos 7 días"});
            this.cmbFiltroFecha.Location = new System.Drawing.Point(118, 484);
            this.cmbFiltroFecha.Name = "cmbFiltroFecha";
            this.cmbFiltroFecha.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltroFecha.TabIndex = 2;
            this.cmbFiltroFecha.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroFecha_SelectedIndexChanged);
            // 
            // lblInfoVehiculo
            // 
            this.lblInfoVehiculo.AutoSize = true;
            this.lblInfoVehiculo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfoVehiculo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblInfoVehiculo.Location = new System.Drawing.Point(18, 5);
            this.lblInfoVehiculo.Name = "lblInfoVehiculo";
            this.lblInfoVehiculo.Size = new System.Drawing.Size(153, 19);
            this.lblInfoVehiculo.TabIndex = 3;
            this.lblInfoVehiculo.Text = "Vehículo: - | Últ. act: -";
            // 
            // cmbVehiculos
            // 
            this.cmbVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculos.FormattingEnabled = true;
            this.cmbVehiculos.Location = new System.Drawing.Point(318, 484);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(200, 21);
            this.cmbVehiculos.TabIndex = 5;
            this.cmbVehiculos.SelectedIndexChanged += new System.EventHandler(this.cmbVehiculos_SelectedIndexChanged);
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(258, 487);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(53, 13);
            this.lblVehiculo.TabIndex = 4;
            this.lblVehiculo.Text = "Vehículo:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(528, 482);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 25);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRuta.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRuta.Location = new System.Drawing.Point(18, 25);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(95, 15);
            this.lblRuta.TabIndex = 7;
            this.lblRuta.Text = "Ruta: - | - hasta -";
            // 
            // pnl_GPS
            // 
            this.pnl_GPS.BackColor = System.Drawing.Color.Beige;
            this.pnl_GPS.Controls.Add(this.lblRuta);
            this.pnl_GPS.Controls.Add(this.picAlerta);
            this.pnl_GPS.Controls.Add(this.btnSalir);
            this.pnl_GPS.Controls.Add(this.cmbVehiculos);
            this.pnl_GPS.Controls.Add(this.lblVehiculo);
            this.pnl_GPS.Controls.Add(this.lblInfoVehiculo);
            this.pnl_GPS.Controls.Add(this.cmbFiltroFecha);
            this.pnl_GPS.Controls.Add(this.lblFiltro);
            this.pnl_GPS.Controls.Add(this.gMapControl1);
            this.pnl_GPS.Location = new System.Drawing.Point(9, 12);
            this.pnl_GPS.Name = "pnl_GPS";
            this.pnl_GPS.Size = new System.Drawing.Size(863, 532);
            this.pnl_GPS.TabIndex = 8;
            // 
            // picAlerta
            // 
            this.picAlerta.Image = global::Wfrm_RastreoVehiculos.Properties.Resources.alerta;
            this.picAlerta.Location = new System.Drawing.Point(766, 47);
            this.picAlerta.Name = "picAlerta";
            this.picAlerta.Size = new System.Drawing.Size(67, 66);
            this.picAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlerta.TabIndex = 9;
            this.picAlerta.TabStop = false;
            this.picAlerta.Visible = false;
            // 
            // frm_Principal
            // 
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(884, 556);
            this.Controls.Add(this.pnl_GPS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Principal";
            this.Text = "Rastreo de Vehículos";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.pnl_GPS.ResumeLayout(false);
            this.pnl_GPS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlerta)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnl_GPS;
    }
}



