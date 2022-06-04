using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;


namespace ByteBank
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
            SistemaInterno sistemaInterno  = new SistemaInterno();

            Diretor roberta = new Diretor("458.369.789-95");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("647.258.954-68");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("454.582.315-45");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("458.369.789-95");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("636.784.147-52");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("647.258.954-68");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("654.987.312-95");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }


    }
}
