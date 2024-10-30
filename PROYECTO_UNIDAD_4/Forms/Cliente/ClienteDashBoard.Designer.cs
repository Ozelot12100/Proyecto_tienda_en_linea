using System.Windows.Forms;

namespace PROYECTO_UNIDAD_4.Forms
{
    partial class ClienteDashBoard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteDashBoard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            picLogo = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btnSalir = new Guna.UI2.WinForms.Guna2Button();
            btnElectrodomesticos = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btnAlimento = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btnRopa = new Guna.UI2.WinForms.Guna2GradientTileButton();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnCarrito = new Guna.UI2.WinForms.Guna2Button();
            btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            pnlContenedor = new Panel();
            guna2Panel1.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(26, 32, 40);
            guna2Panel1.Controls.Add(picLogo);
            guna2Panel1.Controls.Add(btnSalir);
            guna2Panel1.Controls.Add(btnElectrodomesticos);
            guna2Panel1.Controls.Add(btnAlimento);
            guna2Panel1.Controls.Add(btnRopa);
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.Dock = DockStyle.Left;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(189, 780);
            guna2Panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.CustomizableEdges = customizableEdges1;
            picLogo.DisabledState.BorderColor = Color.DarkGray;
            picLogo.DisabledState.CustomBorderColor = Color.DarkGray;
            picLogo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            picLogo.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            picLogo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            picLogo.FillColor = Color.FromArgb(190, 242, 255);
            picLogo.FillColor2 = Color.White;
            picLogo.FocusedColor = Color.FromArgb(255, 255, 128);
            picLogo.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            picLogo.ForeColor = Color.Black;
            picLogo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            picLogo.Image = Properties.Resources.logoBueno;
            picLogo.ImageSize = new Size(200, 150);
            picLogo.Location = new Point(0, 0);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picLogo.Size = new Size(183, 144);
            picLogo.TabIndex = 5;
            // 
            // btnSalir
            // 
            btnSalir.CustomizableEdges = customizableEdges3;
            btnSalir.DisabledState.BorderColor = Color.DarkGray;
            btnSalir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalir.FillColor = Color.FromArgb(192, 0, 0);
            btnSalir.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = Properties.Resources.salirrr2;
            btnSalir.Location = new Point(22, 702);
            btnSalir.Name = "btnSalir";
            btnSalir.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSalir.Size = new Size(134, 57);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // btnElectrodomesticos
            // 
            btnElectrodomesticos.CustomizableEdges = customizableEdges5;
            btnElectrodomesticos.DisabledState.BorderColor = Color.DarkGray;
            btnElectrodomesticos.DisabledState.CustomBorderColor = Color.DarkGray;
            btnElectrodomesticos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnElectrodomesticos.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnElectrodomesticos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnElectrodomesticos.FillColor = Color.FromArgb(0, 80, 200);
            btnElectrodomesticos.FillColor2 = Color.White;
            btnElectrodomesticos.FocusedColor = Color.FromArgb(255, 255, 128);
            btnElectrodomesticos.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnElectrodomesticos.ForeColor = Color.Black;
            btnElectrodomesticos.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnElectrodomesticos.Image = (Image)resources.GetObject("btnElectrodomesticos.Image");
            btnElectrodomesticos.ImageSize = new Size(60, 60);
            btnElectrodomesticos.Location = new Point(34, 503);
            btnElectrodomesticos.Margin = new Padding(3, 4, 3, 4);
            btnElectrodomesticos.Name = "btnElectrodomesticos";
            btnElectrodomesticos.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnElectrodomesticos.Size = new Size(122, 131);
            btnElectrodomesticos.TabIndex = 3;
            btnElectrodomesticos.Text = "Electrodomesticos";
            btnElectrodomesticos.Click += btnElectrodomesticos_Click;
            // 
            // btnAlimento
            // 
            btnAlimento.CustomizableEdges = customizableEdges7;
            btnAlimento.DisabledState.BorderColor = Color.DarkGray;
            btnAlimento.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAlimento.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAlimento.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAlimento.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAlimento.FillColor = Color.FromArgb(0, 80, 200);
            btnAlimento.FillColor2 = Color.White;
            btnAlimento.FocusedColor = Color.FromArgb(255, 255, 128);
            btnAlimento.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAlimento.ForeColor = Color.Black;
            btnAlimento.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnAlimento.Image = (Image)resources.GetObject("btnAlimento.Image");
            btnAlimento.ImageSize = new Size(60, 60);
            btnAlimento.Location = new Point(35, 336);
            btnAlimento.Margin = new Padding(3, 4, 3, 4);
            btnAlimento.Name = "btnAlimento";
            btnAlimento.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAlimento.Size = new Size(121, 123);
            btnAlimento.TabIndex = 2;
            btnAlimento.Text = "Alimento";
            btnAlimento.Click += btnAlimento_Click;
            // 
            // btnRopa
            // 
            btnRopa.CustomizableEdges = customizableEdges9;
            btnRopa.DisabledState.BorderColor = Color.DarkGray;
            btnRopa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRopa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRopa.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnRopa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRopa.FillColor = Color.FromArgb(0, 80, 200);
            btnRopa.FillColor2 = Color.White;
            btnRopa.FocusedColor = Color.FromArgb(255, 255, 128);
            btnRopa.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRopa.ForeColor = Color.Black;
            btnRopa.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnRopa.Image = (Image)resources.GetObject("btnRopa.Image");
            btnRopa.ImageSize = new Size(60, 60);
            btnRopa.Location = new Point(34, 165);
            btnRopa.Margin = new Padding(3, 4, 3, 4);
            btnRopa.Name = "btnRopa";
            btnRopa.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnRopa.Size = new Size(122, 133);
            btnRopa.TabIndex = 1;
            btnRopa.Text = "Ropa";
            btnRopa.Click += btnRopa_Click;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnCarrito);
            guna2ShadowPanel1.Controls.Add(btnCerrar);
            guna2ShadowPanel1.Dock = DockStyle.Top;
            guna2ShadowPanel1.FillColor = Color.FromArgb(0, 80, 200);
            guna2ShadowPanel1.Location = new Point(189, 0);
            guna2ShadowPanel1.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(1148, 127);
            guna2ShadowPanel1.TabIndex = 9;
            // 
            // btnCarrito
            // 
            btnCarrito.CustomizableEdges = customizableEdges13;
            btnCarrito.DisabledState.BorderColor = Color.DarkGray;
            btnCarrito.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCarrito.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCarrito.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCarrito.Font = new Font("Segoe UI", 9F);
            btnCarrito.ForeColor = Color.White;
            btnCarrito.Image = Properties.Resources.LogoCarrito;
            btnCarrito.ImageSize = new Size(90, 60);
            btnCarrito.Location = new Point(1040, 60);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnCarrito.Size = new Size(96, 49);
            btnCarrito.TabIndex = 1;
            btnCarrito.Click += btnCarrito_Click_1;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.CustomizableEdges = customizableEdges15;
            btnCerrar.DisabledState.BorderColor = Color.DarkGray;
            btnCerrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCerrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCerrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCerrar.FillColor = Color.Empty;
            btnCerrar.Font = new Font("Segoe UI", 9F);
            btnCerrar.ForeColor = Color.Transparent;
            btnCerrar.Image = Properties.Resources.logSalir;
            btnCerrar.Location = new Point(1111, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 0;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(49, 66, 82);
            pnlContenedor.Location = new Point(189, 115);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1148, 665);
            pnlContenedor.TabIndex = 10;
            pnlContenedor.Paint += pnlContenedor_Paint;
            // 
            // ClienteDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 242, 255);
            ClientSize = new Size(1337, 780);
            Controls.Add(pnlContenedor);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClienteDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += ClienteDashBoard_Load;
            guna2Panel1.ResumeLayout(false);
            guna2ShadowPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnRopa;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnElectrodomesticos;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAlimento;
        private Guna.UI2.WinForms.Guna2GradientTileButton picLogo;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Panel pnlContenedor;
        private Guna.UI2.WinForms.Guna2Button btnCarrito;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
    }
}