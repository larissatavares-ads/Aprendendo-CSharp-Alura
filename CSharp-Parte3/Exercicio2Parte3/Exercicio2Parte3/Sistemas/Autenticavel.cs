using Exercicio2Parte3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Parte3.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
