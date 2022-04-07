using System;
using tabuleiro;

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
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("-  ");
                    }
                    else
                    {
                        PrintPeca(tab.peca(i, j));
                        Console.Write("  ");
                    }  
                }
                Console.WriteLine();
            }

            //Console.WriteLine("  a b c d e f g h");

            for (char c = 'a'; c <= 'h'; c++)
            {
                Console.Write("  " + c);
            }
        }

        public static void PrintPeca(Peca peca)
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
        }
    }
}
