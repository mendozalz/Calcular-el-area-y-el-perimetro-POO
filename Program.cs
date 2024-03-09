using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_el_area_y_el_perimetro_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrilatero c;
            Console.WriteLine("Selecciona una opción valida para calcular el área y perimetro de: \n Un Cuadrado en la opción 1 \n Un Rectangulo en la opción 2");
            double opcion = double.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Has seleccionado calcular el área y perimetro de un Cuadrado, ingresa tu valor a calcular");
                double valor = double.Parse(Console.ReadLine());
                c = new Cuadrilatero(valor);
                Console.WriteLine("El y perimetro de tu Cuadrado es " + c.perimetro() + " y el área de tu Cuadrado es " + c.area());
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Has seleccionado calcular el área y perimetro de un Rectangulo, ingresa el primer valor a calcular");
                double valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo valor a calcular");
                double valor2 = double.Parse(Console.ReadLine());
                c = new Cuadrilatero(valor1, valor2);
                Console.WriteLine("El y perimetro de tu Cuadrado es " + c.perimetro() + " y el área de tu Cuadrado es " + c.area());
            }
            else
            {
                Console.WriteLine("Solo son validas las opciones 1 y 2");
                c = new Cuadrilatero(0);
            }
            Console.Read();
        }
    }
}
