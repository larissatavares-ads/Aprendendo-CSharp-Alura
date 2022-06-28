using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // IO = Input e Output

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Usado para criar o arquivo e escrever nele o conteúdo
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
            Console.WriteLine("Aquivo escrevendoCOmAClasseFile.txt criado!");


            // retornam a quantidade de bytes
            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length}");


            // retornam a quantidade de linhas
            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.ReadLine();

            Console.WriteLine("Digite seu nome:");
            var nome = Console.ReadLine();

            Console.WriteLine(nome);





            UsarStreamDeEntrada();
           
            Console.WriteLine("Aplicação finalizada...");

            Console.ReadLine();
        }
    }
}
