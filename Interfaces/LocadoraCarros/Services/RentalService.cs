using LocadoraCarros.Entities;
using System;

namespace LocadoraCarros.Services
{
    class RentalService
    {
        public double PricePerDay { get; private set; }
        public double PricePerHour { get; private set; }

        private ITaxService _taxServices;

        public RentalService(double pricePerDay, double pricePerHour, ITaxService taxService)
        {
            PricePerDay = pricePerDay;
            PricePerHour = pricePerHour;
            _taxServices = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0;

            if(duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxServices.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
