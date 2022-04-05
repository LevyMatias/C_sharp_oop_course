using AulaHeranca.Entities;
using System;

namespace AulaHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var business = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(business.Balance);
        }
    }
}
