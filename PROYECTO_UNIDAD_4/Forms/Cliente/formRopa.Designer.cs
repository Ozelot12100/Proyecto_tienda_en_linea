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
            CustomizableEdges customizableEdges5 = new CustomizableEdges();
            CustomizableEdges customizableEdges6 = new CustomizableEdges();
            CustomizableEdges customizableEdges1 = new CustomizableEdges();
            CustomizableEdges customizableEdges2 = new CustomizableEdges();
            CustomizableEdges customizableEdges3 = new CustomizableEdges();
            CustomizableEdges customizableEdges4 = new CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlRopa = new Guna2Panel();
            txtBuscador = new Guna2TextBox();
            nubNumeroPiezas = new NumericUpDown();
            btnAgregarProductoAlCarrito = new Guna2Button();
            dgvRopa = new Guna2DataGridView();
            pnlRopa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nubNumeroPiezas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRopa).BeginInit();
            SuspendLayout();
            // 
            // pnlRopa
            // 
            pnlRopa.BackColor = Color.FromArgb(0, 90, 150);
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
            txtBuscador.Location = new Point(244, 14);
            txtBuscador.Margin = new Padding(4, 5, 4, 5);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PasswordChar = '\0';
            txtBuscador.PlaceholderText = "";
            txtBuscador.SelectedText = "";
            txtBuscador.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscador.Size = new Size(474, 54);
            txtBuscador.TabIndex = 0;
            // 
            // nubNumeroPiezas
            // 
            nubNumeroPiezas.BackColor = Color.Lime;
            nubNumeroPiezas.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            nubNumeroPiezas.Location = new Point(547, 377);
            nubNumeroPiezas.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            nubNumeroPiezas.Name = "nubNumeroPiezas";
            nubNumeroPiezas.Size = new Size(63, 32);
            nubNumeroPiezas.TabIndex = 3;
            nubNumeroPiezas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarProductoAlCarrito
            // 
            btnAgregarProductoAlCarrito.Cursor = Cursors.Hand;
            btnAgregarProductoAlCarrito.CustomizableEdges = customizableEdges3;
            btnAgregarProductoAlCarrito.DisabledState.BorderColor = Color.DarkGray;
            btnAgregarProductoAlCarrito.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregarProductoAlCarrito.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregarProductoAlCarrito.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregarProductoAlCarrito.FillColor = Color.FromArgb(0, 192, 192);
            btnAgregarProductoAlCarrito.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnAgregarProductoAlCarrito.ForeColor = Color.Black;
            btnAgregarProductoAlCarrito.Image = Properties.Resources.añadir_carrito;
            btnAgregarProductoAlCarrito.ImageAlign = HorizontalAlignment.Right;
            btnAgregarProductoAlCarrito.Location = new Point(623, 335);
            btnAgregarProductoAlCarrito.Name = "btnAgregarProductoAlCarrito";
            btnAgregarProductoAlCarrito.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAgregarProductoAlCarrito.Size = new Size(171, 74);
            btnAgregarProductoAlCarrito.TabIndex = 2;
            btnAgregarProductoAlCarrito.Text = "Agregar al carrito";
            btnAgregarProductoAlCarrito.Click += btnAgregarProductoAlCarrito_Click;
            // 
            // dgvRopa
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvRopa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRopa.BackgroundColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRopa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRopa.ColumnHeadersHeight = 4;
            dgvRopa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRopa.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRopa.GridColor = Color.FromArgb(231, 229, 255);
            dgvRopa.Location = new Point(81, 93);
            dgvRopa.Name = "dgvRopa";
            dgvRopa.RowHeadersVisible = false;
            dgvRopa.RowHeadersWidth = 51;
            dgvRopa.Size = new Size(460, 316);
            dgvRopa.TabIndex = 0;
            dgvRopa.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvRopa.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvRopa.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvRopa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvRopa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvRopa.ThemeStyle.BackColor = Color.FromArgb(128, 128, 255);
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