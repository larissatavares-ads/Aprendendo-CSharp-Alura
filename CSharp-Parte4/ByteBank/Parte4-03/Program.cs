﻿using System;
using System.IO;

namespace Parte4_03
{
    class Program
    {


        //------------------------------------------

        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO MÉTODO MAIN");
            }


            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {

            using(LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            } 

            //-------------------------------------------------------
            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            //}
            //finally
            //{
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}

        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(32154, 59989754);
                ContaCorrente conta2 = new ContaCorrente(56898, 12356468);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);

            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("Informações da INNER EXCEPTION (exceção interna): ");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
        }

        private static void Metodo()
        {
            TestaDivisao(10);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }
    }
}
