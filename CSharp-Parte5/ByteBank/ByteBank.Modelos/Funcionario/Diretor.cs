﻿using System;

namespace ByteBank.Funcionarios
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
        protected internal override double GetBonificacao()
        {    
            return Salario * 0.5; 
        }
    }
}
