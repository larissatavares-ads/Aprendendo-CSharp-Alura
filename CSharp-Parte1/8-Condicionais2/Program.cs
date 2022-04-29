using System;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Festa secreta da Leia, veja se você poderá participar.");
            int idadeJoao = 15;
            int qunatidadePessoas = 2;

            if (idadeJoao >= 18 || qunatidadePessoas >= 2)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.WriteLine("Festa que só pode entrar acompanhado:");
            idadeJoao = 18;
            qunatidadePessoas = 0;

            if (idadeJoao >= 18 && qunatidadePessoas >= 2)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.WriteLine("Trabalhando com booleano:");
            idadeJoao = 18;
            qunatidadePessoas = 2;
            bool acompanhado = qunatidadePessoas >= 2;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }
        }
    }
}
