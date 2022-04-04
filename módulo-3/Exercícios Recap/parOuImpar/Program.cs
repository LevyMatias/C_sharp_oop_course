/* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.*/
using System;

namespace parOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");
        }
    }
}
