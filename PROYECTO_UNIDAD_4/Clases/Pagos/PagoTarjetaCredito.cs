using PROYECTO_UNIDAD_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_UNIDAD_4.Clases.Pago
{
    internal class PagoTarjetaCredito : IMetodoPago, IReembolso
    {
        public void ProcesarPago()
        {
            MessageBox.Show($"Su pago con tarjeta de crédito ha sido procesado por un total de {UtilidadesPedido.CalcularTotal(UtilidadesPedido.productosComprados)}");
        }

        public void ProcesarReembolso()
        {
            MessageBox.Show($"Por el momento no contamos con reembolsos ni devoluciones para compras con tarjeta de crédito");
        }
    }
}
