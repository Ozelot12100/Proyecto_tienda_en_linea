using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_UNIDAD_4.Clases.Productos
{
    internal class ProductoAlimenticio : Producto
    {
      
        
        public ProductoAlimenticio(string nombre, double precio, int Cantidad, double impuesto, double descuento)
        : base(nombre, precio, Cantidad, impuesto, descuento)
        {

        }

        
    }
}
