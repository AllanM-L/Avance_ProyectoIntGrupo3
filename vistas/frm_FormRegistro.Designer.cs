using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace Wfrm_RastreoVehiculos.vistas
{
    partial class frm_FormRegistro
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblMillas;
        private System.Windows.Forms.TextBox txtMillasRecorridas;
        private System.Windows.Forms.Label lblMantenimiento;
        private System.Windows.Forms.DateTimePicker dtpUltimoMantenimiento;
        private System.Windows.Forms.Button btnGuardar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblMillas = new System.Windows.Forms.Label();
            this.txtMillasRecorridas = new System.Windows.Forms.TextBox();
            this.lblMantenimiento = new System.Windows.Forms.Label();
            this.dtpUltimoMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 6);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(20, 41);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(156, 49);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(172, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(20, 76);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(156, 84);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(172, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // lblMillas
            // 
            this.lblMillas.AutoSize = true;
            this.lblMillas.Location = new System.Drawing.Point(20, 110);
            this.lblMillas.Name = "lblMillas";
            this.lblMillas.Size = new System.Drawing.Size(85, 13);
            this.lblMillas.TabIndex = 6;
            this.lblMillas.Text = "Millas recorridas:";
            // 
            // txtMillasRecorridas
            // 
            this.txtMillasRecorridas.Location = new System.Drawing.Point(156, 119);
            this.txtMillasRecorridas.Name = "txtMillasRecorridas";
            this.txtMillasRecorridas.Size = new System.Drawing.Size(172, 20);
            this.txtMillasRecorridas.TabIndex = 7;
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Location = new System.Drawing.Point(20, 145);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(110, 13);
            this.lblMantenimiento.TabIndex = 8;
            this.lblMantenimiento.Text = "Último mantenimiento:";
            // 
            // dtpUltimoMantenimiento
            // 
            this.dtpUltimoMantenimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUltimoMantenimiento.Location = new System.Drawing.Point(156, 153);
            this.dtpUltimoMantenimiento.Name = "dtpUltimoMantenimiento";
            this.dtpUltimoMantenimiento.Size = new System.Drawing.Size(172, 20);
            this.dtpUltimoMantenimiento.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(103, 205);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(172, 26);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMillas);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblMantenimiento);
            this.panel1.Controls.Add(this.lblModelo);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 175);
            this.panel1.TabIndex = 11;
            // 
            // frm_FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 246);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMillasRecorridas);
            this.Controls.Add(this.dtpUltimoMantenimiento);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Vehículo";
            this.Load += new System.EventHandler(this.frm_FormRegistro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel panel1;
    }
}
