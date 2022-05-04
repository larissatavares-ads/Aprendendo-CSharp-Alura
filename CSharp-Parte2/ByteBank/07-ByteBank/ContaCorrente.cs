namespace _07_ByteBank
{
    public class ContaCorrente
    {
        
        public Cliente Titular { get; set; }


        public static int TotalDeContasCriadas { get; private set; } //forma de reduzir o código dizendo que para dar um get a propriedade é pública mas para set é privada
        //ele não vai permitir que alguém modifique o valor de contas criadas
        //private static int TotalDeContasCriadas { get; set; } //o static diz que essa propriedade pertence a classe
        //public static int ObterTotalDeContasCriadas()
        //{
        //    return TotalDeContasCriadas;
        //}

        private int _agencia;
        public int Agencia 
        { 
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _agencia = value;
                }
            } 
        }
        public int Numero { get; set; }


        private double _saldo = 100; 

        public double Saldo
        {
            get
            {
                return _saldo; 
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

        //Abaixo estou escrevendo um CONSTRUTOR
        public ContaCorrente(int agencia, int numero) //forma de contruir, que exige agencia e exige numero
        {
            Agencia = agencia;
            Numero = numero;

            ContaCorrente.TotalDeContasCriadas++;
        }

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