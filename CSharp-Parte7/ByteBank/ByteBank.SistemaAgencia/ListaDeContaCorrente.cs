﻿using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.SistemaAgencia
{
    // [item][item][item][item][item]
    //                                ^
    //                                 `- _proximaPosicao

    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public int Tamanho 
        { 
            get
            { 
                return _proximaPosicao; 
            } 
        }



        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void MeuMetodo(string texto = "texti padrao", int numero = 5)
        {

        }

        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        // Escrevendo ADICIONAR VARIOS
        public void AdicionarVarios(params ContaCorrente[] itens)
        {
            foreach(ContaCorrente conta in itens)
            {
                Adicionar(conta);
            }
        }


        // Escrevendo método REMOVER
        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for(int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente itemAtual = _itens[i];
                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            // Quero remover 0x02
            // [0x01] [0x02] [0x03] [null]
            //                         ^
            //                          ` _proximaPosicao
            

            for (int i = indiceItem; i < _proximaPosicao-1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }


        public void EscreverListaNaTela()
        {
            for(int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente conta = _itens[i];
                Console.WriteLine($"Conta no índice {i}: agência: {conta.Agencia}, numero: {conta.Numero}");
            }
        }


        public ContaCorrente GetItemNoIndice(int indice)
        {
            if(indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }


        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            //Console.WriteLine("Aumentando capacidade da lista!");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                //Console.WriteLine(".");
            }

            _itens = novoArray;
        }

        // Criando INDEXADOR

        public ContaCorrente this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }

    }
}
