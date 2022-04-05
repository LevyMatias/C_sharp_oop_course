using System;
using System.Globalization;

namespace FixacaoHeranca_Polimorfismo.Entities
{
    class Used : Product
    {
        public DateTime ManufactureDate { get; set; }

        public Used(DateTime manufactureDate, string name, double price)
            : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + $" ( Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")} )";
        }
    }
}
