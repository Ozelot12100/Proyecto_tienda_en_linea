using PROYECTO_UNIDAD_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_UNIDAD_4.Clases.Pago
{
    internal class PagoPayPal : IMetodoPago, IReembolso
    {
        public void ProcesarPago()
        {
            // Lógica para procesar el pago con tarjeta de crédito
            MessageBox.Show($"Su pago con paypal ha sido procesado por un total de {UtilidadesPedido.CalcularTotal(UtilidadesPedido.productosComprados)}");
        }

        public void ProcesarReembolso()
        {
            MessageBox.Show($"Lamentamos informarle que no hay sistema para devoluciones en compras hechas con paypal");
        }
    }
}
