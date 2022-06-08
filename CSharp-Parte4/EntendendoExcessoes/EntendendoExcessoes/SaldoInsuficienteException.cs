using System;
using System.Collections.Generic;
using System.Text;

namespace EntendendoExcessoes
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque {  get; }

        public SaldoInsuficienteException()
        { 
        }
        public SaldoInsuficienteException(double saldo, double valorSaque)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {

        }

    }
}
