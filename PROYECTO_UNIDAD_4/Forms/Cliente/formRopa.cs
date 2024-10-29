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
    public partial class formRopa : Form
    {
        public formRopa()
        {
            InitializeComponent();
        }
        Producto productoAgregado;
        private void btnChaleco_Click(object sender, EventArgs e)
        {
            Producto productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[8];
            int numPiezas = int.Parse(nudPiezasChaleco.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                productoAgregado = new ProductoRopa(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }

        private void btnChamarra_Click(object sender, EventArgs e)
        {
            Producto productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[9];
            int numPiezas = int.Parse(nudPiezasChamarra.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                productoAgregado = new ProductoRopa(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }

        private void nudPiezasVestido_Click(object sender, EventArgs e)
        {
            Producto productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[7];
            int numPiezas = int.Parse(nudPiezaVestido.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                productoAgregado = new ProductoRopa(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }

        private void btnPantalon_Click(object sender, EventArgs e)
        {
            Producto productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[6];
            int numPiezas = int.Parse(nudPiezasPantalón.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                productoAgregado = new ProductoRopa(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }

        private void btnCamisea_Click(object sender, EventArgs e)
        {
            Producto productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[5];
            int numPiezas = int.Parse(nudPiezasCamiseta.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                productoAgregado = new ProductoRopa(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
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
