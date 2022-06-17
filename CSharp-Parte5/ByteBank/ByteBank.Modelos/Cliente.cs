using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            Cliente outroCliente = obj as Cliente;

            if(outroCliente == null) { return false;  }

            return CPF == outroCliente.CPF;
        }
    }
}
