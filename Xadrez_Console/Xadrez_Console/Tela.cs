using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Tela
    {
        public static void PrintTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    PrintPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }

            //Console.WriteLine("  a b c d e f g h");

            Console.WriteLine();
            for (char c = 'a'; c <= 'h'; c++)
            {
                Console.Write("  " + c);
            }
            Console.WriteLine();
        } 
        
        public static void PrintTabuleiro(Tabuleiro tab, bool[,] lancesPermitidos)
        {
            ConsoleColor original = Console.BackgroundColor;
            ConsoleColor mod = ConsoleColor.Magenta;

            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if(lancesPermitidos[i, j])
                    {
                        Console.BackgroundColor = mod;
                    }
                    else
                    {
                        Console.BackgroundColor = original;
                    }
                    PrintPeca(tab.peca(i, j));
                    Console.BackgroundColor = original;
                }
                Console.WriteLine();
            }

            //Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = original;

            Console.WriteLine();
            for (char c = 'a'; c <= 'h'; c++)
            {
                Console.Write("  " + c);
            }
            Console.WriteLine();

            

        }

        public static NotacaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new NotacaoXadrez(coluna, linha);
        }

        public static void PrintPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("-  ");
            }
            else
            {
                if (peca.Cor == Color.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }

                Console.Write("  ");
            }
        }
    }
}
