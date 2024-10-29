namespace PROYECTO_UNIDAD_4
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            panel1 = new Panel();
            btnCerrar = new PictureBox();
            btnEntrar = new Button();
            lblNER = new Label();
            btnRegistrame = new Button();
            guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(364, 312);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(179, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(239, 317);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(94, 27);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            lblContraseña.ForeColor = Color.White;
            lblContraseña.Location = new Point(216, 368);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(142, 27);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.CustomizableEdges = customizableEdges1;
            txtContraseña.DefaultText = "";
            txtContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Font = new Font("Segoe UI", 9F);
            txtContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Location = new Point(364, 368);
            txtContraseña.Margin = new Padding(3, 5, 3, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "";
            txtContraseña.SelectedText = "";
            txtContraseña.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtContraseña.Size = new Size(180, 27);
            txtContraseña.TabIndex = 4;
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // guna2ImageButton2
            // 
            guna2ImageButton2.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton2.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton2.Image = (Image)resources.GetObject("guna2ImageButton2.Image");
            guna2ImageButton2.ImageOffset = new Point(0, 0);
            guna2ImageButton2.ImageRotate = 0F;
            guna2ImageButton2.ImageSize = new Size(200, 150);
            guna2ImageButton2.Location = new Point(0, 559);
            guna2ImageButton2.Margin = new Padding(3, 4, 3, 4);
            guna2ImageButton2.Name = "guna2ImageButton2";
            guna2ImageButton2.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2ImageButton2.Size = new Size(206, 171);
            guna2ImageButton2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 40);
            panel1.TabIndex = 7;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(805, 0);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(29, 33);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 2;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Teal;
            btnEntrar.FlatAppearance.BorderColor = Color.FromArgb(91, 194, 231);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(91, 194, 231);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(91, 194, 231);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Image = Properties.Resources.cargar_usuario3;
            btnEntrar.ImageAlign = ContentAlignment.MiddleRight;
            btnEntrar.Location = new Point(371, 429);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(150, 44);
            btnEntrar.TabIndex = 9;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // lblNER
            // 
            lblNER.AutoSize = true;
            lblNER.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNER.ForeColor = Color.White;
            lblNER.Location = new Point(351, 508);
            lblNER.Name = "lblNER";
            lblNER.Size = new Size(192, 21);
            lblNER.TabIndex = 10;
            lblNER.Text = "¿No estás registrado?";
            // 
            // btnRegistrame
            // 
            btnRegistrame.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btnRegistrame.FlatAppearance.BorderSize = 0;
            btnRegistrame.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 192);
            btnRegistrame.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            btnRegistrame.FlatStyle = FlatStyle.Flat;
            btnRegistrame.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrame.ForeColor = Color.Red;
            btnRegistrame.Location = new Point(364, 559);
            btnRegistrame.Margin = new Padding(3, 4, 3, 4);
            btnRegistrame.Name = "btnRegistrame";
            btnRegistrame.Size = new Size(173, 53);
            btnRegistrame.TabIndex = 11;
            btnRegistrame.Text = "Registrarme";
            btnRegistrame.UseVisualStyleBackColor = true;
            btnRegistrame.Click += btnRegistrame_Click;
            // 
            // guna2ImageButton3
            // 
            guna2ImageButton3.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton3.Image = (Image)resources.GetObject("guna2ImageButton3.Image");
            guna2ImageButton3.ImageOffset = new Point(0, 0);
            guna2ImageButton3.ImageRotate = 0F;
            guna2ImageButton3.ImageSize = new Size(150, 120);
            guna2ImageButton3.Location = new Point(315, 68);
            guna2ImageButton3.Margin = new Padding(3, 4, 3, 4);
            guna2ImageButton3.Name = "guna2ImageButton3";
            guna2ImageButton3.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ImageButton3.Size = new Size(206, 188);
            guna2ImageButton3.TabIndex = 12;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 31);
            ClientSize = new Size(837, 728);
            Controls.Add(guna2ImageButton3);
            Controls.Add(btnRegistrame);
            Controls.Add(lblNER);
            Controls.Add(btnEntrar);
            Controls.Add(panel1);
            Controls.Add(guna2ImageButton2);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Label lblContraseña;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Panel panel1;
        private PictureBox btnCerrar;
        private Button btnEntrar;
        private Label lblNER;
        private Button btnRegistrame;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
    }
}
