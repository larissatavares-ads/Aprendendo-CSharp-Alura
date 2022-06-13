using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(548, 321654);
            Console.WriteLine(conta.Saldo);

            ContaCorrente c1 = new ContaCorrente(321, 6548564);
            
            string nome = "Guilherme";



            Console.ReadLine();
        }
    }
}
