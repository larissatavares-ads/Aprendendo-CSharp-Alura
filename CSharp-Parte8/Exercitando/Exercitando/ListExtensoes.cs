using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitando
{
    public class Aulas : IComparable
    {
        
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public class Aula
        {
            public string Titulo { get; set; }
            public int Tempo { get; set; }

            public Aula(string titulo, int tempo)
            {
                this.Titulo = titulo;
                this.Tempo = tempo;
            }
            public override string ToString()
            {
                return "[título: {titulo}, tempo: {tempo} minutos";
            }
        }
    }
}
