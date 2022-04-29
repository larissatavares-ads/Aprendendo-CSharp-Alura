using System;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = '8';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)87; //ao fazer isso, no console aparecerá uma letra
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1); //ao fazermos isso, aparecerá a próxima letra na sequência do alfabeto no console
            Console.WriteLine(primeiraLetra);

            char primeiraLetra1 = (char)(15);
            char primeiraLetra2 = (char)(9);
            Console.Write(primeiraLetra1+primeiraLetra2); //aqui ele somou os dois números, e exibiu no console em número

            string titulo = "Alura cursos de tecnologia " + 2020;
            Console.WriteLine(titulo);

            string cursosProgramacao = 
@"- .NET
- Java
- Javascrcipt";
            Console.WriteLine(cursosProgramacao);




            string saudacao = "Olá, meu nome é ";
            string nome = "Rômulo ";
            string continuacao = "e minha idade é ";
            int idade = 100;
            Console.WriteLine(saudacao + nome + continuacao + idade);


        }
    }
}
