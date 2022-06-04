using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criando AUXILIAR");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
    }
}
