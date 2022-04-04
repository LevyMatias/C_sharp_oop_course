/*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/

using System;

namespace planoCartesianoXeY
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else
                {
                    Console.WriteLine("Quarto Quadrante");
                }

                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
            }
        }
    }
}
