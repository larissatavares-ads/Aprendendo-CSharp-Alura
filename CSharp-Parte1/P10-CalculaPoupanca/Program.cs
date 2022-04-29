using System;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            //double valorInvestido = 1000;
            //int contadorMes = 1;

            //while (contadorMes <= 12)
            //{
            //    valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //    Console.WriteLine("Após " + contadorMes + " mês você terá R$" + valorInvestido);

            //    //contadorMes = contadorMes + 1;
            //    //contadorMes += 1;
            //    contadorMes++;
            //}

            //// 0.36% = 0.0036
            ///



            //int idade = 19;
            //int contadorPessoas = 0;

            //while (contadorPessoas < 10)
            //{
            //    if (idade >= 18)
            //    {
            //        Console.WriteLine("Você é maior de idade.");
            //    } else
            //    {
            //        Console.WriteLine("Você é menor de idade.");
            //    }
            //    contadorPessoas = contadorPessoas + 1;
            //}





            for (int contador = 1; contador <= 100; contador++)
            {
                if (contador % 3 == 0)
                {
                    Console.WriteLine("O número " + contador + " é múltiplo de 3.");
                }
            }











        }
    }
}
