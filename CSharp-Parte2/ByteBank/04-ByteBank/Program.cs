﻿using System;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);




            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            bool resultadoTrabsferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);


            Console.WriteLine("Resultado da Transferência: " + resultadoTrabsferencia);


            contaDaGabriela.Transferir(100, contaDoBruno)
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
