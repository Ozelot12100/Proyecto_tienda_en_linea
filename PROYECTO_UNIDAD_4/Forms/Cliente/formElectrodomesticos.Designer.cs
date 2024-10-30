namespace PROYECTO_UNIDAD_4.Forms.Cliente
{
    partial class formElectrodomesticos
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
            pnlElectronicos = new Guna.UI2.WinForms.Guna2Panel();
            txtBuscador = new Guna.UI2.WinForms.Guna2TextBox();
            nubNumeroPiezas = new NumericUpDown();
            btnAgregarProductoAlCarrito = new Guna.UI2.WinForms.Guna2Button();
            dgvElectronica = new Guna.UI2.WinForms.Guna2DataGridView();
            pnlElectronicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nubNumeroPiezas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvElectronica).BeginInit();
            SuspendLayout();
            // 
            // pnlElectronicos
            // 
            pnlElectronicos.BackColor = Color.FromArgb(0, 90, 150);
            pnlElectronicos.Controls.Add(txtBuscador);
            pnlElectronicos.Controls.Add(nubNumeroPiezas);
            pnlElectronicos.Controls.Add(btnAgregarProductoAlCarrito);
            pnlElectronicos.Controls.Add(dgvElectronica);
            pnlElectronicos.CustomizableEdges = customizableEdges5;
            pnlElectronicos.Dock = DockStyle.Fill;
            pnlElectronicos.Location = new Point(0, 0);
            pnlElectronicos.Margin = new Padding(3, 4, 3, 4);
            pnlElectronicos.Name = "pnlElectronicos";
            pnlElectronicos.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlElectronicos.Size = new Size(904, 752);
            pnlElectronicos.TabIndex = 0;
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
            txtBuscador.Location = new Point(186, 14);
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
            nubNumeroPiezas.Location = new Point(590, 338);
            nubNumeroPiezas.Name = "nubNumeroPiezas";
            nubNumeroPiezas.Size = new Size(54, 32);
            nubNumeroPiezas.TabIndex = 2;
            nubNumeroPiezas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarProductoAlCarrito
            // 
            btnAgregarProductoAlCarrito.CustomizableEdges = customizableEdges3;
            btnAgregarProductoAlCarrito.DisabledState.BorderColor = Color.DarkGray;
            btnAgregarProductoAlCarrito.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregarProductoAlCarrito.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregarProductoAlCarrito.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregarProductoAlCarrito.FillColor = Color.FromArgb(0, 192, 192);
            btnAgregarProductoAlCarrito.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProductoAlCarrito.ForeColor = Color.Black;
            btnAgregarProductoAlCarrito.Image = Properties.Resources.añadir_carrito;
            btnAgregarProductoAlCarrito.ImageAlign = HorizontalAlignment.Right;
            btnAgregarProductoAlCarrito.Location = new Point(663, 314);
            btnAgregarProductoAlCarrito.Name = "btnAgregarProductoAlCarrito";
            btnAgregarProductoAlCarrito.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAgregarProductoAlCarrito.Size = new Size(181, 56);
            btnAgregarProductoAlCarrito.TabIndex = 1;
            btnAgregarProductoAlCarrito.Text = "Agregar al carrito";
            btnAgregarProductoAlCarrito.Click += btnAgregarProductoAlCarrito_Click;
            // 
            // dgvElectronica
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvElectronica.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvElectronica.BackgroundColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvElectronica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvElectronica.ColumnHeadersHeight = 4;
            dgvElectronica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvElectronica.DefaultCellStyle = dataGridViewCellStyle3;
            dgvElectronica.GridColor = Color.FromArgb(231, 229, 255);
            dgvElectronica.Location = new Point(69, 111);
            dgvElectronica.Name = "dgvElectronica";
            dgvElectronica.RowHeadersVisible = false;
            dgvElectronica.RowHeadersWidth = 51;
            dgvElectronica.Size = new Size(515, 259);
            dgvElectronica.TabIndex = 0;
            dgvElectronica.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvElectronica.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvElectronica.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvElectronica.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvElectronica.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvElectronica.ThemeStyle.BackColor = Color.FromArgb(128, 128, 255);
            dgvElectronica.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvElectronica.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvElectronica.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvElectronica.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvElectronica.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvElectronica.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvElectronica.ThemeStyle.HeaderStyle.Height = 4;
            dgvElectronica.ThemeStyle.ReadOnly = false;
            dgvElectronica.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvElectronica.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvElectronica.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvElectronica.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvElectronica.ThemeStyle.RowsStyle.Height = 29;
            dgvElectronica.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvElectronica.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // formElectrodomesticos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 752);
            Controls.Add(pnlElectronicos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formElectrodomesticos";
            Text = "formElectrodomesticos";
            pnlElectronicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nubNumeroPiezas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvElectronica).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlElectronicos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvElectronica;
        private Guna.UI2.WinForms.Guna2Button btnAgregarProductoAlCarrito;
        private NumericUpDown nubNumeroPiezas;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscador;
    }
}