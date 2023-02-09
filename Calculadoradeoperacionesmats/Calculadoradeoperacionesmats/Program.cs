using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoradeoperacionesmats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerador1, denominador1, numerador2, denominador2;
            int resultNumerador, resultDenominador;
            char operacion;

            Console.WriteLine("Bienvenido a la calculadora de operaciones con fracciones Geomel"); 
            Console.WriteLine("Ingrese el simbolo de la operacion que desea efectuar (+, -, *, /):");
            operacion = Console.ReadKey().KeyChar;
            
            Console.WriteLine("Ingrese la primera fracción (en formato a/b):");
            ObtenerFraccion(out numerador1, out denominador1);

            Console.WriteLine("Ingrese la segunda fracción (en formato a/b):");
            ObtenerFraccion(out numerador2, out denominador2);

            

            switch (operacion)
            {
                case '+':
                    resultNumerador = numerador1 * denominador2 + numerador2 * denominador1;
                    resultDenominador = denominador1 * denominador2;
                    break;
                case '-':
                    resultNumerador = numerador1 * denominador2 - numerador2 * denominador1;
                    resultDenominador = denominador1 * denominador2;
                    break;
                case '*':
                    resultNumerador = numerador1 * numerador2;
                    resultDenominador = denominador1 * denominador2;
                    break;
                case '/':
                    resultNumerador = numerador1 * denominador2;
                    resultDenominador = numerador2 * denominador1;
                    break;
                default:
                    Console.WriteLine("Operación inválida.");
                    return;
            }

            Console.WriteLine("Resultado: {0}/{1}", resultNumerador, resultDenominador);
        }

        static void ObtenerFraccion(out int numerador, out int denominador)
        {
            string[] partesFraccion = Console.ReadLine().Split('/');
            numerador = int.Parse(partesFraccion[0]);
            denominador = int.Parse(partesFraccion[1]);
            Console.ReadLine();
        }
    }
}
