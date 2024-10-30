namespace PROYECTO_UNIDAD_4.Forms.Cliente
{
    partial class formAlimentos
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlAlimentos = new Guna.UI2.WinForms.Guna2Panel();
            txtBuscador = new Guna.UI2.WinForms.Guna2TextBox();
            nubNumeroPiezas = new NumericUpDown();
            btnAgregarProductoAlCarrito = new Guna.UI2.WinForms.Guna2Button();
            dgvAlimentos = new Guna.UI2.WinForms.Guna2DataGridView();
            pnlAlimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nubNumeroPiezas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlimentos).BeginInit();
            SuspendLayout();
            // 
            // pnlAlimentos
            // 
            pnlAlimentos.BackColor = Color.FromArgb(0, 90, 150);
            pnlAlimentos.Controls.Add(txtBuscador);
            pnlAlimentos.Controls.Add(nubNumeroPiezas);
            pnlAlimentos.Controls.Add(btnAgregarProductoAlCarrito);
            pnlAlimentos.Controls.Add(dgvAlimentos);
            pnlAlimentos.CustomizableEdges = customizableEdges5;
            pnlAlimentos.Dock = DockStyle.Fill;
            pnlAlimentos.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            pnlAlimentos.Location = new Point(0, 0);
            pnlAlimentos.Margin = new Padding(3, 4, 3, 4);
            pnlAlimentos.Name = "pnlAlimentos";
            pnlAlimentos.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlAlimentos.Size = new Size(935, 699);
            pnlAlimentos.TabIndex = 0;
            // 
            // txtBuscador
            // 
            txtBuscador.CustomizableEdges = customizableEdges1;
            txtBuscador.DefaultText = "Buscar";
            txtBuscador.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscador.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscador.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscador.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscador.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscador.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtBuscador.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscador.Location = new Point(201, 14);
            txtBuscador.Margin = new Padding(4, 5, 4, 5);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PasswordChar = '\0';
            txtBuscador.PlaceholderText = "";
            txtBuscador.SelectedText = "";
            txtBuscador.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscador.Size = new Size(474, 50);
            txtBuscador.TabIndex = 3;
            // 
            // nubNumeroPiezas
            // 
            nubNumeroPiezas.BackColor = Color.Lime;
            nubNumeroPiezas.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nubNumeroPiezas.ForeColor = Color.Black;
            nubNumeroPiezas.Location = new Point(628, 322);
            nubNumeroPiezas.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            nubNumeroPiezas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nubNumeroPiezas.Name = "nubNumeroPiezas";
            nubNumeroPiezas.ReadOnly = true;
            nubNumeroPiezas.Size = new Size(47, 32);
            nubNumeroPiezas.TabIndex = 0;
            nubNumeroPiezas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarProductoAlCarrito
            // 
            btnAgregarProductoAlCarrito.BackColor = Color.FromArgb(0, 90, 150);
            btnAgregarProductoAlCarrito.CustomizableEdges = customizableEdges3;
            btnAgregarProductoAlCarrito.DisabledState.BorderColor = Color.DarkGray;
            btnAgregarProductoAlCarrito.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregarProductoAlCarrito.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregarProductoAlCarrito.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregarProductoAlCarrito.FillColor = Color.FromArgb(0, 192, 192);
            btnAgregarProductoAlCarrito.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btnAgregarProductoAlCarrito.ForeColor = Color.Black;
            btnAgregarProductoAlCarrito.Image = Properties.Resources.añadir_carrito;
            btnAgregarProductoAlCarrito.ImageAlign = HorizontalAlignment.Right;
            btnAgregarProductoAlCarrito.Location = new Point(697, 298);
            btnAgregarProductoAlCarrito.Name = "btnAgregarProductoAlCarrito";
            btnAgregarProductoAlCarrito.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAgregarProductoAlCarrito.Size = new Size(172, 56);
            btnAgregarProductoAlCarrito.TabIndex = 2;
            btnAgregarProductoAlCarrito.Text = "Agregar  al carrito";
            btnAgregarProductoAlCarrito.Click += btnAgregarProductoAlCarrito_Click;
            // 
            // dgvAlimentos
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvAlimentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlimentos.BackgroundColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAlimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAlimentos.ColumnHeadersHeight = 4;
            dgvAlimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAlimentos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAlimentos.GridColor = Color.FromArgb(231, 229, 255);
            dgvAlimentos.Location = new Point(85, 110);
            dgvAlimentos.Name = "dgvAlimentos";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAlimentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAlimentos.RowHeadersVisible = false;
            dgvAlimentos.RowHeadersWidth = 51;
            dgvAlimentos.Size = new Size(517, 244);
            dgvAlimentos.TabIndex = 0;
            dgvAlimentos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvAlimentos.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvAlimentos.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvAlimentos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvAlimentos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvAlimentos.ThemeStyle.BackColor = Color.FromArgb(128, 128, 255);
            dgvAlimentos.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvAlimentos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvAlimentos.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAlimentos.ThemeStyle.HeaderStyle.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            dgvAlimentos.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvAlimentos.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAlimentos.ThemeStyle.HeaderStyle.Height = 4;
            dgvAlimentos.ThemeStyle.ReadOnly = false;
            dgvAlimentos.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAlimentos.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAlimentos.ThemeStyle.RowsStyle.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            dgvAlimentos.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvAlimentos.ThemeStyle.RowsStyle.Height = 29;
            dgvAlimentos.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvAlimentos.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // formAlimentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 699);
            Controls.Add(pnlAlimentos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formAlimentos";
            Text = "formAlimentos";
            pnlAlimentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nubNumeroPiezas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlimentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlAlimentos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAlimentos;
        private Guna.UI2.WinForms.Guna2Button btnAgregarProductoAlCarrito;
        private NumericUpDown nubNumeroPiezas;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscador;
    }
}