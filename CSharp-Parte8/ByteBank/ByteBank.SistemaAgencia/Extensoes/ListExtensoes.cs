using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        // Abaixo um método genérico dentro de uma classe normal
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        public static void TesteGenerico<T2>(this string texto)
        {

        }


        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(26);
            idades.Add(60);

            //idades.AdicionarVarios<int>(12, 43, 545, 5, 42, 17); // o <int> pode ser simplificado
            idades.AdicionarVarios(12, 43, 545, 5, 42, 17);


            string guilherme = "Guilherme";
            guilherme.TesteGenerico<int>();



            // ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4);

            List<string> nomes = new List<string>();

            nomes.Add("Guilherme");
            nomes.Add("Larissa");

            nomes.AdicionarVarios("Lucas", "João");

            // ListExtensoes<string>.AdicionarVarios(nomes, "Lucas", "Mariana");
        }

    }
}
