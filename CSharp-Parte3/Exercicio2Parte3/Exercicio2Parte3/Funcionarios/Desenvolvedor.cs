using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Parte3.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando DESENVOLVEDOR");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
