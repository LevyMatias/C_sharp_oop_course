using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaHeranca_2.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Saque
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0; // taxa de 5 reais
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
