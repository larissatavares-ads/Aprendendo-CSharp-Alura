using System;

namespace ContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente1 contaDaBeatriz = new ContaCorrente1();
            contaDaBeatriz.titular = "Beatriz";
            Console.WriteLine(contaDaBeatriz.titular);
            Console.WriteLine("Saldo inicial: " + contaDaBeatriz.saldo);  
            // BEATRIZ FEZ DEPÓSITO DE R$500
            contaDaBeatriz.Depositar(500);
            Console.WriteLine("Saldo após depósito: " + contaDaBeatriz.saldo);

            // *****************************************************

            ContaCorrente1 contaDaLarissa = new ContaCorrente1();
            contaDaLarissa.titular = "Larissa";
            Console.WriteLine(contaDaLarissa.titular);
            Console.WriteLine("Saldo inicial: " + contaDaLarissa.saldo);
            // LARISSA FEZ DEPÓSITO DE R$300
            contaDaLarissa.Depositar(300);
            Console.WriteLine("Saldo após depósito: " + contaDaLarissa.saldo);

            // ***********************************************************

            // BEATRIZ TRANSFERIU R$200 PARA LARISSA
            contaDaBeatriz.Transferir(200, contaDaLarissa);
            Console.WriteLine("Saldo Beatriz após transferência de R$200 para Larissa: " + contaDaBeatriz.saldo);
            Console.WriteLine("Saldo Larissa após receber R$200: " + contaDaLarissa.saldo);

            // LARISSA SACOU R$300 REAIS
            contaDaLarissa.Sacar(300);
            Console.WriteLine("Saldo da Larissa após o saque de R$300: " + contaDaLarissa.saldo);
        }
    }
}
