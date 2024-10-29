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
    public partial class FormInventarioVendedor : Form
    {
        public FormInventarioVendedor()
        {
            InitializeComponent();
            this.Load += FormInventarioVendedor_Load; // Vincular el evento Load al método

        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormInventarioVendedor_Load(object sender, EventArgs e)
        {
            // Asignar la lista de productos como fuente de datos del DataGridView
            dgvInventario.DataSource = UtilidadesPedido.TodosLosProductosInventario;
        }
    }
}
