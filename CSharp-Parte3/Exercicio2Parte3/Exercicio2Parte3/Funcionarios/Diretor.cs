﻿using Exercicio2Parte3.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Parte3.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

    }
}
