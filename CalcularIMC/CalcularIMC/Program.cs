using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o seu peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Insira a sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("IMC: " + valorIMC + " -> Abaixo do peso.");
            }
            else if ((valorIMC >= 20) && (valorIMC < 25))
            {
                Console.WriteLine("IMC: " + valorIMC + " -> Peso normal.");
            }
            else if ((valorIMC >= 25) && (valorIMC < 30))
            {
                Console.WriteLine("IMC: " + valorIMC + " -> Acima do peso.");
            }
            else if ((valorIMC >= 30) && (valorIMC <= 34))
            {
                Console.WriteLine("IMC: " + valorIMC + " -> Obeso.");
            }
            else
            {
                Console.WriteLine("IMC: " + valorIMC + " -> Muito obeso.");
            }

            Console.ReadKey();
        }
    }
}
