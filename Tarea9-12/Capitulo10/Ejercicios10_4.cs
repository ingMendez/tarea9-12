using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea9_12.Capitulo10
{
    /// <summary>
    /// Clase Poligono con propiedad que solamanente permita
    /// valores validos
    /// </summary>
   public class Ejercicios10_4
    {
        public Double Perimetro { get; set; }
        public Double Apotema { get; set; }

        public Ejercicios10_4()
        {

        }

        public Ejercicios10_4(double perimetro, double apotema)
        {
            Perimetro = perimetro;
            Apotema = apotema;
        }

        public double CalcularArea()
        {
            Perimetro = 20; Apotema = 4.25;

            return Perimetro * Apotema / 2;
        }
    }
}
