using AulaHeranca_3.Entities;
using System;

namespace AulaHeranca_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sobreposição, palavras chave: base, override, virtual

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new Account(1001, "Joao", 500.0);
            Account acc3 = new SavingAccount(1002, "Anna", 500.0, 0.01);
            Account acc4 = new SavingAccount(1002, "Julia", 840.0, 0.01);

            acc1.Deposit(200); // update deposit
            acc2.Withdraw(10.0); // tem taxa de 5 reais
            acc3.Withdraw(10.0); // tem taxa de 5 reais + 2
            acc4.Withdraw(150.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc3.Balance);
            Console.WriteLine(acc4.Balance);
        }
    }
}
