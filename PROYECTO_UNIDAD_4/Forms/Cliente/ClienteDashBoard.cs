using PROYECTO_UNIDAD_4.Clases;
using PROYECTO_UNIDAD_4.Forms.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_UNIDAD_4.Forms
{

    public partial class ClienteDashBoard : Form
    {
        public ClienteDashBoard()
        {
            InitializeComponent();
        }

        abrirForms mostrarForm = new abrirForms();

        private void ClienteDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnRopa_Click(object sender, EventArgs e)
        {
            formRopa formHija = new formRopa();
            mostrarForm.AbrirFormEnPanel(this.pnlContenedor, formHija);
        }

        private void btnAlimento_Click(object sender, EventArgs e)
        {
            formAlimentos formHija = new formAlimentos();
            mostrarForm.AbrirFormEnPanel(this.pnlContenedor, formHija);
        }

        private void btnElectrodomesticos_Click(object sender, EventArgs e)
        {
            formElectrodomesticos formHija = new formElectrodomesticos();
            mostrarForm.AbrirFormEnPanel(this.pnlContenedor, formHija);
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login volver = new Login();
            volver.Show();
            this.Hide();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {

        }

        private void btnCarrito_Click_1(object sender, EventArgs e)
        {
            CarritoDeCompras formHija = new CarritoDeCompras();
            mostrarForm.AbrirFormEnPanel(this.pnlContenedor, formHija);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnReembolso_Click(object sender, EventArgs e)
        {
            
        }
    }
}
