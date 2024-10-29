using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_UNIDAD_4.Clases.Pedidos
{
    internal class PedidoOnline : Pedido
    {
        public override void MostrarMensaje()
        {
            MessageBox.Show("Gracias por comprar en linea, sus productos llegaran sproximadamente en un mes");
        }
    }
}
