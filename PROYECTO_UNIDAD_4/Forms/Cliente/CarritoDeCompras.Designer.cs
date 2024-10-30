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
            cmbMetodoPago.Location = new Point(180, 265);
            cmbMetodoPago.Margin = new Padding(3, 2, 3, 2);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbMetodoPago.Size = new Size(224, 36);
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
            dgvCarrito.Location = new Point(10, 44);
            dgvCarrito.Margin = new Padding(3, 2, 3, 2);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.RowTemplate.Height = 29;
            dgvCarrito.Size = new Size(898, 202);
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
            dgvCarrito.DataBindingComplete += dgvCarrito_DataBindingComplete;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Properties.Resources.eliminar;
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.Location = new Point(774, 252);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 49);
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
            lblMetodoDePago.Location = new Point(27, 265);
            lblMetodoDePago.Name = "lblMetodoDePago";
            lblMetodoDePago.Size = new Size(134, 18);
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
            btnFinalizarCompra.Location = new Point(493, 265);
            btnFinalizarCompra.Margin = new Padding(3, 2, 3, 2);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(191, 49);
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
            cmbTipoPago.Location = new Point(180, 305);
            cmbTipoPago.Margin = new Padding(3, 2, 3, 2);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbTipoPago.Size = new Size(154, 36);
            cmbTipoPago.TabIndex = 6;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            lblTipoPago.ForeColor = Color.White;
            lblTipoPago.Location = new Point(34, 307);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(125, 18);
            lblTipoPago.TabIndex = 7;
            lblTipoPago.Text = "Tipo de compra";
            // 
            // lblMostrarSubtotal
            // 
            lblMostrarSubtotal.BackColor = Color.Transparent;
            lblMostrarSubtotal.BorderStyle = BorderStyle.FixedSingle;
            lblMostrarSubtotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblMostrarSubtotal.ForeColor = Color.White;
            lblMostrarSubtotal.Location = new Point(195, 362);
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
            lblMostrarTotal.Location = new Point(193, 476);
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
            lblDescuento.Location = new Point(192, 404);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(2, 21);
            lblDescuento.TabIndex = 10;
            // 
            // lblImpuestos
            // 
            lblImpuestos.AutoSize = true;
            lblImpuestos.BorderStyle = BorderStyle.FixedSingle;
            lblImpuestos.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblImpuestos.ForeColor = Color.White;
            lblImpuestos.Location = new Point(192, 441);
            lblImpuestos.Name = "lblImpuestos";
            lblImpuestos.Size = new Size(2, 21);
            lblImpuestos.TabIndex = 11;
            // 
            // lblSubtotall
            // 
            lblSubtotall.AutoSize = true;
            lblSubtotall.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblSubtotall.ForeColor = Color.Cyan;
            lblSubtotall.Location = new Point(116, 362);
            lblSubtotall.Name = "lblSubtotall";
            lblSubtotall.Size = new Size(73, 18);
            lblSubtotall.TabIndex = 12;
            lblSubtotall.Text = "Subtotal:";
            // 
            // lblMdescuento
            // 
            lblMdescuento.AutoSize = true;
            lblMdescuento.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblMdescuento.ForeColor = Color.Cyan;
            lblMdescuento.Location = new Point(93, 404);
            lblMdescuento.Name = "lblMdescuento";
            lblMdescuento.Size = new Size(93, 18);
            lblMdescuento.TabIndex = 13;
            lblMdescuento.Text = "Descuento:";
            // 
            // lblMimpuestos
            // 
            lblMimpuestos.AutoSize = true;
            lblMimpuestos.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblMimpuestos.ForeColor = Color.Cyan;
            lblMimpuestos.Location = new Point(59, 441);
            lblMimpuestos.Name = "lblMimpuestos";
            lblMimpuestos.Size = new Size(127, 18);
            lblMimpuestos.TabIndex = 14;
            lblMimpuestos.Text = "Total impuestos:";
            // 
            // lblMTotal
            // 
            lblMTotal.AutoSize = true;
            lblMTotal.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblMTotal.ForeColor = Color.Cyan;
            lblMTotal.Location = new Point(141, 476);
            lblMTotal.Name = "lblMTotal";
            lblMTotal.Size = new Size(51, 18);
            lblMTotal.TabIndex = 15;
            lblMTotal.Text = "Total: ";
            // 
            // lBLcaRROO
            // 
            lBLcaRROO.AutoSize = true;
            lBLcaRROO.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBLcaRROO.ForeColor = Color.White;
            lBLcaRROO.ImageAlign = ContentAlignment.MiddleRight;
            lBLcaRROO.Location = new Point(426, 7);
            lBLcaRROO.Name = "lBLcaRROO";
            lBLcaRROO.Size = new Size(114, 28);
            lBLcaRROO.TabIndex = 16;
            lBLcaRROO.Text = "CARRITO";
            // 
            // CarritoDeCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 90, 150);
            ClientSize = new Size(1019, 546);
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
            Margin = new Padding(3, 2, 3, 2);
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