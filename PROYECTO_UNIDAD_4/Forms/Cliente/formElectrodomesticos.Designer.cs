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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlElectronicos = new Guna.UI2.WinForms.Guna2Panel();
            nubNumeroPiezas = new NumericUpDown();
            btnAgregarProductoAlCarrito = new Guna.UI2.WinForms.Guna2Button();
            dgvElectronica = new Guna.UI2.WinForms.Guna2DataGridView();
            txtBuscador = new Guna.UI2.WinForms.Guna2TextBox();
            pnlElectronicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nubNumeroPiezas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvElectronica).BeginInit();
            SuspendLayout();
            // 
            // pnlElectronicos
            // 
            pnlElectronicos.BackColor = Color.SlateBlue;
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
            // nubNumeroPiezas
            // 
            nubNumeroPiezas.Location = new Point(219, 323);
            nubNumeroPiezas.Name = "nubNumeroPiezas";
            nubNumeroPiezas.Size = new Size(150, 27);
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
            btnAgregarProductoAlCarrito.Font = new Font("Segoe UI", 9F);
            btnAgregarProductoAlCarrito.ForeColor = Color.White;
            btnAgregarProductoAlCarrito.Location = new Point(375, 306);
            btnAgregarProductoAlCarrito.Name = "btnAgregarProductoAlCarrito";
            btnAgregarProductoAlCarrito.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAgregarProductoAlCarrito.Size = new Size(225, 56);
            btnAgregarProductoAlCarrito.TabIndex = 1;
            btnAgregarProductoAlCarrito.Text = "Agregar ";
            btnAgregarProductoAlCarrito.Click += btnAgregarProductoAlCarrito_Click;
            // 
            // dgvElectronica
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvElectronica.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
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
            dgvElectronica.Location = new Point(300, 101);
            dgvElectronica.Name = "dgvElectronica";
            dgvElectronica.RowHeadersVisible = false;
            dgvElectronica.RowHeadersWidth = 51;
            dgvElectronica.Size = new Size(300, 188);
            dgvElectronica.TabIndex = 0;
            dgvElectronica.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvElectronica.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvElectronica.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvElectronica.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvElectronica.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvElectronica.ThemeStyle.BackColor = Color.White;
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
            // txtBuscador
            // 
            txtBuscador.CustomizableEdges = customizableEdges1;
            txtBuscador.DefaultText = "Buscar";
            txtBuscador.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscador.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscador.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscador.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscador.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscador.Font = new Font("Segoe UI", 9F);
            txtBuscador.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscador.Location = new Point(255, 25);
            txtBuscador.Margin = new Padding(3, 5, 3, 5);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PasswordChar = '\0';
            txtBuscador.PlaceholderText = "";
            txtBuscador.SelectedText = "";
            txtBuscador.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscador.Size = new Size(379, 48);
            txtBuscador.TabIndex = 3;
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