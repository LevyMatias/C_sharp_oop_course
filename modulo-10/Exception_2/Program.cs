using Exception_2.Entities;
using Exception_2.Entities.Exceptions;
using System;
using System.Globalization;
using static System.Console;

namespace Exception_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Enter account data ");
                Write("Number: ");
                int number = int.Parse(ReadLine());

                Write("Holder: ");
                string name = ReadLine();

                Write("Initial balance: ");
                double balance = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                Write("Withdraw limit: ");
                double wdLimit = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                WriteLine();

                Write("Enter amount for Withdraw: ");
                double amountWithdraw = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                var bankAccount = new BankAccount(number, name, balance, wdLimit);

                bankAccount.Withdraw(amountWithdraw);

                Write("Enter deposit? (s/n) ");

                bankAccount.Deposit();
                WriteLine();

                Write("New balance: " + bankAccount);
                WriteLine();
            }
            catch (FormatException e)
            {
                WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                WriteLine("Withdraw error: " + e.Message);
            }

        }
    }
}
