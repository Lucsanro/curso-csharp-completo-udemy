using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.Nome = "Lucca";
            t.Idade = 18;

            t.Apresentar();

            Console.ReadKey();
        }
    }
}
