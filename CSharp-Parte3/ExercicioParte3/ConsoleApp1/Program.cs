using BancoExercicio.Funcionarios;
using System;

namespace BancoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Diretor beatriz = new Diretor(); //INSTANCIA DE UMA CLASSE
            beatriz.Nome = "Beatriz"; //REFERÊNCIA PARA UM ATRIBUTO
            beatriz.CPF = "512.875.863.-58";
            beatriz.Salario = 10000;
            gerenciador.Registrar(beatriz);


            Desenvolvedor larissa = new Desenvolvedor();
            larissa.Nome = "Larissa";
            larissa.CPF = "542.879.363.-63";
            larissa.Salario = 6000;
            gerenciador.Registrar(larissa);


            Designer rian = new Designer();
            rian.Nome = "Rian";
            rian.CPF = "326.251.648-15";
            rian.Salario = 3000;
            gerenciador.Registrar(rian);


            Console.WriteLine(beatriz.Nome);
            Console.WriteLine(beatriz.GetBonificacao());
            Console.WriteLine(larissa.Nome);
            Console.WriteLine(larissa.GetBonificacao());
            Console.WriteLine(rian.Nome);
            Console.WriteLine(rian.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
