using System.Windows.Forms;

namespace Wfrm_RastreoVehiculos.vistas
{
    partial class frm_CalcularViaje
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTituloEficiencia;
        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.Label lblGasolina;
        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.TextBox txtGasolina;
        private System.Windows.Forms.Button btnCalcularEficiencia;
        private System.Windows.Forms.Label lblResultadoEficiencia;

        private System.Windows.Forms.Label lblTituloGasto;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblEficiencia;
        private System.Windows.Forms.Label lblCostoGalon;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtEficiencia;
        private System.Windows.Forms.TextBox txtCostoGalon;
        private System.Windows.Forms.Button btnCalcularGasto;
        private System.Windows.Forms.Label lblResultadoGasto;

        private System.Windows.Forms.Button btnVolver;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTituloEficiencia = new System.Windows.Forms.Label();
            this.lblKilometros = new System.Windows.Forms.Label();
            this.lblGasolina = new System.Windows.Forms.Label();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.btnCalcularEficiencia = new System.Windows.Forms.Button();
            this.lblResultadoEficiencia = new System.Windows.Forms.Label();
            this.lblTituloGasto = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblEficiencia = new System.Windows.Forms.Label();
            this.lblCostoGalon = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtEficiencia = new System.Windows.Forms.TextBox();
            this.txtCostoGalon = new System.Windows.Forms.TextBox();
            this.btnCalcularGasto = new System.Windows.Forms.Button();
            this.lblResultadoGasto = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnl_calcuviaj = new System.Windows.Forms.Panel();
            this.pnl_calcuviaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloEficiencia
            // 
            this.lblTituloEficiencia.AutoSize = true;
            this.lblTituloEficiencia.Location = new System.Drawing.Point(11, 10);
            this.lblTituloEficiencia.Name = "lblTituloEficiencia";
            this.lblTituloEficiencia.Size = new System.Drawing.Size(186, 13);
            this.lblTituloEficiencia.TabIndex = 0;
            this.lblTituloEficiencia.Text = "Calculadora de Eficiencia de Gasolina";
            // 
            // lblKilometros
            // 
            this.lblKilometros.Location = new System.Drawing.Point(11, 50);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(100, 23);
            this.lblKilometros.TabIndex = 1;
            this.lblKilometros.Text = "Kilómetros recorridos:";
            // 
            // lblGasolina
            // 
            this.lblGasolina.Location = new System.Drawing.Point(11, 80);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(100, 23);
            this.lblGasolina.TabIndex = 3;
            this.lblGasolina.Text = "Gasolina gastada (gal):";
            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(181, 47);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(200, 20);
            this.txtKilometros.TabIndex = 2;
            // 
            // txtGasolina
            // 
            this.txtGasolina.Location = new System.Drawing.Point(181, 77);
            this.txtGasolina.Name = "txtGasolina";
            this.txtGasolina.Size = new System.Drawing.Size(200, 20);
            this.txtGasolina.TabIndex = 4;
            // 
            // btnCalcularEficiencia
            // 
            this.btnCalcularEficiencia.BackColor = System.Drawing.Color.White;
            this.btnCalcularEficiencia.Location = new System.Drawing.Point(181, 110);
            this.btnCalcularEficiencia.Name = "btnCalcularEficiencia";
            this.btnCalcularEficiencia.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularEficiencia.TabIndex = 5;
            this.btnCalcularEficiencia.Text = "Calcular Eficiencia";
            this.btnCalcularEficiencia.UseVisualStyleBackColor = false;
            this.btnCalcularEficiencia.Click += new System.EventHandler(this.btnCalcularEficiencia_Click);
            // 
            // lblResultadoEficiencia
            // 
            this.lblResultadoEficiencia.AutoSize = true;
            this.lblResultadoEficiencia.Location = new System.Drawing.Point(11, 150);
            this.lblResultadoEficiencia.Name = "lblResultadoEficiencia";
            this.lblResultadoEficiencia.Size = new System.Drawing.Size(56, 13);
            this.lblResultadoEficiencia.TabIndex = 6;
            this.lblResultadoEficiencia.Text = "Eficiencia:";
            // 
            // lblTituloGasto
            // 
            this.lblTituloGasto.AutoSize = true;
            this.lblTituloGasto.Location = new System.Drawing.Point(11, 200);
            this.lblTituloGasto.Name = "lblTituloGasto";
            this.lblTituloGasto.Size = new System.Drawing.Size(168, 13);
            this.lblTituloGasto.TabIndex = 7;
            this.lblTituloGasto.Text = "Calculadora de Gasto de Gasolina";
            // 
            // lblDistancia
            // 
            this.lblDistancia.Location = new System.Drawing.Point(11, 240);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(100, 23);
            this.lblDistancia.TabIndex = 8;
            this.lblDistancia.Text = "Distancia a recorrer (km):";
            // 
            // lblEficiencia
            // 
            this.lblEficiencia.Location = new System.Drawing.Point(11, 270);
            this.lblEficiencia.Name = "lblEficiencia";
            this.lblEficiencia.Size = new System.Drawing.Size(100, 23);
            this.lblEficiencia.TabIndex = 10;
            this.lblEficiencia.Text = "Eficiencia (km/gal):";
            // 
            // lblCostoGalon
            // 
            this.lblCostoGalon.Location = new System.Drawing.Point(11, 300);
            this.lblCostoGalon.Name = "lblCostoGalon";
            this.lblCostoGalon.Size = new System.Drawing.Size(100, 23);
            this.lblCostoGalon.TabIndex = 12;
            this.lblCostoGalon.Text = "Costo por galón ($):";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(181, 237);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(200, 20);
            this.txtDistancia.TabIndex = 9;
            // 
            // txtEficiencia
            // 
            this.txtEficiencia.Location = new System.Drawing.Point(181, 267);
            this.txtEficiencia.Name = "txtEficiencia";
            this.txtEficiencia.Size = new System.Drawing.Size(200, 20);
            this.txtEficiencia.TabIndex = 11;
            // 
            // txtCostoGalon
            // 
            this.txtCostoGalon.Location = new System.Drawing.Point(181, 297);
            this.txtCostoGalon.Name = "txtCostoGalon";
            this.txtCostoGalon.Size = new System.Drawing.Size(200, 20);
            this.txtCostoGalon.TabIndex = 13;
            // 
            // btnCalcularGasto
            // 
            this.btnCalcularGasto.BackColor = System.Drawing.Color.White;
            this.btnCalcularGasto.Location = new System.Drawing.Point(181, 330);
            this.btnCalcularGasto.Name = "btnCalcularGasto";
            this.btnCalcularGasto.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularGasto.TabIndex = 14;
            this.btnCalcularGasto.Text = "Calcular Gasto";
            this.btnCalcularGasto.UseVisualStyleBackColor = false;
            this.btnCalcularGasto.Click += new System.EventHandler(this.btnCalcularGasto_Click);
            // 
            // lblResultadoGasto
            // 
            this.lblResultadoGasto.AutoSize = true;
            this.lblResultadoGasto.Location = new System.Drawing.Point(11, 370);
            this.lblResultadoGasto.Name = "lblResultadoGasto";
            this.lblResultadoGasto.Size = new System.Drawing.Size(83, 13);
            this.lblResultadoGasto.TabIndex = 15;
            this.lblResultadoGasto.Text = "Gasto estimado:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(11, 410);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 23);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pnl_calcuviaj
            // 
            this.pnl_calcuviaj.BackColor = System.Drawing.Color.Beige;
            this.pnl_calcuviaj.Controls.Add(this.lblTituloEficiencia);
            this.pnl_calcuviaj.Controls.Add(this.lblKilometros);
            this.pnl_calcuviaj.Controls.Add(this.txtKilometros);
            this.pnl_calcuviaj.Controls.Add(this.lblGasolina);
            this.pnl_calcuviaj.Controls.Add(this.txtGasolina);
            this.pnl_calcuviaj.Controls.Add(this.btnCalcularEficiencia);
            this.pnl_calcuviaj.Controls.Add(this.lblResultadoEficiencia);
            this.pnl_calcuviaj.Controls.Add(this.lblTituloGasto);
            this.pnl_calcuviaj.Controls.Add(this.lblDistancia);
            this.pnl_calcuviaj.Controls.Add(this.txtDistancia);
            this.pnl_calcuviaj.Controls.Add(this.lblEficiencia);
            this.pnl_calcuviaj.Controls.Add(this.txtEficiencia);
            this.pnl_calcuviaj.Controls.Add(this.lblCostoGalon);
            this.pnl_calcuviaj.Controls.Add(this.txtCostoGalon);
            this.pnl_calcuviaj.Controls.Add(this.btnCalcularGasto);
            this.pnl_calcuviaj.Controls.Add(this.lblResultadoGasto);
            this.pnl_calcuviaj.Controls.Add(this.btnVolver);
            this.pnl_calcuviaj.Location = new System.Drawing.Point(12, 10);
            this.pnl_calcuviaj.Name = "pnl_calcuviaj";
            this.pnl_calcuviaj.Size = new System.Drawing.Size(476, 478);
            this.pnl_calcuviaj.TabIndex = 17;
            // 
            // frm_CalcularViaje
            // 
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pnl_calcuviaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_CalcularViaje";
            this.Text = "Calculadora de Viaje";
            this.Load += new System.EventHandler(this.frm_CalcularViaje_Load);
            this.pnl_calcuviaj.ResumeLayout(false);
            this.pnl_calcuviaj.PerformLayout();
            this.ResumeLayout(false);

        }

        private Panel pnl_calcuviaj;
    }
}
