﻿using PROYECTO_UNIDAD_4.Interfaces;
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
        public string TipoDeCompra {  get; set; }

        public ReporAdmin (DateTime fecha, double subtotal, double impuestos, double descuento, double total,string metodoPago, string tipoDeCompra)
        {
            Fecha = fecha;
            Subtotal = subtotal;
            Impuestos = impuestos;
            Descuento = descuento;
            Total = total;
            MetodoDePago = metodoPago;
            TipoDeCompra = tipoDeCompra;
        }
        public void Generar()
        {
            // Mostrar mensaje de compra exitosa
            MessageBox.Show($"Tiene un máximo de 3 días para pedir reembolso", "Compra Exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
