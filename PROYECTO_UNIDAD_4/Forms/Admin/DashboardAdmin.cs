using PROYECTO_UNIDAD_4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_UNIDAD_4.Forms.Admin
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login volver = new Login();
            volver.Show();
            this.Hide();
        }

        abrirForms mostrarForm = new abrirForms();

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormReporteDeVentas formHija = new FormReporteDeVentas();
            mostrarForm.AbrirFormEnPanel(this.pnlContenedor, formHija);
        }

        private void btnInventario_Click_1(object sender, EventArgs e)
        {
            FormInventarioAdmin formHija = new FormInventarioAdmin();
            mostrarForm.AbrirFormEnPanel(this.pnlContenedor, formHija);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            VentanaDeUsuarios formHija = new VentanaDeUsuarios();
            mostrarForm.AbrirFormEnPanel(this.pnlContenedor, formHija);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
