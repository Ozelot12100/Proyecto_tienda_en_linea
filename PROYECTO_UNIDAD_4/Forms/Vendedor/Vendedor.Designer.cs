namespace PROYECTO_UNIDAD_4.Forms.Vendedor
{
    partial class Vendedor
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            btnSalir = new Button();
            panel3 = new Panel();
            btnInventario = new Button();
            btnReporteDeVentas = new Button();
            pnlContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 90, 150);
            panel1.Controls.Add(picLogo);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnReporteDeVentas);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 663);
            panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.CustomizableEdges = customizableEdges3;
            picLogo.Image = Properties.Resources.logoBueno;
            picLogo.ImageRotate = 0F;
            picLogo.Location = new Point(0, 3);
            picLogo.Name = "picLogo";
            picLogo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            picLogo.Size = new Size(171, 112);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Location = new Point(8, 548);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 43);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Blue;
            panel4.Location = new Point(3, 241);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(6, 43);
            panel4.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = Properties.Resources.salirrr1;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(11, 548);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(154, 43);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Blue;
            panel3.Location = new Point(3, 131);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 71);
            panel3.TabIndex = 0;
            // 
            // btnInventario
            // 
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = Properties.Resources.inventario1;
            btnInventario.ImageAlign = ContentAlignment.MiddleRight;
            btnInventario.Location = new Point(14, 241);
            btnInventario.Margin = new Padding(3, 4, 3, 4);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(154, 43);
            btnInventario.TabIndex = 2;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnReporteDeVentas
            // 
            btnReporteDeVentas.FlatAppearance.BorderSize = 0;
            btnReporteDeVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnReporteDeVentas.FlatStyle = FlatStyle.Flat;
            btnReporteDeVentas.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnReporteDeVentas.ForeColor = Color.White;
            btnReporteDeVentas.Image = Properties.Resources.reportes1;
            btnReporteDeVentas.ImageAlign = ContentAlignment.MiddleRight;
            btnReporteDeVentas.Location = new Point(7, 131);
            btnReporteDeVentas.Margin = new Padding(3, 4, 3, 4);
            btnReporteDeVentas.Name = "btnReporteDeVentas";
            btnReporteDeVentas.Size = new Size(158, 72);
            btnReporteDeVentas.TabIndex = 1;
            btnReporteDeVentas.Text = "Reporte de ventas";
            btnReporteDeVentas.UseVisualStyleBackColor = true;
            btnReporteDeVentas.Click += btnReporteDeVentas_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(26, 32, 40);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(171, 0);
            pnlContenedor.Margin = new Padding(3, 4, 3, 4);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1204, 663);
            pnlContenedor.TabIndex = 1;
            // 
            // Vendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1375, 663);
            Controls.Add(pnlContenedor);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Vendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendedor";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlContenedor;
        private Button btnReporteDeVentas;
        private Button btnInventario;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Button btnSalir;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
    }
}