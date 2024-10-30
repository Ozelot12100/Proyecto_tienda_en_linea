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

namespace PROYECTO_UNIDAD_4.Forms.Cliente
{
    public partial class formElectrodomesticos : Form
    {
        private ProductoElectronico productoSeleccionado;
        private List<ProductoElectronico> productosElectronicos;

        public formElectrodomesticos()
        {
            InitializeComponent();
            this.Load += formElectrodomesticos_Load;
            dgvElectronica.SelectionChanged += dgvElectronica_SelectionChanged;
            txtBuscador.Enter += txtBuscador_Enter;
            txtBuscador.Leave += txtBuscador_Leave;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
        }

        private void formElectrodomesticos_Load(object sender, EventArgs e)
        {
            // Asignar la lista de productos electrónicos a la variable de clase productosElectronicos
            productosElectronicos = UtilidadesPedido.TodosLosProductosInventario
                .OfType<ProductoElectronico>()
                .ToList();

            // Mostrar los productos en el DataGridView al cargar el formulario
            FiltrarProductos(txtBuscador.Text);

            // Configurar estilo de encabezados
            dgvElectronica.ColumnHeadersVisible = true;
            dgvElectronica.EnableHeadersVisualStyles = false;
            dgvElectronica.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvElectronica.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvElectronica.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvElectronica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Configurar el NumericUpDown
            nubNumeroPiezas.Minimum = 1;
            nubNumeroPiezas.Maximum = 20;
            nubNumeroPiezas.Value = 1;
            nubNumeroPiezas.ReadOnly = true;
        }

        private void FiltrarProductos(string filtro)
        {
            // Si el filtro es "Buscar" o está vacío, mostrar todos los productos electrónicos
            var productosFiltrados = string.IsNullOrWhiteSpace(filtro) || filtro == "Buscar"
                ? productosElectronicos
                : productosElectronicos.Where(p => p.Nombre.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();

            // Asignar los productos filtrados al DataGridView
            dgvElectronica.DataSource = productosFiltrados;

            // Mostrar solo las columnas de Nombre y Precio
            foreach (DataGridViewColumn columna in dgvElectronica.Columns)
            {
                if (columna.Name != "Nombre" && columna.Name != "Precio")
                {
                    columna.Visible = false;
                }
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            // Filtrar productos en tiempo real mientras se escribe en el txtBuscador
            FiltrarProductos(txtBuscador.Text);
        }

        private void txtBuscador_Enter(object sender, EventArgs e)
        {
            if (txtBuscador.Text == "Buscar")
            {
                txtBuscador.Text = "";
            }
        }

        private void txtBuscador_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                txtBuscador.Text = "Buscar";
            }
        }

        private void dgvElectronica_SelectionChanged(object sender, EventArgs e)
        {
            // Obtener el producto seleccionado en la fila actual
            if (dgvElectronica.CurrentRow != null)
            {
                productoSeleccionado = dgvElectronica.CurrentRow.DataBoundItem as ProductoElectronico;
            }
        }

        private void btnAgregarProductoAlCarrito_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto primero.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidadSeleccionada = (int)nubNumeroPiezas.Value;

            if (cantidadSeleccionada > productoSeleccionado.Cantidad)
            {
                MessageBox.Show("La cantidad seleccionada excede el stock disponible.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var productoParaComprar = new ProductoElectronico(
                productoSeleccionado.Nombre,
                productoSeleccionado.Precio,
                cantidadSeleccionada,
                productoSeleccionado.Impuesto,
                productoSeleccionado.Descuento
            );

            UtilidadesPedido.productosComprados.Add(productoParaComprar);

            // Descontar del stock
            productoSeleccionado.Cantidad -= cantidadSeleccionada;
            dgvElectronica.Refresh(); // Actualizar el DataGridView para reflejar el nuevo stock

            MessageBox.Show("Producto añadido al carrito correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
