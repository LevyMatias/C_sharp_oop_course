/* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.*/
using System;

namespace PositivoOuNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n < 0)
                Console.WriteLine("Numero Negativo!");
            else            
                Console.WriteLine("Numero Positivo!");
        }
    }
}
