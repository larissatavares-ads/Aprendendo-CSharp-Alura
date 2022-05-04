using System;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBeatriz = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Beatriz";
            cliente.CPF = "032.186.232-51";
            cliente.Profissao = "Desenvolvedora C#";

            contaDaBeatriz.Saldo = -10;
            contaDaBeatriz.Titular = cliente;

            Console.WriteLine(contaDaBeatriz.Titular.Nome);
            Console.WriteLine(contaDaBeatriz.Saldo);


        }
    }
}
