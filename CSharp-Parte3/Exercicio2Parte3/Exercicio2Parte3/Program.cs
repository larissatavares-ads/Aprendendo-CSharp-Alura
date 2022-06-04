using Exercicio2Parte3.Funcionarios;
using Exercicio2Parte3.Sistemas;
using System;

namespace Exercicio2Parte3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();
            Console.ReadLine();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor beatriz = new Diretor("251.584.879-65");
            beatriz.Nome = "Beatriz";
            beatriz.Senha = "abc";

            sistemaInterno.Logar(beatriz, "abc");
        }
        public static void CalcularBonificacao()
        {
            //GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            
            

            //gerenciadorBonificacao.Registrar(beatriz);
            //Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
