using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario por hora: ");
            double salarioPorHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
            double horasTrabajadas = double.Parse(Console.ReadLine());

            double salarioBruto = salarioPorHora * horasTrabajadas;
            double salarioExtra = 0;
            if (horasTrabajadas > 44)
                salarioExtra = (horasTrabajadas - 44) * salarioPorHora * 0.3;

            double salarioNeto = salarioBruto + salarioExtra - (salarioBruto * 0.07) - (salarioBruto * 0.03);

            Console.WriteLine("Salario Bruto: $" + salarioBruto);
            Console.WriteLine("Salario Extra: $" + salarioExtra);
            Console.WriteLine("Salario Neto: $" + salarioNeto);
            Console.ReadLine();
        }
    }
}
