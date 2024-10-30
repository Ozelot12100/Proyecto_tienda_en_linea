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

            // Calcular los totales de la compra
            double subtotal = UtilidadesPedido.CalcularSubtotal(UtilidadesPedido.productosComprados);
            double impuestos = UtilidadesPedido.CalcularImpuestos(UtilidadesPedido.productosComprados);
            double descuento = UtilidadesPedido.CalcularDescuento(UtilidadesPedido.productosComprados);
            double total = UtilidadesPedido.CalcularTotal(UtilidadesPedido.productosComprados);

            int metodoEscojido = cmbMetodoPago.SelectedIndex;
            if (metodoEscojido == -1)
            {
                MessageBox.Show("Por favor, selecciona un método de pago.", "Método de Pago No Seleccionado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string metodoPagoSeleccionado = metodoEscojido switch
            {
                0 => "Tarjeta de Crédito",
                1 => "PayPal",
                2 => "Efectivo",
                _ => ""
            };

            // Seleccionar tipo de compra
            int lugarCompra = cmbTipoPago.SelectedIndex;
            if (lugarCompra == -1)
            {
                MessageBox.Show("Por favor, selecciona el tipo de compra.", "Tipo de compra No Seleccionado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pedido pedido = lugarCompra == 0 ? new PedidoOnline() : new PedidoEnTienda();
            pedido.MostrarMensaje();

            // Crear un reporte de la compra
            ReporAdmin nuevoReporte = new ReporAdmin(DateTime.Now, subtotal, impuestos, descuento, total, metodoPagoSeleccionado);
            nuevoReporte.Generar();
            UtilidadesPedido.reportesGenerados.Add(nuevoReporte);

            // Limpiar el carrito y actualizar el DataGridView
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
    }
}
