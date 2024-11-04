using PROYECTO_UNIDAD_4.Clases;
using PROYECTO_UNIDAD_4.Clases.Pago;
using PROYECTO_UNIDAD_4.Clases.Pedidos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PROYECTO_UNIDAD_4.Forms.Cliente
{
    public partial class CarritoDeCompras : Form
    {
        public CarritoDeCompras()
        {
            InitializeComponent();
            this.Load += CarritoDeCompras_Load;
            dgvCarrito.DataBindingComplete += dgvCarrito_DataBindingComplete;
        }

        private void CarritoDeCompras_Load(object sender, EventArgs e)
        {
            dgvCarrito.DataSource = UtilidadesPedido.productosComprados;
            ActualizarLabels();
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (UtilidadesPedido.productosComprados.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agrega productos antes de finalizar la compra.", "Carrito Vacío",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular subtotal, descuento, impuesto y total
            double subtotal = UtilidadesPedido.CalcularSubtotal(UtilidadesPedido.productosComprados);
            double impuestos = UtilidadesPedido.CalcularImpuestos(UtilidadesPedido.productosComprados);
            double descuento = UtilidadesPedido.CalcularDescuento(UtilidadesPedido.productosComprados);
            double total = UtilidadesPedido.CalcularTotal(UtilidadesPedido.productosComprados);

            // Selección de método de pago
            int metodoEscojido = cmbMetodoPago.SelectedIndex;
            if (metodoEscojido == -1)
            {
                MessageBox.Show("Por favor, selecciona un método de pago.", "Método de Pago No Seleccionado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Selección de tipo de compra
            int lugarCompra = cmbTipoPago.SelectedIndex;
            if (lugarCompra == -1)
            {
                MessageBox.Show("Por favor, selecciona el tipo de compra.", "Tipo de compra No Seleccionado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Polimorfismo en metodo de pago
            IMetodoPago pago;
            string metodoPagoSeleccionado = "";

            if (metodoEscojido == 0)
            {
                pago = new PagoTarjetaCredito();
                metodoPagoSeleccionado = "Tarjeta de Crédito";
            }
            else if (metodoEscojido == 1)
            {
                pago = new PagoPayPal();
                metodoPagoSeleccionado = "PayPal";
            }
            else
            {
                pago = new PagoEfectivo();
                metodoPagoSeleccionado = "Efectivo";
            }
            pago.ProcesarPago();
            //Polimorfismo con tipo de compra
            Pedido pedido;
            string tipoDeCompra = "";
            if (lugarCompra == 0)
            {
                pedido = new PedidoOnline();
                tipoDeCompra = "En linea";
            }
            else
            {
                pedido = new PedidoEnTienda();
                tipoDeCompra = "Tienda física";
            }
            pedido.MostrarMensaje();

            // Crear reporte para el admin
            ReporAdmin nuevoReporte = new ReporAdmin(DateTime.Now, subtotal, impuestos, descuento, total, metodoPagoSeleccionado, tipoDeCompra);
            UtilidadesPedido.reportesGenerados.Add(nuevoReporte);
            //Borrar la lista del carrito, actualizar el dgv y los labels
            UtilidadesPedido.productosComprados.Clear();
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = UtilidadesPedido.productosComprados;
            ActualizarLabels();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow == null || dgvCarrito.CurrentRow.Index == -1)
            {
                MessageBox.Show("Seleccione un producto en el carrito para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indiceFila = dgvCarrito.CurrentRow.Index;
            var productoCarrito = UtilidadesPedido.productosComprados[indiceFila];

            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto del carrito?",
                                                "Confirmar Eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                int cantidadADevolver = productoCarrito.Cantidad;
                string nombreProducto = productoCarrito.Nombre;

                var productoInventario = UtilidadesPedido.TodosLosProductosInventario
                    .FirstOrDefault(p => p.Nombre.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase));

                if (productoInventario != null)
                {
                    productoInventario.Cantidad += cantidadADevolver;
                }

                UtilidadesPedido.productosComprados.RemoveAt(indiceFila);
                dgvCarrito.DataSource = null;
                dgvCarrito.DataSource = UtilidadesPedido.productosComprados;

                MessageBox.Show("Producto eliminado del carrito y devuelto al inventario correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarLabels();
            }
        }

        private void ActualizarLabels()
        {
            lblMostrarSubtotal.Text = UtilidadesPedido.CalcularSubtotal(UtilidadesPedido.productosComprados).ToString("C2");
            lblImpuestos.Text = UtilidadesPedido.CalcularImpuestos(UtilidadesPedido.productosComprados).ToString("C2");
            lblDescuento.Text = UtilidadesPedido.CalcularDescuento(UtilidadesPedido.productosComprados).ToString("C2");
            lblMostrarTotal.Text = UtilidadesPedido.CalcularTotal(UtilidadesPedido.productosComprados).ToString("C2");
        }

        private void dgvCarrito_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvCarrito.Columns.Contains("Impuesto"))
            {
                dgvCarrito.Columns["Impuesto"].HeaderText = "Impuesto por pieza";
            }

            if (dgvCarrito.Columns.Contains("Descuento"))
            {
                dgvCarrito.Columns["Descuento"].HeaderText = "Descuento por pieza";
            }
        }

        private void dgvCarrito_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si la columna es de impuestos o descuentos
            if (dgvCarrito.Columns[e.ColumnIndex].Name == "Impuesto" || dgvCarrito.Columns[e.ColumnIndex].Name == "Descuento")
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
