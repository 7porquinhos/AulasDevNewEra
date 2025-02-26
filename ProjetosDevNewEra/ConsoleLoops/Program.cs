using System;
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
                           
                            break;
                        case 2:
                            
                            break;
                        case 3:
                            
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
