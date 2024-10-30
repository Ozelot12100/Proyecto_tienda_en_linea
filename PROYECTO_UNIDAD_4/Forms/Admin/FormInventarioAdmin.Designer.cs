namespace PROYECTO_UNIDAD_4.Forms.Admin
{
    partial class FormInventarioAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvInventario = new Guna.UI2.WinForms.Guna2DataGridView();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAñadir = new Button();
            txtProducto = new Guna.UI2.WinForms.Guna2TextBox();
            txtPiezas = new Guna.UI2.WinForms.Guna2TextBox();
            txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblImpuesto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtImpuesto = new Guna.UI2.WinForms.Guna2TextBox();
            txtDescuento = new Guna.UI2.WinForms.Guna2TextBox();
            lblDescuento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            picLogon = new PictureBox();
            lblInven = new Label();
            cmbElegirCategoría = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogon).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventario.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInventario.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInventario.GridColor = Color.Black;
            dgvInventario.Location = new Point(196, 357);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvInventario.Size = new Size(742, 299);
            dgvInventario.TabIndex = 0;
            dgvInventario.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvInventario.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvInventario.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvInventario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvInventario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvInventario.ThemeStyle.BackColor = SystemColors.ActiveCaption;
            dgvInventario.ThemeStyle.GridColor = Color.Black;
            dgvInventario.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvInventario.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInventario.ThemeStyle.HeaderStyle.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvInventario.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            dgvInventario.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvInventario.ThemeStyle.HeaderStyle.Height = 23;
            dgvInventario.ThemeStyle.ReadOnly = false;
            dgvInventario.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInventario.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventario.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvInventario.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvInventario.ThemeStyle.RowsStyle.Height = 29;
            dgvInventario.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvInventario.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvInventario.SelectionChanged += dgvInventario_SelectionChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Properties.Resources.eliminar;
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.Location = new Point(679, 262);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(159, 48);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(128, 255, 255);
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(0, 80, 200);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 200);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnEditar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.ImageAlign = ContentAlignment.MiddleRight;
            btnEditar.Location = new Point(679, 201);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(159, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.LawnGreen;
            btnAñadir.FlatAppearance.BorderColor = Color.FromArgb(0, 80, 200);
            btnAñadir.FlatAppearance.BorderSize = 0;
            btnAñadir.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 200);
            btnAñadir.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAñadir.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.Image = Properties.Resources.añadirLogo;
            btnAñadir.ImageAlign = ContentAlignment.MiddleRight;
            btnAñadir.Location = new Point(679, 137);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(159, 45);
            btnAñadir.TabIndex = 3;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // txtProducto
            // 
            txtProducto.CustomizableEdges = customizableEdges1;
            txtProducto.DefaultText = "";
            txtProducto.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProducto.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProducto.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProducto.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProducto.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProducto.Font = new Font("Segoe UI", 9F);
            txtProducto.ForeColor = Color.Black;
            txtProducto.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProducto.Location = new Point(427, 83);
            txtProducto.Margin = new Padding(3, 5, 3, 5);
            txtProducto.Name = "txtProducto";
            txtProducto.PasswordChar = '\0';
            txtProducto.PlaceholderText = "";
            txtProducto.SelectedText = "";
            txtProducto.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtProducto.Size = new Size(225, 34);
            txtProducto.TabIndex = 4;
            // 
            // txtPiezas
            // 
            txtPiezas.CustomizableEdges = customizableEdges3;
            txtPiezas.DefaultText = "";
            txtPiezas.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPiezas.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPiezas.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPiezas.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPiezas.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPiezas.Font = new Font("Segoe UI", 9F);
            txtPiezas.ForeColor = Color.Black;
            txtPiezas.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPiezas.Location = new Point(427, 138);
            txtPiezas.Margin = new Padding(3, 5, 3, 5);
            txtPiezas.Name = "txtPiezas";
            txtPiezas.PasswordChar = '\0';
            txtPiezas.PlaceholderText = "";
            txtPiezas.SelectedText = "";
            txtPiezas.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPiezas.Size = new Size(225, 34);
            txtPiezas.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.CustomizableEdges = customizableEdges5;
            txtPrecio.DefaultText = "";
            txtPrecio.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrecio.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrecio.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrecio.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrecio.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrecio.Font = new Font("Segoe UI", 9F);
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrecio.Location = new Point(427, 190);
            txtPrecio.Margin = new Padding(3, 5, 3, 5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PasswordChar = '\0';
            txtPrecio.PlaceholderText = "";
            txtPrecio.SelectedText = "";
            txtPrecio.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPrecio.Size = new Size(225, 34);
            txtPrecio.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(296, 94);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 9;
            label1.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(332, 149);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 11;
            label3.Text = "Pieza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(322, 201);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 12;
            label4.Text = "Precio";
            // 
            // lblImpuesto
            // 
            lblImpuesto.BackColor = Color.Transparent;
            lblImpuesto.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblImpuesto.ForeColor = Color.White;
            lblImpuesto.Location = new Point(299, 252);
            lblImpuesto.Margin = new Padding(3, 4, 3, 4);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(94, 25);
            lblImpuesto.TabIndex = 13;
            lblImpuesto.Text = "Impuesto";
            // 
            // txtImpuesto
            // 
            txtImpuesto.CustomizableEdges = customizableEdges7;
            txtImpuesto.DefaultText = "";
            txtImpuesto.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtImpuesto.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtImpuesto.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtImpuesto.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtImpuesto.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtImpuesto.Font = new Font("Segoe UI", 9F);
            txtImpuesto.ForeColor = Color.Black;
            txtImpuesto.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtImpuesto.Location = new Point(427, 243);
            txtImpuesto.Margin = new Padding(3, 5, 3, 5);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.PasswordChar = '\0';
            txtImpuesto.PlaceholderText = "";
            txtImpuesto.SelectedText = "";
            txtImpuesto.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtImpuesto.Size = new Size(225, 34);
            txtImpuesto.TabIndex = 14;
            // 
            // txtDescuento
            // 
            txtDescuento.CustomizableEdges = customizableEdges9;
            txtDescuento.DefaultText = "";
            txtDescuento.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescuento.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescuento.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescuento.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescuento.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescuento.Font = new Font("Segoe UI", 9F);
            txtDescuento.ForeColor = Color.Black;
            txtDescuento.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescuento.Location = new Point(427, 294);
            txtDescuento.Margin = new Padding(3, 5, 3, 5);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.PasswordChar = '\0';
            txtDescuento.PlaceholderText = "";
            txtDescuento.SelectedText = "";
            txtDescuento.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtDescuento.Size = new Size(225, 34);
            txtDescuento.TabIndex = 15;
            // 
            // lblDescuento
            // 
            lblDescuento.BackColor = Color.Transparent;
            lblDescuento.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblDescuento.ForeColor = Color.White;
            lblDescuento.Location = new Point(285, 303);
            lblDescuento.Margin = new Padding(3, 4, 3, 4);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(108, 25);
            lblDescuento.TabIndex = 16;
            lblDescuento.Text = "Descuento";
            // 
            // picLogon
            // 
            picLogon.Image = Properties.Resources.logoBueno;
            picLogon.Location = new Point(-2, 1);
            picLogon.Name = "picLogon";
            picLogon.Size = new Size(178, 116);
            picLogon.SizeMode = PictureBoxSizeMode.Zoom;
            picLogon.TabIndex = 17;
            picLogon.TabStop = false;
            // 
            // lblInven
            // 
            lblInven.AutoSize = true;
            lblInven.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInven.ForeColor = Color.White;
            lblInven.Location = new Point(447, 9);
            lblInven.Name = "lblInven";
            lblInven.Size = new Size(217, 40);
            lblInven.TabIndex = 18;
            lblInven.Text = "INVENTARIO";
            // 
            // cmbElegirCategoría
            // 
            cmbElegirCategoría.BackColor = Color.Transparent;
            cmbElegirCategoría.CustomizableEdges = customizableEdges11;
            cmbElegirCategoría.DrawMode = DrawMode.OwnerDrawFixed;
            cmbElegirCategoría.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbElegirCategoría.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbElegirCategoría.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbElegirCategoría.Font = new Font("Segoe UI", 10F);
            cmbElegirCategoría.ForeColor = Color.FromArgb(68, 88, 112);
            cmbElegirCategoría.ItemHeight = 30;
            cmbElegirCategoría.Items.AddRange(new object[] { "Ropa", "Alimento", "Electrónica" });
            cmbElegirCategoría.Location = new Point(679, 83);
            cmbElegirCategoría.Name = "cmbElegirCategoría";
            cmbElegirCategoría.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cmbElegirCategoría.Size = new Size(175, 36);
            cmbElegirCategoría.TabIndex = 19;
            // 
            // FormInventarioAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1162, 790);
            Controls.Add(cmbElegirCategoría);
            Controls.Add(lblInven);
            Controls.Add(picLogon);
            Controls.Add(lblDescuento);
            Controls.Add(txtDescuento);
            Controls.Add(txtImpuesto);
            Controls.Add(lblImpuesto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(txtPiezas);
            Controls.Add(txtProducto);
            Controls.Add(btnAñadir);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvInventario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInventarioAdmin";
            Text = "Form1";
            Load += FormInventarioAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvInventario;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAñadir;
        private Guna.UI2.WinForms.Guna2TextBox txtProducto;
        private Guna.UI2.WinForms.Guna2TextBox txtPiezas;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private Label label1;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblImpuesto;
        private Guna.UI2.WinForms.Guna2TextBox txtImpuesto;
        private Guna.UI2.WinForms.Guna2TextBox txtDescuento;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescuento;
        private PictureBox picLogon;
        private Label lblInven;
        private Guna.UI2.WinForms.Guna2ComboBox cmbElegirCategoría;
    }
}