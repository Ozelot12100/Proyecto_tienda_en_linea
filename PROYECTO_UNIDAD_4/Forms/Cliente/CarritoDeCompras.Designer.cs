namespace PROYECTO_UNIDAD_4.Forms.Cliente
{
    partial class CarritoDeCompras
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbMetodoPago = new Guna.UI2.WinForms.Guna2ComboBox();
            dgvCarrito = new Guna.UI2.WinForms.Guna2DataGridView();
            btnEliminar = new Button();
            lblMetodoDePago = new Label();
            btnFinalizarCompra = new Button();
            cmbTipoPago = new Guna.UI2.WinForms.Guna2ComboBox();
            lblTipoPago = new Label();
            lblMostrarSubtotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblMostrarTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblDescuento = new Label();
            lblImpuestos = new Label();
            lblSubtotall = new Label();
            lblMdescuento = new Label();
            lblMimpuestos = new Label();
            lblMTotal = new Label();
            lBLcaRROO = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.BackColor = Color.Transparent;
            cmbMetodoPago.CustomizableEdges = customizableEdges1;
            cmbMetodoPago.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbMetodoPago.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbMetodoPago.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            cmbMetodoPago.ForeColor = Color.Black;
            cmbMetodoPago.ItemHeight = 30;
            cmbMetodoPago.Items.AddRange(new object[] { "Tarjeta de credito", "PayPal", "Efectivo" });
            cmbMetodoPago.Location = new Point(206, 353);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbMetodoPago.Size = new Size(255, 36);
            cmbMetodoPago.TabIndex = 1;
            // 
            // dgvCarrito
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarrito.BackgroundColor = Color.PaleTurquoise;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gray;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCarrito.ColumnHeadersHeight = 24;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCarrito.GridColor = Color.FromArgb(231, 229, 255);
            dgvCarrito.Location = new Point(11, 59);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(1026, 269);
            dgvCarrito.TabIndex = 2;
            dgvCarrito.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCarrito.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCarrito.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCarrito.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCarrito.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCarrito.ThemeStyle.BackColor = Color.PaleTurquoise;
            dgvCarrito.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCarrito.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCarrito.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCarrito.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvCarrito.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCarrito.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCarrito.ThemeStyle.HeaderStyle.Height = 24;
            dgvCarrito.ThemeStyle.ReadOnly = false;
            dgvCarrito.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCarrito.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarrito.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvCarrito.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCarrito.ThemeStyle.RowsStyle.Height = 29;
            dgvCarrito.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCarrito.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCarrito.CellFormatting += dgvCarrito_CellFormatting;
            dgvCarrito.DataBindingComplete += dgvCarrito_DataBindingComplete;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Properties.Resources.eliminar;
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.Location = new Point(885, 336);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 65);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblMetodoDePago
            // 
            lblMetodoDePago.AutoSize = true;
            lblMetodoDePago.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            lblMetodoDePago.ForeColor = Color.White;
            lblMetodoDePago.Location = new Point(31, 353);
            lblMetodoDePago.Name = "lblMetodoDePago";
            lblMetodoDePago.Size = new Size(161, 22);
            lblMetodoDePago.TabIndex = 4;
            lblMetodoDePago.Text = "Metodo de pago";
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.BackColor = Color.Teal;
            btnFinalizarCompra.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnFinalizarCompra.ForeColor = Color.White;
            btnFinalizarCompra.Image = Properties.Resources.finalizar_compra;
            btnFinalizarCompra.ImageAlign = ContentAlignment.MiddleRight;
            btnFinalizarCompra.Location = new Point(563, 353);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(218, 65);
            btnFinalizarCompra.TabIndex = 5;
            btnFinalizarCompra.Text = "Finalizar Compra";
            btnFinalizarCompra.UseVisualStyleBackColor = false;
            btnFinalizarCompra.Click += btnFinalizarCompra_Click;
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.BackColor = Color.Transparent;
            cmbTipoPago.CustomizableEdges = customizableEdges3;
            cmbTipoPago.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPago.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbTipoPago.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbTipoPago.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            cmbTipoPago.ForeColor = Color.Black;
            cmbTipoPago.ItemHeight = 30;
            cmbTipoPago.Items.AddRange(new object[] { "En linea ", "En tienda" });
            cmbTipoPago.Location = new Point(206, 407);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbTipoPago.Size = new Size(175, 36);
            cmbTipoPago.TabIndex = 6;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            lblTipoPago.ForeColor = Color.White;
            lblTipoPago.Location = new Point(39, 409);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(151, 22);
            lblTipoPago.TabIndex = 7;
            lblTipoPago.Text = "Tipo de compra";
            // 
            // lblMostrarSubtotal
            // 
            lblMostrarSubtotal.BackColor = Color.Transparent;
            lblMostrarSubtotal.BorderStyle = BorderStyle.FixedSingle;
            lblMostrarSubtotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblMostrarSubtotal.ForeColor = Color.White;
            lblMostrarSubtotal.Location = new Point(223, 483);
            lblMostrarSubtotal.Margin = new Padding(3, 4, 3, 4);
            lblMostrarSubtotal.Name = "lblMostrarSubtotal";
            lblMostrarSubtotal.Size = new Size(5, 4);
            lblMostrarSubtotal.TabIndex = 8;
            lblMostrarSubtotal.Text = null;
            // 
            // lblMostrarTotal
            // 
            lblMostrarTotal.BackColor = Color.Transparent;
            lblMostrarTotal.BorderStyle = BorderStyle.FixedSingle;
            lblMostrarTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblMostrarTotal.ForeColor = Color.White;
            lblMostrarTotal.Location = new Point(221, 635);
            lblMostrarTotal.Margin = new Padding(3, 4, 3, 4);
            lblMostrarTotal.Name = "lblMostrarTotal";
            lblMostrarTotal.Size = new Size(5, 4);
            lblMostrarTotal.TabIndex = 9;
            lblMostrarTotal.Text = null;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BorderStyle = BorderStyle.FixedSingle;
            lblDescuento.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblDescuento.ForeColor = Color.White;
            lblDescuento.Location = new Point(219, 539);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(2, 25);
            lblDescuento.TabIndex = 10;
            // 
            // lblImpuestos
            // 
            lblImpuestos.AutoSize = true;
            lblImpuestos.BorderStyle = BorderStyle.FixedSingle;
            lblImpuestos.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblImpuestos.ForeColor = Color.White;
            lblImpuestos.Location = new Point(219, 588);
            lblImpuestos.Name = "lblImpuestos";
            lblImpuestos.Size = new Size(2, 25);
            lblImpuestos.TabIndex = 11;
            // 
            // lblSubtotall
            // 
            lblSubtotall.AutoSize = true;
            lblSubtotall.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblSubtotall.ForeColor = Color.Cyan;
            lblSubtotall.Location = new Point(133, 483);
            lblSubtotall.Name = "lblSubtotall";
            lblSubtotall.Size = new Size(84, 22);
            lblSubtotall.TabIndex = 12;
            lblSubtotall.Text = "Subtotal:";
            // 
            // lblMdescuento
            // 
            lblMdescuento.AutoSize = true;
            lblMdescuento.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblMdescuento.ForeColor = Color.Cyan;
            lblMdescuento.Location = new Point(106, 539);
            lblMdescuento.Name = "lblMdescuento";
            lblMdescuento.Size = new Size(110, 22);
            lblMdescuento.TabIndex = 13;
            lblMdescuento.Text = "Descuento:";
            // 
            // lblMimpuestos
            // 
            lblMimpuestos.AutoSize = true;
            lblMimpuestos.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblMimpuestos.ForeColor = Color.Cyan;
            lblMimpuestos.Location = new Point(67, 588);
            lblMimpuestos.Name = "lblMimpuestos";
            lblMimpuestos.Size = new Size(149, 22);
            lblMimpuestos.TabIndex = 14;
            lblMimpuestos.Text = "Total impuestos:";
            // 
            // lblMTotal
            // 
            lblMTotal.AutoSize = true;
            lblMTotal.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblMTotal.ForeColor = Color.Cyan;
            lblMTotal.Location = new Point(161, 635);
            lblMTotal.Name = "lblMTotal";
            lblMTotal.Size = new Size(61, 22);
            lblMTotal.TabIndex = 15;
            lblMTotal.Text = "Total: ";
            // 
            // lBLcaRROO
            // 
            lBLcaRROO.AutoSize = true;
            lBLcaRROO.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBLcaRROO.ForeColor = Color.White;
            lBLcaRROO.ImageAlign = ContentAlignment.MiddleRight;
            lBLcaRROO.Location = new Point(487, 9);
            lBLcaRROO.Name = "lBLcaRROO";
            lBLcaRROO.Size = new Size(142, 37);
            lBLcaRROO.TabIndex = 16;
            lBLcaRROO.Text = "CARRITO";
            // 
            // CarritoDeCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 90, 150);
            ClientSize = new Size(1165, 728);
            Controls.Add(lBLcaRROO);
            Controls.Add(lblMTotal);
            Controls.Add(lblMimpuestos);
            Controls.Add(lblMdescuento);
            Controls.Add(lblSubtotall);
            Controls.Add(lblImpuestos);
            Controls.Add(lblDescuento);
            Controls.Add(lblMostrarTotal);
            Controls.Add(lblMostrarSubtotal);
            Controls.Add(lblTipoPago);
            Controls.Add(cmbTipoPago);
            Controls.Add(btnFinalizarCompra);
            Controls.Add(lblMetodoDePago);
            Controls.Add(btnEliminar);
            Controls.Add(dgvCarrito);
            Controls.Add(cmbMetodoPago);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarritoDeCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarritoDeCompras";
            Load += CarritoDeCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cmbMetodoPago;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCarrito;
        private Button btnEliminar;
        private Label lblMetodoDePago;
        private Button btnFinalizarCompra;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoPago;
        private Label lblTipoPago;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMostrarSubtotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMostrarTotal;
        private Label lblDescuento;
        private Label lblImpuestos;
        private Label lblSubtotall;
        private Label lblMdescuento;
        private Label lblMimpuestos;
        private Label lblMTotal;
        private Label lBLcaRROO;
    }
}