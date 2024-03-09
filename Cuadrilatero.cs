using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_el_area_y_el_perimetro_POO
{
    internal class Cuadrilatero
    {
        private double lado1;
        private double lado2;

        public Cuadrilatero(double lado) // Para calcular el parametro solo basta con recibir un solo parametro como valor
        {
            this.lado1 = lado;
            this.lado2 = lado;
        }

        public Cuadrilatero(double _lado1, double _lado2) // Para clcular el area o perimetro de un rectangulo se necesitan dos parametros como valor
        {
            this.lado1 += _lado1;
            this.lado2 += _lado2;
        }

        public double perimetro()
        {
            return (lado1 + lado2) * 2;
        }

        public double area()
        {
            return lado1 * lado2;
        }
    }
}
