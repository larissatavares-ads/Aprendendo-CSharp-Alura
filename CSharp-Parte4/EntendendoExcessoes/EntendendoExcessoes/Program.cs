using System;

namespace EntendendoExcessoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente c1 = new ContaCorrente();
                ContaCorrente c2 = new ContaCorrente();
                
                c1.Sacar(1000);

            } catch(OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair.");
            Console.ReadLine();
        }

        private static void Metodo()
        {
            TestaDivisao(2);
        }
        private static void TestaDivisao(int divisor)
        {

            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);

        }
        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com número=" + numero + " e divissor=" + divisor);
                throw; //throw é um controle de fluxo
            }

        }
    }
}
