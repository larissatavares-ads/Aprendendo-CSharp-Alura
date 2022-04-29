using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variáveis ponto flutuante");

            double salario;
            salario = 1200.67;
            Console.WriteLine(salario);

            double idade;
            idade = 15.0 / 2; //para que o resultado seja em double, e mostre as casas decimais, deve-se colocar
            //número com decimal na expressão, exemplo 15.0
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
