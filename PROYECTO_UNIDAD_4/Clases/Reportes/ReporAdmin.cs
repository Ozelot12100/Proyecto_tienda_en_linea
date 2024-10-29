using PROYECTO_UNIDAD_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_UNIDAD_4.Clases.Reportes
{
    internal class ReporAdmin : IGenerarReporte
    {
        public DateTime Fecha { get; set; }
        public double Subtotal { get; set; }
        public double Impuestos { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }
        public string MetodoDePago { get; set; }
        
        public ReporAdmin (DateTime fecha, double subtotal, double impuestos, double descuento, double total,string metodoPago)
        {
            Fecha = fecha;
            Subtotal = subtotal;
            Impuestos = impuestos;
            Descuento = descuento;
            Total = total;
            MetodoDePago = metodoPago;
        }
        public void Generar()
        {
            // Mostrar mensaje de compra exitosa
            MessageBox.Show($"Compra finalizada exitosamente por un total de ${UtilidadesPedido.CalcularTotal(UtilidadesPedido.productosComprados)}.", "Compra Exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
