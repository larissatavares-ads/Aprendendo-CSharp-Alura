using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            //suporta uma precisão maior de números
            double salario;
            salario = 1200.50;
            Console.WriteLine(salario);
            
            //o int é uma variável que suporta até 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            //o long é uma variável de 64 bits
            long idadeTerra;
            idadeTerra = 4543000000000;
            Console.WriteLine("A idade da Terra é " + idadeTerra);

            //o short é uma variável de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            //o float suporta uma quantitade menor de números
            float altura = 1.80f;
            Console.WriteLine(altura);

            int trinta = 10 + 20;
            Console.WriteLine(trinta);


            Console.ReadLine();
        }
    }
}
