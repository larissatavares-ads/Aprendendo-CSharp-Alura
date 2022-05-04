using System;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cliente gabriela = new Cliente(); //criando uma instância/objeto
            // a gabriela é uma referência para o objeto na memória
            // gabriela.nome = "Gabriela";
            // gabriela.profissao = "Desenvolvedora C#";
            // gabriela.cpf = "032.186.232.58";


            ContaCorrente conta = new ContaCorrente();

            // conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;


            if (conta.titular == null)
            {
                Console.WriteLine("Ops, a referência em conta.titular é NULL");
            }


            // Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome); //é igual ao código acima, pois ambos são referências para o mesmo objeto na memória do computador

            Console.ReadLine();
        }
    }
}
