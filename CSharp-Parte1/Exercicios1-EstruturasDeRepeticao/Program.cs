using System;

namespace Exercicios1_EstruturasDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios sobre estruturas de repetição");

            //Console.WriteLine("1 - Faça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.");            
            //for (int contador = 1; contador <= 100; contador++)
            //{
            //    if (contador % 3 == 0)
            //    {
            //        Console.WriteLine("O número " + contador + " é múltiplo de 3.");
            //    }
            //}


            //int contador = 1;
            //while (contador <=10)
            //{
            //    Console.WriteLine(contador);
            //    contador++;
            //}
            //for (int contador = 1; contador <= 10; contador++)
            //{
            //    Console.WriteLine(contador);
            //}


            //int contador = 1;
            //while (contador <= 100 && contador % 3 == 0)
            //{
            //    Console.WriteLine("O número " + contador + " é múltiplo de 3.");
            //    contador++;
            //}



            //for (int linha = 0; linha < 5; linha++)
            //{
            //    for (int coluna = 0; coluna < 5; coluna++)
            //    {
            //        if (coluna > linha)
            //        {
            //            break;
            //        }
            //        Console.Write(coluna + 1);
            //    }
            //    Console.WriteLine();
            //}


            //for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            //{
            //    for (int contador = 0; contador <= 10; contador++)
            //    {
            //        Console.WriteLine(multiplicador + "*" + contador + " = " + multiplicador * contador);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //int fatorial = 1;
            //for (int i = 1; i < 11; i++)
            //{
            //    fatorial *= i;
            //    Console.WriteLine("O fatorial de " + i + " é: " + fatorial);
            //}
            //Console.ReadLine();


            //int total = 2;
            //for (int i = 0; i < 5; i += 1)
            //{
            //    total = total * 2;
            //}
            //Console.WriteLine("O total é: " + total);


            //Programa mara fazer tabuada
            //Console.WriteLine("Tabuada");
            //for (int mult = 1; mult <=10; mult++)
            //{
            //    for (int n = 1; n <= 10; n++)
            //    {
            //        Console.WriteLine(mult + " * " + n + " = " + mult*n);
            //    }
            //    Console.WriteLine();
            //}


            //Escreva um programa em C# que some todos os números de 1 a 100, pulando os múltiplos de 3.
            //for (int numero = 1; numero <= 100; numero++)
            //{
            //    if (numero % 3 ==0)
            //    {
            //        Console.WriteLine();
            //    } else
            //    {
            //        Console.WriteLine(numero);
            //    }
            //}


            //Escreva um programa em C# que imprime todos os números que são divisíveis por 3 ou por 4 entre 0 e 30.
            //for (int numero = 1; numero <= 30; numero ++)
            //{
            //    while (numero % 3 == 0 || numero % 4 == 0)
            //    {
            //        Console.WriteLine(numero);
            //        break;
            //    }
            //}


            //FATORIAL
            double fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = n * fatorial;
                Console.WriteLine(n + "! = " + fatorial);
            }
        }
    }
}
