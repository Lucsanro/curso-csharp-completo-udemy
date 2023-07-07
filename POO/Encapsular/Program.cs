﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.Cliente = "Gabriel";
            //c.Saldo = 100; /* explícito, não pode ser dessa forma */

            // Operação de Depósito
            double valor = 100;
            c.Depositar(valor);

            // Operação de Saque
            double valor2 = 50;
            c.Sacar(valor2);

            //Resultado Saldo Atual
            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Saldo: " + c.Saldo);

            Console.ReadKey();

        }
    }
}