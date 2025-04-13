using System.Windows.Forms;

namespace Wfrm_RastreoVehiculos.vistas
{
    partial class frm_Login
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pnl_login = new System.Windows.Forms.Panel();
            this.picture_Login = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.pnl_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.White;
            this.pnl_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_login.Controls.Add(this.picture_Login);
            this.pnl_login.Controls.Add(this.btn_Cancel);
            this.pnl_login.Controls.Add(this.btn_Login);
            this.pnl_login.Controls.Add(this.txt_Password);
            this.pnl_login.Controls.Add(this.lbl_Password);
            this.pnl_login.Controls.Add(this.txt_Username);
            this.pnl_login.Controls.Add(this.lbl_Username);
            this.pnl_login.Location = new System.Drawing.Point(53, 44);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(675, 302);
            this.pnl_login.TabIndex = 6;
            this.pnl_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picture_Login
            // 
            this.picture_Login.BackColor = System.Drawing.Color.White;
            this.picture_Login.Image = ((System.Drawing.Image)(resources.GetObject("picture_Login.Image")));
            this.picture_Login.Location = new System.Drawing.Point(356, 3);
            this.picture_Login.Name = "picture_Login";
            this.picture_Login.Size = new System.Drawing.Size(312, 292);
            this.picture_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Login.TabIndex = 7;
            this.picture_Login.TabStop = false;
            this.picture_Login.Click += new System.EventHandler(this.picture_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(208, 180);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(64, 20);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click_1);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(100, 180);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(64, 20);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "Iniciar Sesión";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(100, 143);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(172, 20);
            this.txt_Password.TabIndex = 9;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged_1);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(19, 146);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(64, 13);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Contraseña:";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(100, 108);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(172, 20);
            this.txt_Username.TabIndex = 7;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(19, 111);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(46, 13);
            this.lbl_Username.TabIndex = 6;
            this.lbl_Username.Text = "Usuario:";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(757, 388);
            this.Controls.Add(this.pnl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Login)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private PictureBox picture_Login;
    }
}
