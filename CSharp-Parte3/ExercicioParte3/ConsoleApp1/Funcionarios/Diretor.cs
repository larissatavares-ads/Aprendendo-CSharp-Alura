using System;
using System.Collections.Generic;
using System.Text;

namespace BancoExercicio.Funcionarios
{
    public class Diretor
    {
        public string Nome { get; set; } //ATRIBUTO
        public string CPF { get; set; } //ATRIBUTO
        public double Salario { get; set; } //ATRIBUTO

        public virtual double GetBonificacao() //MÉTODO
        {
            return Salario;
        }
    }
}
