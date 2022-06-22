using System;
using System.Collections.Generic;
using static Exercitando.Aulas;

namespace Exercitando
{
    public class Program
    {
        static void Main(string[] args)
        {
            var aulas = new List<Aula>()
            {
                new Aula("Métodos e propriedades", 35),
                new Aula("Expressões regulares", 29),
                new Aula("Classe object", 45)
            };

            aulas.Sort();
            Imprimir(aulas);
            Console.ReadLine();

        }
        static void Imprimir(List<Aula> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }


    }
}
