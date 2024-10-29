namespace PROYECTO_UNIDAD_4.Forms.InicioDeSesion
{
    partial class RegistroCliente
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
            panel1 = new Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnRegistrase = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 27);
            panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Copperplate Gothic Bold", 12F);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(60, 141);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(99, 25);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Usuario:";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Copperplate Gothic Bold", 12F);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(22, 188);
            guna2HtmlLabel2.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(148, 25);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(169, 132);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(172, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(170, 188);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(171, 27);
            txtContraseña.TabIndex = 4;
            // 
            // btnRegistrase
            // 
            btnRegistrase.BackColor = Color.SpringGreen;
            btnRegistrase.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrase.Image = Properties.Resources.cargar_usuario3;
            btnRegistrase.ImageAlign = ContentAlignment.MiddleRight;
            btnRegistrase.Location = new Point(142, 270);
            btnRegistrase.Margin = new Padding(3, 4, 3, 4);
            btnRegistrase.Name = "btnRegistrase";
            btnRegistrase.Size = new Size(189, 52);
            btnRegistrase.TabIndex = 5;
            btnRegistrase.Text = "Guardar";
            btnRegistrase.UseVisualStyleBackColor = false;
            btnRegistrase.Click += btnRegistrase_Click;
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 42, 57);
            ClientSize = new Size(453, 385);
            Controls.Add(btnRegistrase);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnRegistrase;
    }

       
    
}