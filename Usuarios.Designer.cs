namespace GestEdu
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenido = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(69, 27);
            lblBienvenido.Margin = new Padding(6, 0, 6, 0);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(341, 30);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido a Gestion de Usuarios";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(170, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 35);
            textBox1.TabIndex = 1;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 490);
            Controls.Add(textBox1);
            Controls.Add(lblBienvenido);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmUsuario";
            Text = "Formulario de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private TextBox textBox1;
    }
}