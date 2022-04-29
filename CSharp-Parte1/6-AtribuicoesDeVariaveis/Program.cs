using System;

namespace _6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);



            int parcela_1 = 10;
            int parcela_2 = 20;

            Console.WriteLine(parcela_1 + parcela_2);
        }
    }
}
