using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoradeareas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la figura geométrica:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. triangulo");
            Console.WriteLine("4. pentagono");
            Console.WriteLine("5. hexagono");
            int opcion = Convert.ToInt32(Console.ReadLine());
            double area = 0.0;

            if (opcion == 1)
            {
                Console.WriteLine("Ingrese la longitud del lado del cuadrado:");
                double lado = Convert.ToDouble(Console.ReadLine());
                area = lado * lado;
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Ingrese el radio del círculo:");
                double radio = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * radio * radio;
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Ingrese la base y la altura del triángulo:");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                double altura = Convert.ToDouble(Console.ReadLine());
                area = 0.5 * baseTriangulo * altura;
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Ingrese la longitud del lado del pentágono:");
                double lado = Convert.ToDouble(Console.ReadLine());
                double apotema = (lado / (2 * Math.Tan(Math.PI / 5)));
                area = (5 * lado * apotema) / 2;
            }
            else if (opcion == 5)
            {
                Console.WriteLine("Ingrese la longitud del lado del hexágono:");
                double lado = Convert.ToDouble(Console.ReadLine());
                double apotema = (lado / (2 * Math.Tan(Math.PI / 6)));
                area = (6 * lado * apotema) / 2;
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }

            Console.WriteLine("El área es: " + area);
            Console.ReadLine();
        }
    }
}
