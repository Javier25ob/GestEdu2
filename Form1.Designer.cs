namespace GestEdu
{
    partial class frminicioSesiónusuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnprobarConexion = new Button();
            picLogo = new PictureBox();
            lblnombreUsuario = new Label();
            txtnombreUsuario = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            cborolUsuario = new ComboBox();
            lblRol = new Label();
            btniniciarSesión = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnprobarConexion
            // 
            btnprobarConexion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnprobarConexion.Location = new Point(12, 415);
            btnprobarConexion.Name = "btnprobarConexion";
            btnprobarConexion.Size = new Size(147, 23);
            btnprobarConexion.TabIndex = 0;
            btnprobarConexion.Text = "Probar Conexión a DB";
            btnprobarConexion.UseVisualStyleBackColor = true;
            btnprobarConexion.Click += btnprobarConexion_Click;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new Point(1, 1);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(324, 224);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // lblnombreUsuario
            // 
            lblnombreUsuario.AutoSize = true;
            lblnombreUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombreUsuario.Location = new Point(12, 257);
            lblnombreUsuario.Name = "lblnombreUsuario";
            lblnombreUsuario.Size = new Size(115, 15);
            lblnombreUsuario.TabIndex = 2;
            lblnombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtnombreUsuario
            // 
            txtnombreUsuario.BackColor = SystemColors.Window;
            txtnombreUsuario.Location = new Point(131, 254);
            txtnombreUsuario.Name = "txtnombreUsuario";
            txtnombreUsuario.Size = new Size(157, 23);
            txtnombreUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(131, 301);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(157, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(12, 304);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña Usuario";
            // 
            // cborolUsuario
            // 
            cborolUsuario.FormattingEnabled = true;
            cborolUsuario.Location = new Point(131, 344);
            cborolUsuario.Name = "cborolUsuario";
            cborolUsuario.Size = new Size(157, 23);
            cborolUsuario.TabIndex = 6;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.Location = new Point(12, 347);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(25, 15);
            lblRol.TabIndex = 7;
            lblRol.Text = "Rol";
            // 
            // btniniciarSesión
            // 
            btniniciarSesión.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btniniciarSesión.Image = Properties.Resources.perfil2;
            btniniciarSesión.Location = new Point(203, 388);
            btniniciarSesión.Name = "btniniciarSesión";
            btniniciarSesión.Size = new Size(85, 67);
            btniniciarSesión.TabIndex = 8;
            btniniciarSesión.Text = "Iniciar Sesión";
            btniniciarSesión.TextAlign = ContentAlignment.BottomCenter;
            btniniciarSesión.UseVisualStyleBackColor = true;
            btniniciarSesión.Click += btniniciarSesión_Click;
            // 
            // frminicioSesiónusuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(324, 467);
            Controls.Add(btniniciarSesión);
            Controls.Add(lblRol);
            Controls.Add(cborolUsuario);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtnombreUsuario);
            Controls.Add(lblnombreUsuario);
            Controls.Add(picLogo);
            Controls.Add(btnprobarConexion);
            Name = "frminicioSesiónusuario";
            Text = "Formulario Inicio de Sesión Usuario";
            Load += frminicioSesiónusuario_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnprobarConexion;
        private PictureBox picLogo;
        private Label lblnombreUsuario;
        private TextBox txtnombreUsuario;
        private TextBox txtPassword;
        private Label lblPassword;
        private ComboBox cborolUsuario;
        private Label lblRol;
        private Button btniniciarSesión;
    }
}
