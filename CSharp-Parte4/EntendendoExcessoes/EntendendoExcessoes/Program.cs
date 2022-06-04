﻿using System;

namespace EntendendoExcessoes
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é possível divisão por zero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro");
            }
            
            Console.ReadLine();
        }
        
        private static void Metodo()
        {
            TestaDivisao(0);
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
                Console.WriteLine("Exceção com número=" + numero + " e divissor=" + divisor);
                throw; //throw é um controle de fluxo
            }

        }
    }
}