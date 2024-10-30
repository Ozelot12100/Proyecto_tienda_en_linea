using Guna.UI2.WinForms;
using PROYECTO_UNIDAD_4.Clases;
using PROYECTO_UNIDAD_4.Clases.Productos;
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
    public partial class formAlimentos : Form
    {
        private ProductoAlimenticio productoSeleccionado;

        public formAlimentos()
        {
            InitializeComponent();
            this.Load += formAlimentos_Load;
            dgvAlimentos.SelectionChanged += dgvAlimentos_SelectionChanged;
            txtBuscador.Enter += txtBuscador_Enter;
            txtBuscador.Leave += txtBuscador_Leave;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
        }

        private void formAlimentos_Load(object sender, EventArgs e)
        {
            FiltrarProductos(txtBuscador.Text);

            dgvAlimentos.ColumnHeadersVisible = true;
            dgvAlimentos.EnableHeadersVisualStyles = false;
            dgvAlimentos.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvAlimentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvAlimentos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAlimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            nubNumeroPiezas.Minimum = 1;
            nubNumeroPiezas.Maximum = 20;
            nubNumeroPiezas.Value = 1;
            nubNumeroPiezas.ReadOnly = true;
        }

        private void FiltrarProductos(string filtro)
        {
            var productosFiltrados = UtilidadesPedido.TodosLosProductosInventario
                .OfType<ProductoAlimenticio>()
                .Where(p => string.IsNullOrWhiteSpace(filtro) || filtro == "Buscar" || p.Nombre.StartsWith(filtro, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvAlimentos.DataSource = null;
            dgvAlimentos.DataSource = productosFiltrados;

            foreach (DataGridViewColumn columna in dgvAlimentos.Columns)
            {
                if (columna.Name != "Nombre" && columna.Name != "Precio")
                {
                    columna.Visible = false;
                }
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
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

        private void dgvAlimentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlimentos.CurrentRow != null)
            {
                productoSeleccionado = dgvAlimentos.CurrentRow.DataBoundItem as ProductoAlimenticio;
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

            var productoParaComprar = new ProductoAlimenticio(
                productoSeleccionado.Nombre,
                productoSeleccionado.Precio,
                cantidadSeleccionada,
                productoSeleccionado.Impuesto,
                productoSeleccionado.Descuento
            );

            UtilidadesPedido.productosComprados.Add(productoParaComprar);

            productoSeleccionado.Cantidad -= cantidadSeleccionada;
            FiltrarProductos(txtBuscador.Text);

            MessageBox.Show("Producto añadido al carrito correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
