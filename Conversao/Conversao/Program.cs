﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implícita
            //byte num1 = 100; // 8 bits, de 0 a 255
            //ushort num2; // 16 bits, de 0 a 65.535

            //float num3 = 1240.45f;
            //double num4 = num3;

            //num3 = num1;
            //num2 = num1;

            //int numero = 'C';
            #endregion

            #region Conversão Explícita
            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500.487f;
            //int num4 = (int)num3;

            //int num5 = (int)1987.234;

            //char letra = (char)97;
            #endregion

            #region Método Parse
            //string txtNumero = "1985";

            //int numero = int.Parse(txtNumero);

            //byte num1 = byte.Parse("120");

            //double num2 = double.Parse("125623,57");

            //float num3 = float.Parse("457,23");
            #endregion

            #region Classe Convert
            //string texto = Convert.ToString(2500);

            //double num1 = Convert.ToDouble(false);

            //int num2 = Convert.ToInt32('C');
            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
