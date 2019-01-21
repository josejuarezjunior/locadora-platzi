﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraPlatzi
{
    struct Filme
    {
        public string nome;
        public int anoLancamento;
        public string genero;
        public float avaliacao;
        public int quantidade;
        public bool lancamento;
    }

    class Program
    {
        public static Filme unicoFilme;

        static void Main(string[] args)
        {
            unicoFilme = new Filme();
            unicoFilme.nome = "Matrix";
            unicoFilme.anoLancamento = 1999;
            unicoFilme.genero = "Ação";
            unicoFilme.avaliacao = 9.5f;
            unicoFilme.quantidade = 5;
            unicoFilme.lancamento = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo à locadora de filmes Platzi!");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Listar todos os filmes");
                Console.WriteLine("2 - Sair");
                Console.WriteLine("\n");

                int escolha = 0;
                Int32.TryParse(Console.ReadLine(), out escolha);
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Listar todos os filmes");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Obrigado por nos visitar!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
