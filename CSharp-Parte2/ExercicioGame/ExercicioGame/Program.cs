using System;

namespace ExercicioGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameRPGTeste personagem01 = new GameRPGTeste();
            personagem01.nomePersonagem = "Leon";
            Console.WriteLine(personagem01.nomePersonagem);

            personagem01.sexo = "Feminino";
            Console.WriteLine(personagem01.sexo);

            personagem01.classeRPG = "Guerreiro";
            Console.WriteLine(personagem01.classeRPG);

            personagem01.armaUsada = true;
            Console.WriteLine(personagem01.armaUsada);

            bool escolhaArma = personagem01.guerreiro(true);
            Console.WriteLine(escolhaArma);

        }
    }
}
