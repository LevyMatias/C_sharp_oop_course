using System;
using System.Globalization;
using Exception_2.Entities.Exceptions;
namespace Exception_2.Entities
{
    class BankAccount
    {
        public int Numero { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public BankAccount(int numero, string holder, double balance, double withdrawLimit)
        {
            Numero = numero;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit ()
        {
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's')
            {
                Console.Write("Enter deposit amount: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Thanks for use our services!");
            }
            
            
        }
        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            else if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return Balance.ToString("F2",CultureInfo.InvariantCulture);
           
        }
    }
}
