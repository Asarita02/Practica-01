using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificacionpromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora de nota promedio");
            Console.WriteLine("Por favor introduzca sus notas");

            Console.WriteLine("Introduzca la nota practica");
            int tp = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Introduzca la nota del parcial 1");
            int pp1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Introduzca la nota del parcial 2");
            int pp2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Introduzca la nota del examen final");
            int ef = Convert.ToInt16(Console.ReadLine());

            int prom = (tp + (pp1 + pp2) / 2 + ef) / 3;


            if (prom >= 90)
            {
                Console.WriteLine("Su literal es A y su nota promedio es " + prom);
                Console.ReadLine();
            }

            if (prom >= 80)
            {
                Console.WriteLine("Su literal es B y su nota promedio es " + prom);
                Console.ReadLine();
            }

            if (prom >= 70)
            {
                Console.WriteLine("Su literal es C y su nota promedio es " + prom);
                Console.ReadLine();
            }

            if (prom >= 60)
            {
                Console.WriteLine("Su literal es D y su nota promedio es " + prom);
                Console.ReadLine();
            }
            if (prom >= 50)
            {
                Console.WriteLine("Su literal es E y su nota promedio es " + prom);
                Console.ReadLine();
            }
            if (prom >= 40)
            {
                Console.WriteLine("Su literal es F y su nota promedio es " + prom);
                Console.ReadLine();
            }
        }
    }
}
