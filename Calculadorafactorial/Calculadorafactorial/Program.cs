using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadorafactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número que desee para calcular su factorial: ");

            int num = Convert.ToInt32(Console.ReadLine());
            int resultado = 1;

            for (int i = 1; i <= num; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine("El factorial de " + num + " es " + resultado);
            Console.ReadLine();
        }
    }
}
