using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###");
            Console.Write("Insira aqui a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("---------------------------------");

            // f = (c * 9 / 5) + 32
            f = (c * 9 / 5) + 32;

            // k = c + 273,15
            k = c + 273.15;
            
            Console.WriteLine(c + " graus celsius = " + f + " graus fahrenhait");
            Console.WriteLine(c + " graus celsius = " + k + " graus kelvin");
            Console.WriteLine("---------------------------------");
            Console.ReadKey();
        }
    }
}
