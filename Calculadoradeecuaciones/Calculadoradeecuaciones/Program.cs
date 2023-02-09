using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoradeecuaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula ecuaciones de 2do grado");

            Console.WriteLine("Ingrese el coeficiente de del termino cuadrado x^2: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el coeficiente de termino lineal x: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el término independiente: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminante = b * b - 4 * a * c;

            if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Las soluciones son x1 = " + x1 + " y x2 = " + x2);
            }
            else if (discriminante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("La solución es x = " + x);
            }
            else
            {
                Console.WriteLine("La ecuación no tiene soluciones reales");
            }

            Console.ReadLine();
        }
    }
}
