﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
{
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);
    }
}
