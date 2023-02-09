using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuacionesprimergrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a al programa de Ecuaciones Diferenciales de Primer Grado");

            float coeficiente, constante;
            float resultado;
            Console.WriteLine("Ingrese el valor del coeficiente: ");
            coeficiente = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la constante: ");
            constante = float.Parse(Console.ReadLine());
            resultado = -constante / coeficiente;
            Console.WriteLine("El resultado de la ecuación es: x = " + resultado);
            Console.ReadKey();
        }
    }
}
