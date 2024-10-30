using PROYECTO_UNIDAD_4.Clases;
using PROYECTO_UNIDAD_4.Clases.Pago;
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
                MessageBox.Show("Seleccione un producto en el inventario para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            // Verificar si otro producto con el mismo nombre ya existe
            bool productoDuplicado = UtilidadesPedido.TodosLosProductosInventario
                .Where((p, index) => index != indiceFila)  // Excluir el producto actual
                .Any(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (productoDuplicado)
            {
                MessageBox.Show("Ya existe otro producto con el mismo nombre en el inventario.", "Producto Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtProducto.KeyPress += txtProducto_KeyPress;
            txtPiezas.KeyPress += txtPiezas_KeyPress;
            txtPrecio.KeyPress += txtDecimal_KeyPress;
            txtImpuesto.KeyPress += txtDecimal_KeyPress;
            txtDescuento.KeyPress += txtDecimal_KeyPress;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
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

            // Verificar si el producto con el mismo nombre ya existe
            bool productoDuplicado = UtilidadesPedido.TodosLosProductosInventario.Any(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (productoDuplicado)
            {
                MessageBox.Show("Ya existe un producto con el mismo nombre en el inventario.", "Producto Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que se haya seleccionado un tipo de producto en el ComboBox
            if (cmbElegirCategoría.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría de producto.", "Categoría No Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear el producto según el tipo seleccionado
            Producto nuevoProducto;
            string tipoProducto = cmbElegirCategoría.SelectedItem.ToString();

            switch (tipoProducto)
            {
                case "Ropa":
                    nuevoProducto = new ProductoRopa(nombre, precio, cantidad, impuesto, descuento);
                    break;
                case "Alimento":
                    nuevoProducto = new ProductoAlimenticio(nombre, precio, cantidad, impuesto, descuento);
                    break;
                case "Electrónica":
                    nuevoProducto = new ProductoElectronico(nombre, precio, cantidad, impuesto, descuento);
                    break;
                default:
                    MessageBox.Show("Seleccione un tipo de producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            // Añadir el nuevo producto a la lista de inventario
            UtilidadesPedido.TodosLosProductosInventario.Add(nuevoProducto);

            // Actualizar el DataGridView
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = UtilidadesPedido.TodosLosProductosInventario;

            MessageBox.Show("Producto añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvInventario.CurrentRow == null || dgvInventario.CurrentRow.Index == -1)
            {
                MessageBox.Show("Seleccione un producto en el inventario para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el índice de la fila seleccionada
            int indiceFila = dgvInventario.CurrentRow.Index;

            // Confirmar la eliminación
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto del inventario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Eliminar el producto de la lista de inventario
                UtilidadesPedido.TodosLosProductosInventario.RemoveAt(indiceFila);

                // Actualizar el DataGridView
                dgvInventario.DataSource = null;
                dgvInventario.DataSource = UtilidadesPedido.TodosLosProductosInventario;

                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacio y teclas de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPiezas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Permitir solo dígitos, un punto decimal y teclas de control
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }



    }
}
