using System;
using System.Collections.Generic;
using System.Text;

namespace _06_ByteBank
{
    public class Cliente
    {
        // para digitar mais rápido::  prop >tab >tab, e depois substitui o que precisa ser substituido
        // public int MyProperty { get; set; }

        public string Nome { get; set; }
        private string _cpf;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }
        public string Profissao { get; set; }



        //public string Nome { get; set; }
        //public string Cpf { get; set; }
        //public string Profissao { get; set; }


        //public string nome;
        //public string cpf;
        //public string profissao;
    }
}
