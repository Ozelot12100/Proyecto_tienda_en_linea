using PROYECTO_UNIDAD_4.Clases.Productos;
using PROYECTO_UNIDAD_4.Clases.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_UNIDAD_4.Clases
{
    internal static class UtilidadesPedido
    {
        
            public static List<Producto> TodosLosProductosInventario { get; set; } = new List<Producto>
            {
            // Productos Electrónicos
            new ProductoElectronico("Laptop", 12000, 10, 0.15,0),
            new ProductoElectronico("Smartphone", 20000, 20,0.15,0 ),
            new ProductoElectronico("Tablet", 5000, 15, 0.15,0),
            new ProductoElectronico("Televisor", 3000, 5, 0.15,0),
            new ProductoElectronico("Auriculares", 1000, 25,0.15,0),

            // Productos de Ropa
            new ProductoRopa("Camiseta", 100, 50,0,0.10),
            new ProductoRopa("Pantalón", 5000, 40,0,0.10),
            new ProductoRopa("Vestido", 500, 5,0,0.10),
            new ProductoRopa("Chaleco", 1000, 35,0,0.10),
            new ProductoRopa("Chamarra", 2000, 45,0,0.10),

            // Productos Alimenticios
            new ProductoAlimenticio("Manzanas", 10, 100,0.05,0),
            new ProductoAlimenticio("Pan", 60, 80,0.05,0),
            new ProductoAlimenticio("Leche", 50, 70,0.05,0),
            new ProductoAlimenticio("Queso", 150, 60,0.05,0),
            new ProductoAlimenticio("Huevos", 100, 200,0.05,0)
            };

            public static List<Usuarios> TodosLosUsuariosLista { get; set; } = new List<Usuarios>
            {
                new Usuarios("a","a","Administrador"),
                new Usuarios("c","c","Cliente"),
                new Usuarios("b","b","Vendedor")
            };                    

        public static List<Producto> productosComprados { get; set; } = new List<Producto>();

            public static List<ReporAdmin> reportesGenerados { get; set; } = new List<ReporAdmin>();

        public static bool ValidarStock(int cantidadSolicitada, int Cantidad)
        {
            bool existeSuficienteProducto;

            if (cantidadSolicitada > Cantidad)
            {
                return existeSuficienteProducto = false;
            }
            else
            {
                return existeSuficienteProducto = true;
            }
        }
        // Calcular el subtotal de toda la compra sin impuestos ni descuentos
        public static double CalcularSubtotal(List<Producto> productosComprados)
        {
            double subtotal = 0;
            foreach (var producto in productosComprados)
            {
                subtotal += producto.Precio * producto.Cantidad;
            }
            return subtotal;
        }

        // Calcular los impuestos totales de toda la compra
        public static double CalcularImpuestos(List<Producto> productosComprados)
        {
            double impuestos = 0;
            foreach (var producto in productosComprados)
            {
                impuestos += (producto.Precio * producto.Impuesto) * producto.Cantidad;
            }
            return impuestos;
        }

        // Calcular el descuento total de toda la compra
        public static double CalcularDescuento(List<Producto> productosComprados)
        {
            double descuento = 0;
            foreach (var producto in productosComprados)
            {
                descuento += (producto.Precio * producto.Descuento) * producto.Cantidad;
            }
            return descuento;
        }

        // Calcular el total a pagar de toda la compra
        public static double CalcularTotal(List<Producto> productosComprados)
        {
            double subtotal = CalcularSubtotal(productosComprados);
            double impuestos = CalcularImpuestos(productosComprados);
            double descuento = CalcularDescuento(productosComprados);

            // Total = Subtotal - Descuento + Impuestos
            return subtotal - descuento + impuestos;
        }

    }
}
