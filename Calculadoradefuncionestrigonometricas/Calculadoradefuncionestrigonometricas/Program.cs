using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoradefuncionestrigonometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora de funciones trigonometricas Geomel");
            Console.WriteLine("Seleccione la funcion trigonometrica requerica:");
            Console.WriteLine("1. seno"); 
            Console.WriteLine("2. Coseno");
            Console.WriteLine("3. tangente");
            Console.WriteLine("4. cotangente");
            Console.WriteLine("5. secante");
            Console.WriteLine("6. consecante");

            int opcion = Convert.ToInt32(Console.ReadLine());
            double resultado = 0.0;
            
            Console.WriteLine("Ingrese el ángulo en grados:");
            double grados = Convert.ToDouble(Console.ReadLine());
            double radianes = grados * (Math.PI / 180);

            

            if (opcion == 1)
            {
                resultado = Math.Sin(radianes);
            }
            else if (opcion == 2)
            {
                resultado = Math.Cos(radianes);
            }
            else if (opcion == 3)
            {
                resultado = Math.Tan(radianes);
            }
            else if (opcion == 4)
            {
                resultado = 1.0 / Math.Tan(radianes);
            }
            else if (opcion == 5)
            {
                resultado = 1.0 / Math.Cos(radianes);
            }
            else if (opcion == 6)
            {
                resultado = 1.0 / Math.Sin(radianes);
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }

            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadLine();
        }
    }
}
