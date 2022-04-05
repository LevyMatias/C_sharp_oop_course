namespace FixacaoHeranca_Polimorfismo_2.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public float AnualIncome { get; set; }

        protected TaxPayer(string name, float anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract float Tax();

        public abstract string Print();

    }
}
