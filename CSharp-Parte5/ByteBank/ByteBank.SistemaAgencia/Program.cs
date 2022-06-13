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
            DateTime dataFimPagamento = new DateTime(2022, 6, 20);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca1 = TimeSpan.FromMinutes(40); //Faz o tempo ser de minutos
            TimeSpan diferenca2 = dataFimPagamento - dataCorrente; //Faz a conta dos dias

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca1);

            Console.WriteLine(mensagem);
           
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
