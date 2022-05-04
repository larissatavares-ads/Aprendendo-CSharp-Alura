using System;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(512, 84512365); //usando o CONSTRUTOR
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);

            ContaCorrente contaDaGabriela = new ContaCorrente(512, 84523366);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(contaDaGabriela.Numero);
            Console.WriteLine(contaDaGabriela.Agencia);
            


            Console.ReadLine();
        }
    }
}
