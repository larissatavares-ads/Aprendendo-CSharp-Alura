using System;

namespace ContaCorrente2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBeatriz = new ContaCorrente(4445, 3059824);
            ContaCorrente contaDaLarissa = new ContaCorrente(4445, 3087658);
            Console.WriteLine("Total de contas correntes criadas: " + ContaCorrente.TotalDeContasCriadas);

            Cliente cliente = new Cliente();

            cliente.Nome = "Beatriz";
            cliente.CPF = "055.444.232-60";
            cliente.Profissao = "Desenvolvedora C#";
            cliente.RendaFamiliar = "6000";

            contaDaBeatriz.Titular = cliente;
 
            Console.WriteLine("Nome: " + contaDaBeatriz.Titular.Nome);
            Console.WriteLine("CPF: " + contaDaBeatriz.Titular.CPF);
            Console.WriteLine("Profissão: " + contaDaBeatriz.Titular.Profissao);
            Console.WriteLine("Renda familiar: " + contaDaBeatriz.Titular.RendaFamiliar);

            Console.WriteLine("Agência BEATRIZ: " + contaDaBeatriz.Agencia);
            Console.WriteLine("Número BEATRIZ: " + contaDaBeatriz.Numero);

            cliente.Nome = "Larissa";
            cliente.CPF = "032.186.232-51";
            cliente.Profissao = "Desenvolvedora Java";
            cliente.RendaFamiliar = "7000";

            contaDaLarissa.Titular = cliente;

            Console.WriteLine("Nome: " + contaDaLarissa.Titular.Nome);
            Console.WriteLine("CPF: " + contaDaLarissa.Titular.CPF);
            Console.WriteLine("Profissão: " + contaDaLarissa.Titular.Profissao);
            Console.WriteLine("Renda familiar: " + contaDaLarissa.Titular.RendaFamiliar);

            Console.WriteLine("Agência LARISSA: " + contaDaLarissa.Agencia);
            Console.WriteLine("Número LARISSA: " + contaDaLarissa.Numero);

            //----------------------------------------------------------------------------//

            contaDaBeatriz.Depositar(3000);
            Console.WriteLine("Saldo atual Beatriz após depósito: " + contaDaBeatriz.Saldo);
            contaDaLarissa.Depositar(10000);
            Console.WriteLine("Saldo atual Larissa após depósito: " + contaDaLarissa.Saldo);

            //---------------------------------------------------------------------------//

            bool ResultadoSacar = contaDaBeatriz.Sacar(4000);
            if (ResultadoSacar == false)
            {
                Console.WriteLine("BEATRIZ Seu saldo é insuficiente.");
            }
            else
            {
                Console.WriteLine("BEATRIZ Seu saldo atual após o saque é: " + contaDaBeatriz.Saldo);
            }

            bool ResultadoTransferencia = contaDaLarissa.Transferir(2000, contaDaBeatriz);
            if (ResultadoTransferencia == false)
            {
                Console.WriteLine("LARISSA Seu saldo é insuficiente. Você não pode realizar essa transferência.");
            }
            else
            {
                Console.WriteLine("LARISSA Seu saldo atual após a transferência é: " + contaDaLarissa.Saldo);
            }
            Console.WriteLine("Saldo atual Beatriz após recebimento de transferência: " + contaDaBeatriz.Saldo);
            bool ResultadoSacar2 = contaDaBeatriz.Sacar(4000);
            if (ResultadoSacar2 == false)
            {
                Console.WriteLine("BEATRIZ Seu saldo é insuficiente.");
            }
            else
            {
                Console.WriteLine("BEATRIZ Seu saldo atual após o saque é: " + contaDaBeatriz.Saldo);
            }

        }
    }
}
