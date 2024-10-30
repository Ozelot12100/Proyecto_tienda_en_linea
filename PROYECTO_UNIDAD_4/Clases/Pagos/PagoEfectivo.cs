using PROYECTO_UNIDAD_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_UNIDAD_4.Clases.Pago
{
    internal class PagoEfectivo : IMetodoPago, IReembolso
    {
        public void ProcesarPago()
        {
            // Lógica para procesar el pago con tarjeta de crédito
            Console.WriteLine($"Gracias por seguir comprando de la forma tradicional, que le vaya bien (8");
        }
        
        public void ProcesarReembolso()
        {
            Console.WriteLine($"Puede pasar a recoger su reembolso mañana a partir de las 7:00 am");
        }
    }
}
