using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea9_12.Capitulo10
{
    /// <summary>
    /// Clase Poligono con Sobrecarga de Contructores
    /// </summary>
    class ejercicios10_3
    {
       
            public Double Apotema { get; set; }
            public Double Perimetro { get; set; }

            public ejercicios10_3()
            {

            }

            public ejercicios10_3(double apotema, double perimetro)
            {
                Apotema = apotema;
                Perimetro = perimetro;
            }

        }
    }
