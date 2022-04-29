using System;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");
            Console.ReadLine();

            int idadeJoao = 16;
            int quantidadeDePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos.");
            }
            else
            {
                if (quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("João esá acompanhado, pode entrar.");
                }
                else
                {
                    Console.WriteLine("João não poderá entrar.");
                }
            }
        }
    }
}
