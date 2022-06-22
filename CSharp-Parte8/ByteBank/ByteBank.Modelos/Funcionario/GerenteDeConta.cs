using System;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando GERENTE DE CONTA");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        internal protected override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
