using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoradevolumen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora del columen de figuras geometricas Geomel");
            Console.WriteLine("Seleccione la figura geométrica que desea calcular el volumen:");
            Console.WriteLine("1. Cubo");
            Console.WriteLine("2. esfera");
            Console.WriteLine("3. Cono");
            Console.WriteLine("4. Piramide");

            int opcion = Convert.ToInt32(Console.ReadLine());
            double volumen = 0.0;

            if (opcion == 1)
            {
                Console.WriteLine("Ingrese la longitud del lado del cubo:");
                double lado = Convert.ToDouble(Console.ReadLine());
                volumen = lado * lado * lado;
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Ingrese el radio de la esfera:");
                double radio = Convert.ToDouble(Console.ReadLine());
                volumen = (4.0 / 3.0) * Math.PI * radio * radio * radio;
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Ingrese el radio y la altura del cono:");
                double radio = Convert.ToDouble(Console.ReadLine());
                double altura = Convert.ToDouble(Console.ReadLine());
                volumen = Math.PI * radio * radio * altura / 3.0;
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Ingrese la base y la altura de la pirámide:");
                double basePiramide = Convert.ToDouble(Console.ReadLine());
                double altura = Convert.ToDouble(Console.ReadLine());
                volumen = (basePiramide * altura) / 3.0;
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }

            Console.WriteLine("El volumen es: " + volumen);
            Console.ReadLine();
        }
    }
}
