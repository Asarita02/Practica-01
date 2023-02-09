using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desea permutaciones con o sin repeticion?");
            Console.WriteLine("1. Sin repetición");
            Console.WriteLine("2. Con repetición");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una cadena: ");
            string str = Console.ReadLine();

            Console.WriteLine(opcion == 1 ? "Permutaciones sin repetición: " : "Permutaciones con repetición: ");
            Permute(str, 0, str.Length - 1, opcion == 2);
        }

        static void Permute(string str, int l, int r, bool repetition)
        {
            if (l == r)
                Console.WriteLine(str);
            else
                for (int i = l; i <= r && (repetition || l == i || str[l] != str[i]); i++)
                {
                    str = Swap(str, l, i);
                    Permute(str, l + 1, r, repetition);
                    str = Swap(str, l, i);
                }
        }

        static string Swap(string str, int i, int j)
        {
            char[] charArray = str.ToCharArray();
            charArray[i] ^= charArray[j];
            charArray[j] ^= charArray[i];
            charArray[i] ^= charArray[j];
            return new string(charArray);
        }
    }
}
