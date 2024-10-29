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
        public formAlimentos()
        {
            InitializeComponent();
        }

        Producto productoAgregado;

        private void btnAgregarLaptop_Click(object sender, EventArgs e)
        {
            Producto productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[11];
            int numPiezas = int.Parse(nudPiezasPan.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas,productoSelecionado.Cantidad);
            if(hayStock == true)
            {
                productoAgregado = new ProductoAlimenticio(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }

        private void btnLeche_Click(object sender, EventArgs e)
        {
            Producto productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[12];
            int numPiezas = int.Parse(nudPiezasLeche.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                productoAgregado = new ProductoAlimenticio(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }

        }

        private void btnHuevos_Click(object sender, EventArgs e)
        {
            Producto productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[14];
            int numPiezas = int.Parse(nudPiezasHuevos.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                productoAgregado = new ProductoAlimenticio(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }

        private void btnManzana_Click(object sender, EventArgs e)
        {
            Producto productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[10];
            int numPiezas = int.Parse(nudPiezasManzanas.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                productoAgregado = new ProductoAlimenticio(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }

        private void btnQueso_Click(object sender, EventArgs e)
        {
            Producto productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[13];
            int numPiezas = int.Parse(nudPiezasQueso.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                productoAgregado = new ProductoAlimenticio(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }
    }
}
