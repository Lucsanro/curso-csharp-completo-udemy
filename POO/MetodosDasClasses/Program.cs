﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Metodos m = new Metodos();

            #region Métodos simples
            //m.Cumprimentar();
            #endregion

            #region Métodos com parâmetros
            //m.Apresentar("Gabriel", 35);
            //m.Somar(10, 5);
            #endregion

            #region Passagem de parâmetros por valor e referência
            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);
            #endregion

            #region Métodos com retorno de valores

            //string nomeCompleto = m.MontaNome("Gabriel", "Artigas");
            //int codigoChar = m.CodigoChar('e');
            //double pi = m.ValorPI();

            //Console.WriteLine("O nome completo é " + nomeCompleto);
            //Console.WriteLine("O código referente ao caractere é " + codigoChar);
            //Console.WriteLine("O valor de PI é " + pi);

            #endregion

            #region Sobrecarga de Métodos

            //m.Cumprimentar();
            //m.Cumprimentar("Gabriel");
            //m.Cumprimentar("Gabriel", 18);

            //bool res1 = m.Comparar(100, 50 * 2);
            //bool res2 = m.Comparar("Gabriel", "gabriel");

            //Console.WriteLine(res1);
            //Console.WriteLine(res2);

            #endregion

            Console.ReadKey();

        }
    }
}
