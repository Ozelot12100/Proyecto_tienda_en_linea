using PROYECTO_UNIDAD_4.Clases;
using PROYECTO_UNIDAD_4.Clases.Reportes;
using PROYECTO_UNIDAD_4.Forms.Admin;
using PROYECTO_UNIDAD_4.Forms.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_UNIDAD_4.Forms.Vendedor
{
    public partial class Vendedor : Form
    {
        public Vendedor()
        {
            InitializeComponent();
        }

        abrirForms mostrarForm = new abrirForms();

        private void btnReporteDeVentas_Click(object sender, EventArgs e)
        {
            FormReporteDeVentas formHija = new FormReporteDeVentas();
            mostrarForm.AbrirFormEnPanel(this.pnlContenedor, formHija);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormInventarioVendedor formHija = new FormInventarioVendedor();
            mostrarForm.AbrirFormEnPanel(this.pnlContenedor, formHija);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login volver = new Login();
            volver.Show();
            this.Hide();
        }
    }
}
