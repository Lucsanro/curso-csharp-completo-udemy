using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch - Case
            /*int escolha = 3;

            // Verificar como pedir para o usuário digitar o valor desejado
            // para usuário capturar o valor

            Console.WriteLine("Escolha: " + escolha);

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Opção 1");
                    break;
                case 2:
                    Console.WriteLine("Opção 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Opção combinada");
                    break;
                default:
                    Console.WriteLine("Opção default");
                    break;
            }

            Console.ReadKey();
            */
            #endregion

            #region Goto

            Inicio:

            Console.Write("Escolha uma opção: ");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (op)
            {
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;

                default:
                    Console.WriteLine("Opção inválida, escolha entre 1 e 2");
                    goto Inicio;

            }

            Console.WriteLine("Valor final: " + valor);

            Console.ReadKey();
            #endregion

        }
    }
}
