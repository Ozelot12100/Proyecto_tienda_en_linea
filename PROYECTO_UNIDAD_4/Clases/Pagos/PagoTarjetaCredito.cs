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
            Console.WriteLine($"Su pago con tarjeta de crédito ha sido procesado");
        }

        public void ProcesarReembolso()
        {
            Console.WriteLine($"Por el momento no contamos con reembolsos ni devoluciones para compras con tarjeta de crédito");
        }
    }
}
