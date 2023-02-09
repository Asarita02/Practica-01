using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoradefis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el valor de la velocidad (v), el tiempo (t) o la distancia (d):");
            string input1 = Console.ReadLine();

            Console.WriteLine("Introduce el valor del otro dato:");
            string input2 = Console.ReadLine();

            double value1 = Convert.ToDouble(input1);
            double value2 = Convert.ToDouble(input2);

            if (input1.ToLower() == "v")
            {
                double d = value2;
                double t = value1 / d;
                Console.WriteLine("La distancia es: " + d + " y el tiempo es: " + t);
            }
            else if (input1.ToLower() == "t")
            {
                double d = value2;
                double v = value1 * d;
                Console.WriteLine("La distancia es: " + d + " y la velocidad es: " + v);
            }
            else if (input1.ToLower() == "d")
            {
                double t = value2;
                double v = value1 / t;
                Console.WriteLine("El tiempo es: " + t + " y la velocidad es: " + v);
            }
            else
            {
                Console.WriteLine("Entrada no válida");
            }
    }
}
