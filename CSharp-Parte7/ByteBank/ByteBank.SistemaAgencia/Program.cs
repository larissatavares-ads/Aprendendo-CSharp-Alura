﻿using System;
using ByteBank.Funcionarios;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(1, 3, 5, 93);


            int idadeSoma = 0;
            for(int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }



            Console.WriteLine(SomarVarios(1, 2, 3, 4, 322, 3940));
            Console.WriteLine(SomarVarios(1, 2, 3));

            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.Adicionar("Texto qualquer");
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no índice {i}: {idade}");

            }

           
        }

        static void TestaListaDeContaCorrente()
        {
            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(1111, 11111111);


            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(2222, 22222222),
                new ContaCorrente(874, 5679754),
                new ContaCorrente(874, 5679445),
                new ContaCorrente(874, 5679445)
            };



            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(contaDoGui,
                new ContaCorrente(2222, 22222222),
                new ContaCorrente(874, 5679754),
                new ContaCorrente(874, 5679445),
                new ContaCorrente(874, 5679445));



            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }


            Console.ReadLine();
        }
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaArrayDeContaCorrente()
        {
            // Forma diferente de escrever arrays
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(356, 8956),
                    new ContaCorrente(356, 8957),
                    new ContaCorrente(356, 8958)
                 };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta: {indice}, Número: {contaAtual.Numero}, Agência: {contaAtual.Agencia}");
            }

            // Forma tradicional de escrever arrays
            contas[0] = new ContaCorrente(356, 8956);
            contas[1] = new ContaCorrente(356, 8957);
            contas[2] = new ContaCorrente(356, 8958);
        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!

            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 36;
            idades[2] = 65;
            //idades[3] = 23;
            //idades[4] = 38;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);


            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++) //Lenght usado para não ter que modificar na mão caso o valor do array mude
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }
            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }
    }
}
