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

            this.Load += CarritoDeCompras_Load; // Vincular el evento Load al método
            dgvCarrito.DataBindingComplete += dgvCarrito_DataBindingComplete;
        }



        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            // Verificar si el carrito está vacío
            if (UtilidadesPedido.productosComprados.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agrega productos antes de finalizar la compra.", "Carrito Vacío",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular el subtotal, impuestos, descuento y total de la compra
            double subtotal = UtilidadesPedido.CalcularSubtotal(UtilidadesPedido.productosComprados);
            double impuestos = UtilidadesPedido.CalcularImpuestos(UtilidadesPedido.productosComprados);
            double descuento = UtilidadesPedido.CalcularDescuento(UtilidadesPedido.productosComprados);
            double total = UtilidadesPedido.CalcularTotal(UtilidadesPedido.productosComprados);

            // Verificar que el método de pago esté seleccionado
            int metodoEscojido = cmbMetodoPago.SelectedIndex;
            if (metodoEscojido == -1)
            {
                MessageBox.Show("Por favor, selecciona un método de pago.", "Método de Pago No Seleccionado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string metodoPagoSeleccionado = "";
            if (metodoEscojido == 0)
            {
                PagoTarjetaCredito metodo = new PagoTarjetaCredito();
                metodo.ProcesarPago();
                metodoPagoSeleccionado = "Tarjeta de Crédito";
            }
            else if (metodoEscojido == 1)
            {
                PagoPayPal metodo = new PagoPayPal();
                metodo.ProcesarPago();
                metodoPagoSeleccionado = "PayPal";
            }
            else if (metodoEscojido == 2)
            {
                PagoEfectivo metodo = new PagoEfectivo();
                metodo.ProcesarPago();
                metodoPagoSeleccionado = "Efectivo";
            }

            // Verificar que el tipo de compra esté seleccionado
            int lugarCompra = cmbTipoPago.SelectedIndex;
            if (lugarCompra == -1)
            {
                MessageBox.Show("Por favor, selecciona el tipo de compra.", "Tipo de compra No Seleccionado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear el tipo de pedido según la selección
            Pedido pedido;
            if (lugarCompra == 0)
            {
                pedido = new PedidoOnline();
            }
            else
            {
                pedido = new PedidoEnTienda();
            }
            pedido.MostrarMensaje();

            // Actualizar el inventario: descontar la cantidad de productos comprados
            foreach (var productoComprado in UtilidadesPedido.productosComprados)
            {
                // Buscar el producto en el inventario
                var productoInventario = UtilidadesPedido.TodosLosProductosInventario
                                          .FirstOrDefault(p => p.Nombre.Equals(productoComprado.Nombre, StringComparison.OrdinalIgnoreCase));

                if (productoInventario != null)
                {
                    // Descontar la cantidad comprada del inventario
                    productoInventario.Cantidad -= productoComprado.Cantidad;
                }
            }

            // Crear un reporte de la compra
            ReporAdmin nuevoReporte = new ReporAdmin(DateTime.Now, subtotal, impuestos, descuento, total, metodoPagoSeleccionado);
            nuevoReporte.Generar();
            UtilidadesPedido.reportesGenerados.Add(nuevoReporte);

            

            // Limpiar el carrito y actualizar el DataGridView
            UtilidadesPedido.productosComprados.Clear();
            dgvCarrito.DataSource = null; // Limpiar la fuente de datos
            dgvCarrito.DataSource = UtilidadesPedido.productosComprados; // Reasignar la lista vacía
            ActualizarLabels();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvCarrito.CurrentRow == null || dgvCarrito.CurrentRow.Index == -1)
            {
                MessageBox.Show("Seleccione un producto en el carrito para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el índice de la fila seleccionada
            int indiceFila = dgvCarrito.CurrentRow.Index;

            // Confirmar la eliminación
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto del carrito?",
                                                 "Confirmar Eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                var producto = UtilidadesPedido.productosComprados[indiceFila];
                int numPiezas = producto.Cantidad; // Cantidad en el carrito
                string nombre = producto.Nombre;

                // Buscar el producto en el inventario por nombre
                var productoBase = UtilidadesPedido.TodosLosProductosInventario
                                    .FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

                if (productoBase != null)
                {
                    // Devolver la cantidad al inventario
                    productoBase.Cantidad += numPiezas;
                }
                else
                {
                    MessageBox.Show("El producto no se encontró en el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Eliminar el producto de la lista del carrito
                UtilidadesPedido.productosComprados.RemoveAt(indiceFila);

                // Actualizar el DataGridView
                dgvCarrito.DataSource = null; // Limpiar la fuente de datos
                dgvCarrito.DataSource = UtilidadesPedido.productosComprados; // Reasignar la lista actualizada

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

        private void CarritoDeCompras_Load(object sender, EventArgs e)
        {
            dgvCarrito.DataSource = UtilidadesPedido.productosComprados;
            ActualizarLabels();
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
