using Guna.UI2.WinForms.Suite;
using Guna.UI2.WinForms;

namespace PROYECTO_UNIDAD_4.Forms.Cliente
{
    partial class formRopa
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
            pnlRopa = new Guna.UI2.WinForms.Guna2Panel();
            nubNumeroPiezas = new NumericUpDown();
            btnAgregarProductoAlCarrito = new Guna.UI2.WinForms.Guna2Button();
            dgvRopa = new Guna.UI2.WinForms.Guna2DataGridView();
            txtBuscador = new Guna.UI2.WinForms.Guna2TextBox();
            pnlRopa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nubNumeroPiezas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRopa).BeginInit();
            SuspendLayout();
            // 
            // pnlRopa
            // 
            pnlRopa.BackColor = Color.Salmon;
            pnlRopa.Controls.Add(txtBuscador);
            pnlRopa.Controls.Add(nubNumeroPiezas);
            pnlRopa.Controls.Add(btnAgregarProductoAlCarrito);
            pnlRopa.Controls.Add(dgvRopa);
            pnlRopa.CustomizableEdges = customizableEdges5;
            pnlRopa.Dock = DockStyle.Fill;
            pnlRopa.Location = new Point(0, 0);
            pnlRopa.Margin = new Padding(3, 4, 3, 4);
            pnlRopa.Name = "pnlRopa";
            pnlRopa.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlRopa.Size = new Size(1010, 705);
            pnlRopa.TabIndex = 0;
            // 
            // nubNumeroPiezas
            // 
            nubNumeroPiezas.Location = new Point(288, 338);
            nubNumeroPiezas.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            nubNumeroPiezas.Name = "nubNumeroPiezas";
            nubNumeroPiezas.Size = new Size(150, 27);
            nubNumeroPiezas.TabIndex = 3;
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
            btnAgregarProductoAlCarrito.Location = new Point(465, 324);
            btnAgregarProductoAlCarrito.Name = "btnAgregarProductoAlCarrito";
            btnAgregarProductoAlCarrito.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAgregarProductoAlCarrito.Size = new Size(225, 56);
            btnAgregarProductoAlCarrito.TabIndex = 2;
            btnAgregarProductoAlCarrito.Text = "Agregar ";
            btnAgregarProductoAlCarrito.Click += btnAgregarProductoAlCarrito_Click;
            // 
            // dgvRopa
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvRopa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRopa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRopa.ColumnHeadersHeight = 4;
            dgvRopa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRopa.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRopa.GridColor = Color.FromArgb(231, 229, 255);
            dgvRopa.Location = new Point(356, 108);
            dgvRopa.Name = "dgvRopa";
            dgvRopa.RowHeadersVisible = false;
            dgvRopa.RowHeadersWidth = 51;
            dgvRopa.Size = new Size(300, 188);
            dgvRopa.TabIndex = 0;
            dgvRopa.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvRopa.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvRopa.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvRopa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvRopa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvRopa.ThemeStyle.BackColor = Color.White;
            dgvRopa.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvRopa.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvRopa.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRopa.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvRopa.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvRopa.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRopa.ThemeStyle.HeaderStyle.Height = 4;
            dgvRopa.ThemeStyle.ReadOnly = false;
            dgvRopa.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvRopa.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRopa.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvRopa.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvRopa.ThemeStyle.RowsStyle.Height = 29;
            dgvRopa.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvRopa.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            txtBuscador.Location = new Point(241, 37);
            txtBuscador.Margin = new Padding(3, 5, 3, 5);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PasswordChar = '\0';
            txtBuscador.PlaceholderText = "";
            txtBuscador.SelectedText = "";
            txtBuscador.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscador.Size = new Size(379, 48);
            txtBuscador.TabIndex = 0;

            // 
            // formRopa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 705);
            Controls.Add(pnlRopa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formRopa";
            Text = "formRopa";
            pnlRopa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nubNumeroPiezas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRopa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlRopa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRopa;
        private Guna.UI2.WinForms.Guna2Button btnAgregarProductoAlCarrito;
        private NumericUpDown nubNumeroPiezas;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscador;
    }
}