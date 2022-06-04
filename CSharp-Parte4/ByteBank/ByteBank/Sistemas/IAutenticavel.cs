using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public interface IAutenticavel // o I na frente significa que é uma interface
    {
        bool Autenticar(string senha);
    }
}
