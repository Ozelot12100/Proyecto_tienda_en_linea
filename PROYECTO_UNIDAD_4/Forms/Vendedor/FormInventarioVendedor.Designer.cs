namespace PROYECTO_UNIDAD_4.Forms.Admin
{
    partial class FormInventarioVendedor
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
            dgvInventario = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
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
            dgvInventario.Enabled = false;
            dgvInventario.GridColor = Color.Black;
            dgvInventario.Location = new Point(1, 0);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvInventario.Size = new Size(797, 453);
            dgvInventario.TabIndex = 1;
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
            dgvInventario.ThemeStyle.ReadOnly = true;
            dgvInventario.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInventario.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventario.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvInventario.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvInventario.ThemeStyle.RowsStyle.Height = 29;
            dgvInventario.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvInventario.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // FormInventarioVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(802, 450);
            Controls.Add(dgvInventario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInventarioVendedor";
            Text = "Inventario";
            Load += FormInventarioVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvInventario;
    }
}