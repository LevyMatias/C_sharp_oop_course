using System;
using System.Globalization;

namespace FixacaoHeranca_Polimorfismo.Entities
{
    class Imported : Product
    {
        public double CustomFee { get; set; }

        public Imported(double customFee, string name, double price) 
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return Name + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + $"(Custom fee: $ {CustomFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}
