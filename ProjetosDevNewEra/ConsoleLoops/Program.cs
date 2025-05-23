﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis
            string entrada = string.Empty;
            int opcao = 0;
            int resultado = 0;
            int sair = 0;
            #endregion

            Console.WriteLine("===== BEM VINDO A PLATAFORMA DE LOOPS =====\n");

            while (sair == 0)
            {
                Console.WriteLine("Escolha uma das Opções abaixo:\n" +
                "1- Loop While\n" +
                "2- Loop For\n" +
                "3- Loop Foreach\n" +
                "4- Limpar Console\n" +
                "5- Sair da Plataforma de Loops");
                entrada = Console.ReadLine();

                if (int.TryParse(entrada, out resultado))
                {
                    opcao = Convert.ToInt32(entrada);
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Iniciando While, Digite o texto a ser imprimido");
                            string imprimirWhile = Console.ReadLine().ToUpper();
                           int contadorWhile = 1;
                            while (true)
                            {
                                Console.WriteLine($"imprimindo {contadorWhile}: {imprimirWhile}");    
                                

                                contadorWhile++;
                                if (contadorWhile > 10) 
                                {
                                    Console.WriteLine("Deseja sair digite 1, Deseja continuar Digite 0");
                                    int sairWhile = int.Parse(Console.ReadLine());
                                    if (sairWhile == 1)
                                    {
                                        break;
                                    }
                                    else 
                                    {
                                        contadorWhile = 1;
                                    }
                                }
                                
                            }

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nSaindo do While\n");
                            Console.ResetColor();   

                            break;
                        case 2:

                            Console.WriteLine("\nIniciando FOR,Digite o texto a ser imprimido:");
                            string imprimir = Console.ReadLine().ToUpper();
                            Console.WriteLine("\nDigite a quantidade de vezes que deve executar:");
                            int contador = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i <= contador; i++)
                            {
                                Console.WriteLine($"Imprimindo {i}: {imprimir}");
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nSaindo do FOR\n");
                            Console.ResetColor();

                            break;
                        case 3:
                            List<string> listaDeNomes = new List<string>();

                            Console.WriteLine("\nIniciando FOREACH, Digite os nomes a ser imprimidos separados por , \nEX: ELIEL,HUGO,RIANDERSON:");
                            string inputForeach = Console.ReadLine().ToUpper();
                            listaDeNomes.AddRange(inputForeach.Split(','));

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nNomes encontrados na Lista:");
                            Console.ResetColor();
                            foreach (var nome in listaDeNomes)
                            {
                                Console.WriteLine($"Nome: {nome.Trim()}");
                            }

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nSaindo do FOREACH...\n");
                            Console.ResetColor();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("\x1b[3J");
                            Console.WriteLine("===== BEM VINDO A PLATAFORMA DE LOOPS =====\n");
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nSaindo da Plataforma de Loops...");
                            sair = 1;
                            Console.ResetColor();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nOpção Invalida, digite uma das opções a seguir:\n");
                            Console.ResetColor();
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor de entrada invalido, digite uma das opções a seguir:\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
