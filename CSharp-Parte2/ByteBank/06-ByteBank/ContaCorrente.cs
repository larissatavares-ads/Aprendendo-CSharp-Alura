namespace _06_ByteBank
{
    public class ContaCorrente
    {
        
        public Cliente Titular { get; set; }
        //AQUI É O QUE ACONTECE POR BAIXO DOS PANOS DO CÓDIGO ACIMA
        //private Cliente _titular;
        //public Cliente Titular
        //{
        //    get
        //    {
        //        return _titular;
        //    }
        //    set
        //    {
        //        _titular = value; 
        //    }
        //}


        public int Agencia { get; set; }
        public int Numero { get; set; }


        private double _saldo = 100; //private só é acessivel dentro da classe que a possui

        public double Saldo
        {
            get
            {
                return _saldo; // esse underline colocado na frente é uma convenção para campos privados que pertencem a classe Saldo
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        //O QUE ESTÁ ESCRITO ABAIXO É O QUE ACONTECE POR DEBAIXO DOS PANOS NO CÓDIGO ACIMA
        //public void SetSaldo(double saldo) // SetSaldo é o mesmo que DefinirSaldo
        //{
        //    if(saldo < 0) // este saldo se refere ao parâmetro acima declarado chamado saldo;
        //    {
        //        return; // quando tem um return em um método void, a gente para de executar imediatamente o método;
        //    }
        //    else
        //    {
        //        this.saldo = saldo; // o this.saldo se refere ao campo saldo definido acima, na classe;
        //    }
        //}

        //public double GetSaldo() // GetSaldo é o mesmo que ObterSaldo
        //{
        //    return saldo;
        //}


        public bool Sacar(double valor) 
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }


        public void Depositar(double valor) 
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}