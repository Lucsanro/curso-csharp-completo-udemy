using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar a = new Acessar();

            Inicio:

            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            if (a.Login(senha))
            {
                Console.WriteLine("Seja bem vindo!");

                Console.ReadKey();
            } 
            else
            {
                Console.WriteLine("Acesso negado!");

                Console.Write("Tentar novamente (S/N)? ");
                string resposta = Console.ReadLine();

                if (resposta == "S" || resposta == "s")
                {
                    goto Inicio;
                }
            } 
        }
    }
}
