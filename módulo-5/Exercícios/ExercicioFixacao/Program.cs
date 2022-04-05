using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            Console.WriteLine("Entre com o numero da conta: ");
            conta.NumeroDaConta();

            Console.WriteLine("Entre com o titular da conta: ");
            conta.NomeDoTitular();

            Console.WriteLine("Havera deposito inicial? ( s / n )");
            conta.DepositoInicio();

            Console.WriteLine(conta);

            Console.WriteLine("Entre com o valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(quantia);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine("Entre com valor de saque: ");
            conta.Sacar();

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
        }
    }
}