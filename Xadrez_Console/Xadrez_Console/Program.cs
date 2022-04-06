using System;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var position = new Posicao(4,7);

            Console.Write("Print: " + position);
        }
    }
}
