using PROYECTO_UNIDAD_4.Clases;
using PROYECTO_UNIDAD_4.Clases.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PROYECTO_UNIDAD_4.Forms.Admin
{
    public partial class FormInventarioAdmin : Form
    {
        public FormInventarioAdmin()
        {
            InitializeComponent();
            this.Load += FormInventarioAdmin_Load; // Vincular el evento Load al método
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvInventario.CurrentRow == null || dgvInventario.CurrentRow.Index == -1)
            {
                MessageBox.Show("Seleccione en la tabla el objeto que desea editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indiceFila = dgvInventario.CurrentRow.Index;

            // Verificar que el índice esté dentro del rango de la lista
            if (indiceFila < 0 || indiceFila >= UtilidadesPedido.TodosLosProductosInventario.Count)
            {
                MessageBox.Show("Seleccione un elemento válido en la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Capturar y validar los datos de los campos de texto
            string nombre = txtProducto.Text;
            int cantidad;
            double precio, impuesto, descuento;

            if (string.IsNullOrEmpty(nombre) ||
                !int.TryParse(txtPiezas.Text, out cantidad) ||
                !double.TryParse(txtPrecio.Text, out precio) ||
                !double.TryParse(txtImpuesto.Text, out impuesto) ||
                !double.TryParse(txtDescuento.Text, out descuento))
            {
                MessageBox.Show("Debe llenar todos los campos correctamente.", "Campos Vacíos o Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar los valores del producto seleccionado en el inventario
            UtilidadesPedido.TodosLosProductosInventario[indiceFila].Nombre = nombre;
            UtilidadesPedido.TodosLosProductosInventario[indiceFila].Cantidad = cantidad;
            UtilidadesPedido.TodosLosProductosInventario[indiceFila].Precio = precio;
            UtilidadesPedido.TodosLosProductosInventario[indiceFila].Impuesto = impuesto;
            UtilidadesPedido.TodosLosProductosInventario[indiceFila].Descuento = descuento;

            // Reasignar la fuente de datos para actualizar el DataGridView
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = UtilidadesPedido.TodosLosProductosInventario;

            MessageBox.Show("Producto editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void dgvInventario_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado una fila
            if (dgvInventario.CurrentRow != null && dgvInventario.CurrentRow.Index > -1)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFila = dgvInventario.CurrentRow.Index;

                // Verificar si el índice está dentro del rango de la lista
                if (indiceFila < UtilidadesPedido.TodosLosProductosInventario.Count)
                {
                    // Obtener el producto de la lista con base en el índice
                    Producto productoSeleccionado = UtilidadesPedido.TodosLosProductosInventario[indiceFila];

                    // Mostrar los datos del producto en los campos correspondientes
                    txtProducto.Text = productoSeleccionado.Nombre;
                    txtPiezas.Text = productoSeleccionado.Cantidad.ToString();
                    txtPrecio.Text = productoSeleccionado.Precio.ToString();
                    txtImpuesto.Text = productoSeleccionado.Impuesto.ToString();
                    txtDescuento.Text = productoSeleccionado.Descuento.ToString();
                }
            }
        }

        private void FormInventarioAdmin_Load(object sender, EventArgs e)
        {

            // Asignar la lista de productos como fuente de datos del DataGridView
            dgvInventario.DataSource = UtilidadesPedido.TodosLosProductosInventario;
        }
    }
}
