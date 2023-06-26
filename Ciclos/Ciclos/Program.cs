using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo while
            // ciclo de repetição - while

            //int valor = 0;

            //while(valor < 10)
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //}
            #endregion

            #region Ciclo do-while
            // ciclo do while executa pelo menos uma vez o bloco de código
            //int valor = 0;

            //do
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //} while (valor < 10);

            #endregion

            #region Ciclo for

            // for (variável de controle ; condição ; iteração)

            //for (int i = 0, j = 10; i < 10; i++, j--)
            //{
            //    Console.WriteLine("I = " + i + " | J = " + j);
            //}
            #endregion

            #region Ciclo Foreach
            // ciclo de repetição para coleções (arrays)

            //string[] nomes = { "Gabriel", "Danny", "Arthur", "João" };

            //foreach (string nome in nomes)
            //{
            //    Console.WriteLine("Nome: " + nome);
            //}
            #endregion

            Console.ReadKey();
        }
    }
}
