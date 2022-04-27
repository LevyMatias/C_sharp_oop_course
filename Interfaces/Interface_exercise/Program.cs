using Interface_exercise.Entities;
using Interface_exercise.Services;
using System;
using System.Globalization;

namespace Interface_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());
            var contract = new Contract(number, date, value);

            var contractService = new ContractService(new PaymentService());
            contractService.ProcessContract(contract, installments);

            Console.WriteLine("Installments: ");
            foreach (Installment i in contract.Installments)
            {
                Console.WriteLine(i);
            }
        }
    }
}
