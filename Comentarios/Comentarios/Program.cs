using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentarios
{
    internal class Program
    {
        // Método principal do projeto
        // Mais uma linha para comentario
        static void Main(string[] args)
        {

            #region Bloco Comentario
            /*
             Este é um bloco de comentario
             Posso escrever varias linhas
             Que serão consideradas comentários
            */
            #endregion

            #region Primeira Parte
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            #endregion

            #region Segunda Parte
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            #endregion

            #region Terceira Parte
            Console.ReadKey();
            #endregion


        }
    }
}
