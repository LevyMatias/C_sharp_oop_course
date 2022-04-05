using AulaHeranca_4.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AulaHeranca_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingAccount(1001, "luis", 400.00, 0.01));
            list.Add(new BusinessAccount(1002, "marcos", 400.0, 300.0));
            list.Add(new SavingAccount(1004, "bruno", 500.0, 0.01));
            list.Add(new BusinessAccount(1005, "joao", 500.0, 300.0));

            double sum = 0.0;
            foreach (Account c in list)
            {
                sum += c.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account c in list)
            {
                c.Withdraw(10.0);
            }
            foreach (Account c in list)
            {
                Console.WriteLine("Updated balance for account "
                    + c.Number
                    + ": "
                    + c.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
