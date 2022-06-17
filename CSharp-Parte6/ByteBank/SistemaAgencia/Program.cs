using ByteBank.Funcionarios;
using ByteBank.Modelos;
using System;
using System.Text.RegularExpressions;

namespace SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);


            // Usando ToString();
            object conta = new ContaCorrente(3125, 654894894); // toda classe deriva de object
            object desenvolvedor = new Desenvolvedor("125313321");

            Console.WriteLine(conta);
            
            Console.WriteLine(desenvolvedor);

            string contaToString = conta.ToString();

            Console.WriteLine("Resultado " + conta.ToString());


            // Usando Equals();
            Cliente carlos_1 = new Cliente();
            Cliente carlos_2 = new Cliente();

            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "321.654.987-96";
            carlos_1.Profissao = "Designer";

            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "321.654.987-96";
            carlos_2.Profissao = "Designer";

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("Você está criando um Cliente igual a um já existente!");
            }
            else
            {
                Console.WriteLine("Os clientes criados não são iguais.");



            }
            Console.ReadLine();
        }
            static void TestaString()
            {

                // Olá meu nome é Larissa e você pode entrar em contato comigo
                // através do número 9784-2287!
                // Meu nome é Larissa, me ligue em 8376-2086.

                //"[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
                //"[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"; 
                //"[0-9]{4}[-][0-9]{4}"; 
                //"[0-9]{4,5}[-]{0,1}[0-9]{4}"; >> {4,5} >> significa que quero de 4 a 5 dígitos no início do telefone
                //"[0-9]{4,5}-{0,1}[0-9]{4}";
                string padrao = "[0-9]{4,5}-?[0-9]{4}"; //isso se chama expressão regular 

                string textoDeTeste = "Meu nome é Larissa, me ligue em 8376-2086.";

                Regex.IsMatch(textoDeTeste, padrao); // regex (regular expression) para testar a expressão regular

                Match resultado = Regex.Match(textoDeTeste, padrao);

                Console.WriteLine(resultado.Value);
                Console.ReadLine();


                string urlTeste = "https://www.bytebank.com/cambio";
                int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

                Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
                Console.WriteLine(urlTeste.EndsWith("cambio"));

                Console.WriteLine(urlTeste.Contains("bytebank"));

                //Console.WriteLine(indiceByteBank == 0); // o IndexOf retorna -1 quando o texto não é encontrado

                Console.ReadLine();

                // pagina?argumentos
                // 0123456789
                // o numero 6 é correspondente ao ?

                // moedaOrigem=real&moedaDestino=dolar

                string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
                ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

                string valor = extratorDeValores.GetValor("moedaDestino");
                Console.WriteLine("Valor de moedaDestino: " + valor);

                string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
                Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

                Console.WriteLine(extratorDeValores.GetValor("VALOR"));



                Console.ReadLine();



                // <nome>=<valor>
                string palavra = "moedaOrigem=real&moedaDestino=dolar";
                string nomeArgumento = "moedaDestino=";


                int indice = palavra.IndexOf(nomeArgumento);
                Console.WriteLine(indice);

                Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

                Console.WriteLine(palavra);
                Console.WriteLine(palavra.Substring(indice));
                Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
                Console.ReadLine();





                // Testando o IsNullOrEmpty
                string textoVazio = "";
                string textoNulo = null;
                string textoQualquer = "ijsdoidjkoadkas";
                Console.WriteLine(String.IsNullOrEmpty(textoVazio));
                Console.WriteLine(String.IsNullOrEmpty(textoNulo));
                Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
                Console.ReadLine();


                string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

                int indiceInterrogacao = url.IndexOf('?');
                Console.WriteLine(indiceInterrogacao);


                Console.WriteLine(url);
                string argumentos1 = url.Substring(indiceInterrogacao + 1);
                Console.WriteLine(argumentos1);
            }
        
    }
}
