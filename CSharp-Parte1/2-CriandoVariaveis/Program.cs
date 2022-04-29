using System;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variáveis");

            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade); //WriteLine significa que vai escrever e depois pular uma linha
            //se estivesse escrito somente Console.Write(); ele iria continuar o código na mesma linha

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine(); 



        }
    }
}
