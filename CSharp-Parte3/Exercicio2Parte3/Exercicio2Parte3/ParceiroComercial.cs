using Exercicio2Parte3.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Parte3
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
