using BancoExercicio.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoExercicio
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Registrar (Diretor diretor)
        {
            _totalBonificacao += diretor.GetBonificacao();
        }
        public void Registrar (Desenvolvedor desenvolvedor)
        {
            _totalBonificacao += desenvolvedor.GetBonificacao();
        }
        public void Registrar (Designer designer)
        {
            _totalBonificacao += designer.GetBonificacao();
        }


        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
