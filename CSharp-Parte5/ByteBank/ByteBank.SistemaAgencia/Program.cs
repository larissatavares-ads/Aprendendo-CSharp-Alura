using System;
using ByteBank.Funcionarios;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            object conta = new ContaCorrente(66666, 66666666);

            string contaToString = conta.ToString();
            Console.WriteLine("Resultado: " + conta.ToString());
            Console.WriteLine(conta);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "321.654.987-89";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "321.654.987-89";
            carlos_2.Profissao = "Designer";


            ContaCorrente conta_2 = new ContaCorrente(321, 5896);

            if(carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais.");
            }
            else
            {
                Console.WriteLine("Não são iguais!!!");
            }





            DateTime dataFimPagamento = new DateTime(2022, 6, 20);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca1 = TimeSpan.FromMinutes(40); //Faz o tempo ser de minutos
            TimeSpan diferenca2 = dataFimPagamento - dataCorrente; //Faz a conta dos dias

            string mensagem1 = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca1);
            string mensagem2 = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca2);
            
            Console.WriteLine(mensagem1);
            Console.WriteLine(mensagem2);
           
            Console.ReadLine();
        }

        //static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        //{
        //    if(timeSpan.Days > 30)
        //    {
        //        int quantidadeMeses = timeSpan.Days / 30;
        //        if(quantidadeMeses == 1)
        //        {
        //            return "1 mês";
        //        }
        //        return quantidadeMeses + " meses";
        //    } else if(timeSpan.Days > 7)
        //    {
        //        int quantidadeSemanas = timeSpan.Days / 7;
        //        if (quantidadeSemanas == 1)
        //        {
        //            return "1 semana";
        //        }
        //        return quantidadeSemanas + " semanas";
        //    }

        //    return timeSpan.Days + " dias";
        //}
    }
}
