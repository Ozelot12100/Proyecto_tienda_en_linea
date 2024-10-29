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
        public formElectrodomesticos()
        {
            InitializeComponent();


        }

        Producto productoAgregado;
        Producto productoSelecionado;
        private void picAudifonos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarAudifonos_Click(object sender, EventArgs e)
        {
             productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[4];
            int numPiezas = int.Parse(nudpiezasAuriculares.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                 productoAgregado = new ProductoElectronico(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto,productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }

        private void btnAgregarLaptop_Click(object sender, EventArgs e)
        {
             productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[0];
            int numPiezas = int.Parse(nudpiezasLaptop.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                 productoAgregado = new ProductoElectronico(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
             productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[1];
            int numPiezas = int.Parse(nudpiezasSmartphone.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                 productoAgregado = new ProductoElectronico(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }

        private void btnAgregarTablet_Click(object sender, EventArgs e)
        {
             productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[2];
            int numPiezas = int.Parse(nudPiezasTablett.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                 productoAgregado = new ProductoElectronico(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
                UtilidadesPedido.productosComprados.Add(productoAgregado);
                productoSelecionado.Cantidad = productoSelecionado.Cantidad - numPiezas;
                MessageBox.Show("El producto de agregó al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto");
            }
        }

        private void btnAgregarTelevisor_Click(object sender, EventArgs e)
        {
             productoSelecionado = UtilidadesPedido.TodosLosProductosInventario[3];
            int numPiezas = int.Parse(nudpiezasTelevisor.Value.ToString());
            bool hayStock = UtilidadesPedido.ValidarStock(numPiezas, productoSelecionado.Cantidad);
            if (hayStock == true)
            {
                 productoAgregado = new ProductoElectronico(productoSelecionado.Nombre, productoSelecionado.Precio, numPiezas, productoSelecionado.Impuesto, productoSelecionado.Descuento);
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
