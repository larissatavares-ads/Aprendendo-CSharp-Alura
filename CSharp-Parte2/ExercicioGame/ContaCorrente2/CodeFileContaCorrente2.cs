using ContaCorrente2;

public class ContaCorrente
{
    public Cliente Titular { get; set; }
    public static int TotalDeContasCriadas { get; private set; } //ATRIBUTO
    
    private int _agencia;
    public int Agencia {
        get
        {
            return _agencia;
        }
        set
        {
            if(value <= 0)
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

    public ContaCorrente(int agencia, int numero)
    {
        Agencia = agencia;
        Numero = numero;
        ContaCorrente.TotalDeContasCriadas++;
    }

    private double _saldo;
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
            else
            {
                _saldo = value;
            }
        }
    }

    public void Depositar(double valor) //MÉTODO
    {
        this._saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (this._saldo < valor)
        {
            return false;
        }
        else
        {
            this._saldo -= valor;
            return true;
        }
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this._saldo < valor)
        {
            return false;
        }
        else
        {
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}