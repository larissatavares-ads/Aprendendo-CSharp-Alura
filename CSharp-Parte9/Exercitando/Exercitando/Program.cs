using System;
using System.IO;
using System.Text;

namespace Exercitando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var fs = new FileStream("nomes.txt", FileMode.Open))
            {
                var buffer = new byte[128]; // Buffer de 128 bytes
                var encoding = Encoding.UTF8;

                var bytesLidos = -1;

                while (bytesLidos != 0)
                {
                    bytesLidos = fs.Read(buffer, 0, 128);
                    var conteudo = encoding.GetString(buffer, 0, bytesLidos);
                    Console.Write(conteudo);
                }
            }
        }
    }
}
