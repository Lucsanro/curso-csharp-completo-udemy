using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        enum Notas
        {
            Minima = 10,
            Media = 15,
            Maxima = 30
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {

            #region Numericas Integrais
            //// Integral assinado (aceita negativos)
            //sbyte num1 = 10;  // 8 bits
            //short num2 = 20;  // 16 bits
            //int num3 = 30;  // 32 bits
            //long num4 = 40L; // 64 bits

            //// Integral sem sinal (não aceita negativos)
            //byte num5 = 10;  // 8 bits
            //ushort num6 = 20;  // 16 bits
            //uint num7 = 30;  // 32 bits
            //ulong num8 = 40L; // 64 bits

            //sbyte numero;

            //numero = 100;

            //numero = 120;

            //numero = num1;
            #endregion

            #region Números Reais
            //float real1 = 110.75f;         // 32 bits
            //double real2 = 12500.45;       // 64 bits
            //decimal real3 = 754331.546m;   // 128 bits

            //double valor;
            //valor = real1;
            #endregion

            #region Caractere
            //char letra = 'C';
            //char letraDecimal = '\u0041';
            //char quebraDeLinha = '\n';
            //char nulo = '\0';
            //char barraInvertida = '\\';
            #endregion

            #region Boolean
            //bool verificar = false;
            //verificar = true;
            #endregion

            #region String (Cadeia de Caracteres)
            //string texto = @"Gabriel Artigas Pierri \n 1985 @@$$##%%";
            //string mensagem = null;
            //mensagem = texto;
            #endregion

            #region Tipo Implícito Var
            //var valor = 100;
            //valor = 200;
            //valor = "Gabriel";
            #endregion

            #region Tipo Object (Base para todos os tipos)
            //object obj;
            //obj = false;
            //obj = 200;
            //obj = "Gabriel";
            #endregion

            #region Constantes
            //const double pi = 3.1415;
            //const string nome = "Gabriel";
            #endregion

            #region Enumeração
            //Notas notasAluno = Notas.Media;
            #endregion

            #region Struct

            //Pessoa p1 = new Pessoa();
            //p1.nome = "Gabriel";
            //p1.idade = 35;
            //p1.altura = 1.65;

            //Pessoa p2 = new Pessoa()
            //{
            //    nome = "Arthur",
            //    idade = 9,
            //    altura = 1.35
            //};

            //p1.nome = "Logan";

            //Console.WriteLine(p1.nome);
            //Console.WriteLine(p1.idade);
            //Console.WriteLine(p1.altura);

            //Console.WriteLine();

            //Console.WriteLine(p2.nome);
            //Console.WriteLine(p2.idade);
            //Console.WriteLine(p2.altura);

            #endregion


            Console.WriteLine();
            Console.ReadKey();  
        }
    }
}
