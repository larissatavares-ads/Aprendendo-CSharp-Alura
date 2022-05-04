using System;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.saldo = 200; // aqui tem uma alteração de valor padrão


             // todos possuem um valor padrão que pode ser alterado
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.numero);
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
