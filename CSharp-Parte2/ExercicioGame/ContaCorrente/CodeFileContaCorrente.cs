public class ContaCorrente1
{
    public string titular;
    public double saldo = 100;

    //CRIAÇÃO DO MÉTODO DEPOSITAR 
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }


    //CRIAÇÃO DO MÉTODO SACAR
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }


    //CRIAÇÃO DO MÉTODO TRANSFERIR
    public bool Transferir(double valor, ContaCorrente1 contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}