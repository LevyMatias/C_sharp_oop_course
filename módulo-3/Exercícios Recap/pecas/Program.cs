/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. */
using System;
using System.Globalization;

namespace pecas
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo_peca1 = int.Parse(Console.ReadLine());
            int qntd_pecas1 = int.Parse(Console.ReadLine());
            double valorPeca1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int codigo_peca2 = int.Parse(Console.ReadLine()); 
            int qntd_pecas2 = int.Parse(Console.ReadLine());
            double valorPeca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorTotal = (valorPeca1 * qntd_pecas1 + valorPeca2 * qntd_pecas2);

            Console.WriteLine("Valor a pagar: {0:C2}",valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
