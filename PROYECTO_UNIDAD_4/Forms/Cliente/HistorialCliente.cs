using PROYECTO_UNIDAD_4.Clases;
using PROYECTO_UNIDAD_4.Clases.Pago;
using PROYECTO_UNIDAD_4.Clases.Productos;
using PROYECTO_UNIDAD_4.Clases.Reportes;
using PROYECTO_UNIDAD_4.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_UNIDAD_4.Forms.Cliente
{
    public partial class HistorialCliente : Form
    {
        ReporAdmin compraSelecionada;
        public HistorialCliente()
        {
            InitializeComponent();
        }

        private void btnReembolso_Click(object sender, EventArgs e)
        {
            if(compraSelecionada == null)
            {
                MessageBox.Show("Selecione una compra");
            }

            string metodoDepago = compraSelecionada.MetodoDePago;
            IReembolso mensaje;
            if(metodoDepago == "Tarjeta de Crédito")
            {
                mensaje = new PagoTarjetaCredito();
                mensaje.ProcesarReembolso();
            }
            else if (metodoDepago == "PayPal")
            {
                mensaje = new PagoPayPal();
                mensaje.ProcesarReembolso();
            }
            else
            {
                mensaje = new PagoEfectivo();
                mensaje.ProcesarReembolso();
            }
        }

        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            dgvHistorialCliente.DataSource = UtilidadesPedido.reportesGenerados;
        }

        private void dgvHistorialCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si la columna es de tipo monetario
            if (dgvHistorialCliente.Columns[e.ColumnIndex].Name == "Subtotal" ||
                dgvHistorialCliente.Columns[e.ColumnIndex].Name == "Impuestos" ||
                dgvHistorialCliente.Columns[e.ColumnIndex].Name == "Descuento" ||
                dgvHistorialCliente.Columns[e.ColumnIndex].Name == "Total")
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valor))
                {
                    // Formatea como moneda
                    e.Value = valor.ToString("C2");
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvHistorialCliente_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado una fila
            if (dgvHistorialCliente.CurrentRow != null && dgvHistorialCliente.CurrentRow.Index > -1)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFila = dgvHistorialCliente.CurrentRow.Index;

                // Verificar si el índice está dentro del rango de la lista
                if (indiceFila < UtilidadesPedido.reportesGenerados.Count)
                {
                    // Obtener el producto de la lista con base en el índice
                    compraSelecionada = UtilidadesPedido.reportesGenerados[indiceFila];
                }
            }
        }
    }
}
