using System.Windows.Forms;
using System.Xml.Linq;

namespace Wfrm_RastreoVehiculos.vistas
{
partial class frm_RegistroVehiculos
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.DataGridView dgvVehiculos;
    private System.Windows.Forms.Button btnRegistrar;
    private System.Windows.Forms.Button btnEditar;
    private System.Windows.Forms.TextBox txtBuscar;
    private System.Windows.Forms.Label lblBuscar;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnl_Registro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.pnl_Registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(6, 65);
            this.dgvVehiculos.MultiSelect = false;
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(634, 303);
            this.dgvVehiculos.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(6, 20);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(86, 26);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(100, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 26);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(498, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(143, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(355, 25);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(137, 13);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar por nombre o placa:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(203, 20);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 26);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pnl_Registro
            // 
            this.pnl_Registro.BackColor = System.Drawing.Color.Beige;
            this.pnl_Registro.Controls.Add(this.btnVolver);
            this.pnl_Registro.Controls.Add(this.txtBuscar);
            this.pnl_Registro.Controls.Add(this.lblBuscar);
            this.pnl_Registro.Controls.Add(this.btnEditar);
            this.pnl_Registro.Controls.Add(this.btnRegistrar);
            this.pnl_Registro.Controls.Add(this.dgvVehiculos);
            this.pnl_Registro.Location = new System.Drawing.Point(12, 7);
            this.pnl_Registro.Name = "pnl_Registro";
            this.pnl_Registro.Size = new System.Drawing.Size(649, 383);
            this.pnl_Registro.TabIndex = 18;
            // 
            // frm_RegistroVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(673, 406);
            this.Controls.Add(this.pnl_Registro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_RegistroVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Vehículos";
            this.Load += new System.EventHandler(this.frm_RegistroVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.pnl_Registro.ResumeLayout(false);
            this.pnl_Registro.PerformLayout();
            this.ResumeLayout(false);

    }

        private Button btnVolver;
        private Panel pnl_Registro;
    }
}



