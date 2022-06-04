using System;
using System.Collections.Generic;
using System.Text;

namespace BancoExercicio.Funcionarios
{
    public class Desenvolvedor : Diretor
    {
        public override double GetBonificacao()
        {
            return Salario * 0.40;
        }
    }
}
