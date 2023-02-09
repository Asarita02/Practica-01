using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidordetemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temperatura;
            int opcion;
            Console.WriteLine("Programa que convierte de grados celsius a Kelvin y Fahrenheit"); 
            Console.WriteLine("Ingrese la temperatura en grados Celsius: ");
            temperatura = float.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione la conversión que desea realizar: ");
            Console.WriteLine("1. Celsius a Kelvin");
            Console.WriteLine("2. Celsius a Fahrenheit");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("La temperatura en Kelvin es: " + (temperatura + 273.15));
                    break;
                case 2:
                    Console.WriteLine("La temperatura en Fahrenheit es: " + ((temperatura * 9 / 5) + 32));
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
            Console.ReadLine();        }
    }
}
