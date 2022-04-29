using System;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 9 - Escopo.");

            int idadeJoao = 18;
            bool acompanhado = false;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado.";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado.";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar. " + mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar. " + mensagemAdicional);
            }

            double salario = 5000.0;
            Console.WriteLine("Seu salário é de " + salario + " reais.");

            if (salario >= 1900 && salario < 2800)
            {
                salario = salario - 142;
            }
            if (salario >= 2800 && salario < 3751)
            {
                salario = salario - 350;
            }
            if (salario >= 3751 && salario < 4664)
            {
                salario = salario - 350;
            }
            Console.WriteLine("Seu salário atual é de: " + salario);


            int mes = 3;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                default:
                    Console.WriteLine("Mês inválido.");
                    break;
            }
        }
    }
}
