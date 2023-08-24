﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjBoleta
{
    internal class ClBoleta
    {
        public int NumeroBoleta { get; set; }
        public String NombreCliente { get; set; }
        public String DireccionCliente { get; set; }
        public String CedulaCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String DescripcionProducto { get; set; }
        public int CantidadComprada { get; set; }

        public double DeterminarPrecio()
        {

            switch (DescripcionProducto)
            {
                case "PS5 + 1 MANDO DS5": return 500;
                case "PS4 (1TB) + 1 MANDO DS4": return 619;
                case "MANDO PS5 / DS5": return 69;
                case "MANDO PS4 / DS4": return 60;

            }
            return 0;
        }

        // METODO PARA DETERMINAR EL IMPORTE 

        public double CalcularImporte()
        {
            return CantidadComprada * DeterminarPrecio();
        }
    }
}
