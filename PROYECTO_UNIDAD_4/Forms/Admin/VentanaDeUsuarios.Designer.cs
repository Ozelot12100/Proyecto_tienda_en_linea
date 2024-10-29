namespace PROYECTO_UNIDAD_4.Forms.Admin
{
    partial class VentanaDeUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbTipoUsuario = new ComboBox();
            lbltipoUsuario = new Label();
            btnCargarUsuarios = new Button();
            dgvTablaUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEditar = new Guna.UI2.WinForms.Guna2Button();
            btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            btnCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTablaUsuarios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.Font = new Font("Century Gothic", 10.8F);
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Items.AddRange(new object[] { "Administrador", "Cliente", "Vendedor" });
            cmbTipoUsuario.Location = new Point(197, 85);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(213, 29);
            cmbTipoUsuario.TabIndex = 1;
            // 
            // lbltipoUsuario
            // 
            lbltipoUsuario.AutoSize = true;
            lbltipoUsuario.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            lbltipoUsuario.ForeColor = Color.White;
            lbltipoUsuario.Location = new Point(38, 85);
            lbltipoUsuario.Name = "lbltipoUsuario";
            lbltipoUsuario.Size = new Size(144, 22);
            lbltipoUsuario.TabIndex = 2;
            lbltipoUsuario.Text = "Tipo de usuario";
            // 
            // btnCargarUsuarios
            // 
            btnCargarUsuarios.BackColor = Color.Green;
            btnCargarUsuarios.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarUsuarios.ForeColor = Color.White;
            btnCargarUsuarios.Image = Properties.Resources.cargar_usuario1;
            btnCargarUsuarios.ImageAlign = ContentAlignment.MiddleRight;
            btnCargarUsuarios.Location = new Point(445, 175);
            btnCargarUsuarios.Name = "btnCargarUsuarios";
            btnCargarUsuarios.Size = new Size(146, 53);
            btnCargarUsuarios.TabIndex = 3;
            btnCargarUsuarios.Text = "Cargar usuarios";
            btnCargarUsuarios.UseVisualStyleBackColor = false;
            btnCargarUsuarios.Click += btnCargarUsuarios_Click;
            // 
            // dgvTablaUsuarios
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(128, 128, 255);
            dgvTablaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTablaUsuarios.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTablaUsuarios.ColumnHeadersHeight = 22;
            dgvTablaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTablaUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTablaUsuarios.GridColor = Color.Black;
            dgvTablaUsuarios.Location = new Point(419, 254);
            dgvTablaUsuarios.Name = "dgvTablaUsuarios";
            dgvTablaUsuarios.RowHeadersVisible = false;
            dgvTablaUsuarios.RowHeadersWidth = 51;
            dgvTablaUsuarios.Size = new Size(359, 185);
            dgvTablaUsuarios.TabIndex = 6;
            dgvTablaUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTablaUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTablaUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTablaUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTablaUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTablaUsuarios.ThemeStyle.BackColor = SystemColors.ActiveCaption;
            dgvTablaUsuarios.ThemeStyle.GridColor = Color.Black;
            dgvTablaUsuarios.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTablaUsuarios.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTablaUsuarios.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvTablaUsuarios.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTablaUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvTablaUsuarios.ThemeStyle.HeaderStyle.Height = 22;
            dgvTablaUsuarios.ThemeStyle.ReadOnly = false;
            dgvTablaUsuarios.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTablaUsuarios.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTablaUsuarios.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvTablaUsuarios.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTablaUsuarios.ThemeStyle.RowsStyle.Height = 29;
            dgvTablaUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTablaUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvTablaUsuarios.SelectionChanged += dgvTablaUsuarios_SelectionChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.CustomizableEdges = customizableEdges1;
            txtUsuario.DefaultText = "";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Century Gothic", 10.8F);
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Location = new Point(197, 138);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.PlaceholderText = "";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsuario.Size = new Size(213, 35);
            txtUsuario.TabIndex = 7;
            // 
            // txtContraseña
            // 
            txtContraseña.CustomizableEdges = customizableEdges3;
            txtContraseña.DefaultText = "";
            txtContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Font = new Font("Century Gothic", 10.8F);
            txtContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Location = new Point(197, 193);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '\0';
            txtContraseña.PlaceholderText = "";
            txtContraseña.SelectedText = "";
            txtContraseña.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtContraseña.Size = new Size(213, 35);
            txtContraseña.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(107, 138);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 9;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 198);
            label2.Name = "label2";
            label2.Size = new Size(113, 22);
            label2.TabIndex = 10;
            label2.Text = "Contraseña";
            // 
            // btnEditar
            // 
            btnEditar.CustomizableEdges = customizableEdges5;
            btnEditar.DisabledState.BorderColor = Color.DarkGray;
            btnEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditar.FillColor = Color.FromArgb(0, 80, 200);
            btnEditar.FocusedColor = Color.White;
            btnEditar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.ImageAlign = HorizontalAlignment.Right;
            btnEditar.Location = new Point(96, 275);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditar.Size = new Size(113, 41);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.CustomizableEdges = customizableEdges7;
            btnEliminar.DisabledState.BorderColor = Color.DarkGray;
            btnEliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEliminar.FillColor = Color.Red;
            btnEliminar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Properties.Resources.eliminar;
            btnEliminar.ImageAlign = HorizontalAlignment.Right;
            btnEliminar.Location = new Point(269, 275);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnEliminar.Size = new Size(141, 41);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 36);
            panel1.TabIndex = 13;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = Properties.Resources.logSalir1;
            btnCerrar.Location = new Point(762, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoBueno;
            pictureBox1.Location = new Point(672, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // VentanaDeUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(790, 451);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(dgvTablaUsuarios);
            Controls.Add(btnCargarUsuarios);
            Controls.Add(lbltipoUsuario);
            Controls.Add(cmbTipoUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaDeUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaDeUsuarios";
            Load += VentanaDeUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTablaUsuarios).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox cmbTipoUsuario;
        private Label lbltipoUsuario;
        private Button btnCargarUsuarios;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombreDeUsuario;
        private DataGridViewTextBoxColumn rol;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTablaUsuarios;
        private DataGridViewTextBoxColumn TipoUsuario;
        private DataGridViewTextBoxColumn TipoRoll;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Panel panel1;
        private PictureBox btnCerrar;
        private PictureBox pictureBox1;
    }
}