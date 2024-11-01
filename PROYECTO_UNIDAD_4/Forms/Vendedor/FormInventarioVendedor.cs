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

        private void dgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si la columna es de impuestos o descuentos
            if (dgvInventario.Columns[e.ColumnIndex].Name == "Impuesto" || dgvInventario.Columns[e.ColumnIndex].Name == "Descuento")
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valor))
                {
                    // Multiplica por 100 y formatea como porcentaje
                    e.Value = (valor * 100).ToString("N2") + " %";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
