using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca el primer número de la serie Fibonacci: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Inntroduzca el límite definido: ");
            int limitefibonacci = int.Parse(Console.ReadLine());

            Console.WriteLine("Serie de Fibonacci desde " + num1 + " hasta " + limitefibonacci + ":");
            Console.Write(num1 + " ");

            int num2 = 0;
            int resultado = 0;

            while (resultado <= limitefibonacci)
            {
                resultado = num1 + num2;
                num2 = num1;
                num1 = resultado;

                if (resultado > limitefibonacci)
                {
                    break;
                }

                Console.Write(resultado + " ");
            }

            Console.ReadLine();
        }
    }
}
