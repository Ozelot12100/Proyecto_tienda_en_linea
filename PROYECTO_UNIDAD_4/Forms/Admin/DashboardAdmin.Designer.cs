namespace PROYECTO_UNIDAD_4.Forms.Admin
{
    partial class DashboardAdmin
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
            BarraTiulo = new Panel();
            pictureBox2 = new PictureBox();
            btnCerrar = new PictureBox();
            panelVertical = new Panel();
            btnSalir = new Button();
            panel3 = new Panel();
            btnUsuario = new Button();
            panel2 = new Panel();
            btnInventario = new Button();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            btnReporteDeVenta = new Button();
            pnlContenedor = new Panel();
            BarraTiulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // BarraTiulo
            // 
            BarraTiulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTiulo.Controls.Add(pictureBox2);
            BarraTiulo.Controls.Add(btnCerrar);
            BarraTiulo.Dock = DockStyle.Top;
            BarraTiulo.Location = new Point(0, 0);
            BarraTiulo.Name = "BarraTiulo";
            BarraTiulo.Size = new Size(1301, 35);
            BarraTiulo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1094, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = Properties.Resources.logSalir1;
            btnCerrar.Location = new Point(1263, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelVertical
            // 
            panelVertical.BackColor = Color.FromArgb(26, 32, 40);
            panelVertical.Controls.Add(btnSalir);
            panelVertical.Controls.Add(panel3);
            panelVertical.Controls.Add(btnUsuario);
            panelVertical.Controls.Add(panel2);
            panelVertical.Controls.Add(btnInventario);
            panelVertical.Controls.Add(panel1);
            panelVertical.Controls.Add(pictureBox4);
            panelVertical.Controls.Add(btnReporteDeVenta);
            panelVertical.Dock = DockStyle.Left;
            panelVertical.Location = new Point(0, 35);
            panelVertical.Name = "panelVertical";
            panelVertical.Size = new Size(225, 719);
            panelVertical.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 10.8F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = Properties.Resources.salirrr1;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(6, 531);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(213, 29);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(4, 269);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 25);
            panel3.TabIndex = 9;
            // 
            // btnUsuario
            // 
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Century Gothic", 10.8F);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.Image = Properties.Resources.usuario;
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(12, 269);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(213, 29);
            btnUsuario.TabIndex = 8;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(3, 215);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 25);
            panel2.TabIndex = 7;
            // 
            // btnInventario
            // 
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 10.8F);
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = Properties.Resources.inventario1;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(12, 215);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(213, 29);
            btnInventario.TabIndex = 6;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click_1;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(3, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 25);
            panel1.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logoBueno1;
            pictureBox4.Location = new Point(0, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(225, 136);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // btnReporteDeVenta
            // 
            btnReporteDeVenta.FlatAppearance.BorderSize = 0;
            btnReporteDeVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnReporteDeVenta.FlatStyle = FlatStyle.Flat;
            btnReporteDeVenta.Font = new Font("Century Gothic", 10.8F);
            btnReporteDeVenta.ForeColor = Color.White;
            btnReporteDeVenta.Image = Properties.Resources.reportes;
            btnReporteDeVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteDeVenta.Location = new Point(6, 163);
            btnReporteDeVenta.Name = "btnReporteDeVenta";
            btnReporteDeVenta.Size = new Size(272, 29);
            btnReporteDeVenta.TabIndex = 0;
            btnReporteDeVenta.Text = "Reporte de ventas";
            btnReporteDeVenta.UseVisualStyleBackColor = true;
            btnReporteDeVenta.Click += btnInventario_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(49, 66, 82);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(225, 35);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1076, 719);
            pnlContenedor.TabIndex = 2;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 754);
            Controls.Add(pnlContenedor);
            Controls.Add(panelVertical);
            Controls.Add(BarraTiulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardAdmin";
            Text = "Form1";
            BarraTiulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTiulo;
        private Panel panelVertical;
        private Panel pnlContenedor;
        private PictureBox btnCerrar;
        private PictureBox pictureBox2;
        private Button btnReporteDeVenta;
        private PictureBox pictureBox4;
        private Button btnSalir;
        private Panel panel3;
        private Button btnUsuario;
        private Panel panel2;
        private Button btnInventario;
        private Panel panel1;
    }

        
    
}