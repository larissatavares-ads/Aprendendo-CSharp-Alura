using System;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabrielaCosta == contaDaGabriela)); // o resultado dessa expressão é falso pois estão salvos em endereços diferentes

            int idade = 27;
            int idadeMaiUmaVez = 27;
            Console.WriteLine("Igualdade de tipo de valor: " + (idadeMaiUmaVez == idade));


            contaDaGabriela = contaDaGabrielaCosta; // fazendo isso, agora vamos apontar para o mesmo objeto na memória
            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela); // por isso o resultado dessa expressão booleana será true.


            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo); // aqui as duas expressões vão receber o valor 300, mesmo nós não tendo atribuído o saldo à contaDaGabrielaCosta


            if (contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }



        }
    }
}
