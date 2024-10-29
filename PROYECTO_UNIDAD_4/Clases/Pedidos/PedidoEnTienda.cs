using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_UNIDAD_4.Clases.Pedidos
{
    internal class PedidoEnTienda : Pedido
    {
        public override void MostrarMensaje()
        {
            MessageBox.Show("Gracias por seguir comprando de la forma tradicional, le regalamos estos cupones de cortesia");

        }
    }
}
