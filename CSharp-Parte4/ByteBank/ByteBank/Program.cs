﻿using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;


namespace ByteBank
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (NullReferenceException erro)
            {
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Aconteceu um erro");
            }
            
            Console.ReadLine();
        }

        public class ContaCorrente
        {
            public bool Saldo { get; set; }
        }
        private static void Metodo()
        {
            TestaDivisao(0);
        }
        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch(DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);

                Console.WriteLine("Não é possível fazer uma divisão por zero.");
            }
        }
        private static int Dividir(int numero, int divisor)
        {
            //ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);
            //return numero / divisor;
        }
    }
}
