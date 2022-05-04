//using _05_ByteBank; //assim eu digo para o compilador que estou usando as classes que estão nesse namespace _05_ByteBank

namespace _05_ByteBank //ao colocar esse namespace aqui, não é necessário usar o using que fiz acima
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor) // qdo retorna um valor, é comum chamar de função
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


        public void Depositar(double valor) // qdo não retorna nenhum valor é comum chamar de método
        {
            this.saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
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
}