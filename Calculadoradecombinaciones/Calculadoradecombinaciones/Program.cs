using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoradecombinaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora de combinaciones Geomel");
            Console.WriteLine("Ingrese el número de elementos (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número de elementos a elegir (s): ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Permitir repeticiones? (si/no): ");
            string permiteRepeticiones = Console.ReadLine();

            int numerador;
            int denominador;
            int resultado;
            if (permiteRepeticiones == "s")
            {
                numerador = Factorial(n + k - 1);
                denominador = Factorial(k) * Factorial(n - 1);
                resultado = numerador / denominador;
                Console.WriteLine("El número de combinaciones con repetición es: " + resultado);
            }
            else
            {
                numerador = Factorial(n);
                denominador = Factorial(k) * Factorial(n - k);
                resultado = numerador / denominador;
                Console.WriteLine("El número de combinaciones sin repetición es: " + resultado);
            }
            Console.ReadLine();
        }

        static int Factorial(int n)
        {
            int resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado = resultado * i;
            }
            return resultado;
        }
    }
}
