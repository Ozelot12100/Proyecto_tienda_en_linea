using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_UNIDAD_4.Clases.Productos
{
    internal abstract class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public double Impuesto { get; set; }
        public double Descuento { get; set; }

        public Producto(string nombre, double precio, int cantidad,double impuesto,double descuento)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Impuesto = impuesto;
            Descuento = descuento;
        }

        
        
    }
}
