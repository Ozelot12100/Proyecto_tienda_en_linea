using PROYECTO_UNIDAD_4.Clases.Productos;
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
    public partial class FormReporteDeVentas : Form
    {
        public FormReporteDeVentas()
        {
            InitializeComponent();
            this.Load += FormReporteDeVentas_Load; // Vincular el evento Load al método
        }


        private void btnRefrescar_Click(object sender, EventArgs e)
        {

        }



        private void FormReporteDeVentas_Load(object sender, EventArgs e)
        {
            dgvReporteAdmin.DataSource = UtilidadesPedido.reportesGenerados;

        }

        private void dgvReporteAdmin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si la columna es de tipo monetario
            if (dgvReporteAdmin.Columns[e.ColumnIndex].Name == "Subtotal" ||
                dgvReporteAdmin.Columns[e.ColumnIndex].Name == "Impuestos" ||
                dgvReporteAdmin.Columns[e.ColumnIndex].Name == "Descuento" ||
                dgvReporteAdmin.Columns[e.ColumnIndex].Name == "Total")
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valor))
                {
                    // Formatea como moneda
                    e.Value = valor.ToString("C2");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
