using System;
using System.Globalization;

namespace Interface_exercise.Entities
{
    class Installment
    {
        public DateTime DuoDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime duoDate, double amount)
        {
            DuoDate = duoDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DuoDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
