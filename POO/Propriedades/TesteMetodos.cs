using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal partial class Teste
    {
        // Definição de métodos

        public void Apresentar()
        {
            if (_idade >= 18)
            {
                Console.WriteLine("Bem vindo " + _nome + " " + Sobrenome + "!");
            }
        }
    }
}
