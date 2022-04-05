using System.Globalization;

namespace FixacaoHeranca_Polimorfismo_2.Entities
{
    class Individual : TaxPayer
    {
        public float HealthExpediture { get; set; }

        public Individual(float healthExpediture, string name, float anualIncome)
            : base (name, anualIncome)
        {
            HealthExpediture = healthExpediture;
        }

        public override float Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15f - HealthExpediture * 0.50f;
            }
            else 
            {
                return AnualIncome * 0.25f - HealthExpediture * 0.50f;
            }
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
 