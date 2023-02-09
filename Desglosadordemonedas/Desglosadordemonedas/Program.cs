using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desglosadordemonedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desglosador de monedas");
            Console.WriteLine("Ingrese sus monedas?");
            int billetes = int.Parse(Console.ReadLine());
            int[] monedas = new int[10];
            monedas[0] = 2000;
            monedas[1] = 1000;
            monedas[2] = 500;
            monedas[3] = 200;
            monedas[4] = 100;
            monedas[5] = 50;
            monedas[6] = 25;
            monedas[7] = 10;
            monedas[8] = 5;
            monedas[9] = 1;

            int[] cantidad = new int[9];

            for (int i = 0; i < monedas.Length; i++)
            {
                int pesos = monedas[i];

                if (billetes >= pesos)
                {
                    Console.WriteLine(billetes + " Billetes de " + monedas[i]);
                    billetes %= monedas[i];
                }
                else
                {
                }
            }
            Console.ReadLine();
        }
    }
}
