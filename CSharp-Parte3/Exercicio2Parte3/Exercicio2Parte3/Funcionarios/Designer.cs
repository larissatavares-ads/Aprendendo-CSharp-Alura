using Exercicio2Parte3.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Parte3.Funcionarios
{
    internal class Designer : FuncionarioAutenticavel
    {
        public Designer(string cpf) : base(3000,cpf)
        {
            Console.WriteLine("Criando DESIGNER");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        public override double GetBonificacao()
        {
            return Salario = 0.3;
        }
    }
}
