namespace PROYECTO_UNIDAD_4.Forms.Cliente
{
    partial class HistorialCliente
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
            pnlContenedor = new Panel();
            btnReembolso = new Guna.UI2.WinForms.Guna2Button();
            dgvHistorialCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCliente).BeginInit();
            SuspendLayout();
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(49, 66, 82);
            pnlContenedor.Controls.Add(btnReembolso);
            pnlContenedor.Controls.Add(dgvHistorialCliente);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(922, 450);
            pnlContenedor.TabIndex = 11;
            // 
            // btnReembolso
            // 
            btnReembolso.CustomizableEdges = customizableEdges1;
            btnReembolso.DisabledState.BorderColor = Color.DarkGray;
            btnReembolso.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReembolso.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReembolso.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReembolso.FillColor = Color.FromArgb(192, 0, 0);
            btnReembolso.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReembolso.ForeColor = Color.White;
            btnReembolso.Location = new Point(518, 325);
            btnReembolso.Name = "btnReembolso";
            btnReembolso.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnReembolso.Size = new Size(220, 57);
            btnReembolso.TabIndex = 5;
            btnReembolso.Text = "Pedir reembolso";
            btnReembolso.Click += btnReembolso_Click;
            // 
            // dgvHistorialCliente
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvHistorialCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorialCliente.BackgroundColor = Color.Teal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHistorialCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorialCliente.ColumnHeadersHeight = 22;
            dgvHistorialCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHistorialCliente.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorialCliente.GridColor = Color.FromArgb(231, 229, 255);
            dgvHistorialCliente.Location = new Point(21, 29);
            dgvHistorialCliente.Name = "dgvHistorialCliente";
            dgvHistorialCliente.RowHeadersVisible = false;
            dgvHistorialCliente.RowHeadersWidth = 51;
            dgvHistorialCliente.Size = new Size(880, 241);
            dgvHistorialCliente.TabIndex = 4;
            dgvHistorialCliente.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvHistorialCliente.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvHistorialCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvHistorialCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvHistorialCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvHistorialCliente.ThemeStyle.BackColor = Color.Teal;
            dgvHistorialCliente.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvHistorialCliente.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvHistorialCliente.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHistorialCliente.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvHistorialCliente.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvHistorialCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvHistorialCliente.ThemeStyle.HeaderStyle.Height = 22;
            dgvHistorialCliente.ThemeStyle.ReadOnly = false;
            dgvHistorialCliente.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvHistorialCliente.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistorialCliente.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvHistorialCliente.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvHistorialCliente.ThemeStyle.RowsStyle.Height = 29;
            dgvHistorialCliente.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvHistorialCliente.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvHistorialCliente.CellFormatting += dgvHistorialCliente_CellFormatting;
            dgvHistorialCliente.SelectionChanged += dgvHistorialCliente_SelectionChanged;
            // 
            // HistorialCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 450);
            Controls.Add(pnlContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HistorialCliente";
            Text = "Historial";
            Load += HistorialCliente_Load;
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContenedor;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHistorialCliente;
        private Guna.UI2.WinForms.Guna2Button btnReembolso;
    }
}