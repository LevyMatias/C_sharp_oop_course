﻿using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Rei(Color.Branca, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Color.Branca, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Torre(Color.Branca, tab), new Posicao(0, 2));

                Tela.PrintTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
