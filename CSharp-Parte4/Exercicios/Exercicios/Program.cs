using System;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (NullReferenceException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }

          
            Console.ReadLine();

        }
        //------------------------------------
        public class ContaCorrente
        {
            public int Saldo { get; set; }

        }

        static void Metodo()
        {
            TestaDivisao(2);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }

        public static int Dividir(int numero, int divisor)
        {

            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);


            return numero / divisor;
        }
        //-------------------------------------------




    }
}
