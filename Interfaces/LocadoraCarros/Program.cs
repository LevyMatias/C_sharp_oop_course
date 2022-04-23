using LocadoraCarros.Entities;
using LocadoraCarros.Services;
using System;
using System.Globalization;

namespace LocadoraCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.Write("Car model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.Write("Enter price per Day: ");
            double priceDay = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            var carRental = new CarRental(start, finish, new Vehicle(model));

            var rentalService = new RentalService(priceDay,priceHour, new BrazilTaxServices());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
