using System.Globalization;

namespace FixacaoHeranca_Polimorfismo_2.Entities
{
    class Company : TaxPayer
    {
        public byte NumberEmployees { get; set; }

        public Company(byte numberEmployees, string name, float anualIncome)
            : base (name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override float Tax()
        {
            if (NumberEmployees > 10)
            {
                return AnualIncome * 0.14f;
            }

            return AnualIncome * 0.16f;
        }

        public override string Print()
        {
            return Name
                 + ": $"
                 + " "
                 + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
