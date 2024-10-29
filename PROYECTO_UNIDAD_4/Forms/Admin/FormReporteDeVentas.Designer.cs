namespace PROYECTO_UNIDAD_4.Forms.Admin
{
    partial class FormReporteDeVentas
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            dgvReporteAdmin = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteAdmin).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(49, 66, 82);
            guna2Panel1.Controls.Add(dgvReporteAdmin);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(-1, 0);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1262, 729);
            guna2Panel1.TabIndex = 0;
            // 
            // dgvReporteAdmin
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvReporteAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReporteAdmin.BackgroundColor = Color.Teal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReporteAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReporteAdmin.ColumnHeadersHeight = 22;
            dgvReporteAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReporteAdmin.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReporteAdmin.GridColor = Color.FromArgb(231, 229, 255);
            dgvReporteAdmin.Location = new Point(3, 52);
            dgvReporteAdmin.Name = "dgvReporteAdmin";
            dgvReporteAdmin.RowHeadersVisible = false;
            dgvReporteAdmin.RowHeadersWidth = 51;
            dgvReporteAdmin.Size = new Size(937, 524);
            dgvReporteAdmin.TabIndex = 3;
            dgvReporteAdmin.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvReporteAdmin.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvReporteAdmin.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvReporteAdmin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvReporteAdmin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvReporteAdmin.ThemeStyle.BackColor = Color.Teal;
            dgvReporteAdmin.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvReporteAdmin.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvReporteAdmin.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReporteAdmin.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvReporteAdmin.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvReporteAdmin.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvReporteAdmin.ThemeStyle.HeaderStyle.Height = 22;
            dgvReporteAdmin.ThemeStyle.ReadOnly = false;
            dgvReporteAdmin.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvReporteAdmin.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporteAdmin.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvReporteAdmin.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvReporteAdmin.ThemeStyle.RowsStyle.Height = 29;
            dgvReporteAdmin.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvReporteAdmin.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // FormReporteDeVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 728);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormReporteDeVentas";
            Text = "ReporteDeVentas";
            Load += FormReporteDeVentas_Load;
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReporteAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReporteAdmin;
    }
}