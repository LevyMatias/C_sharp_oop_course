namespace ConverterMoeda
{
    public class ConversorMoeda
    {
        public static double Iof = 6.00;
        
        public static double ValorConvertido(double cot, double qntd)
        {
            double total = qntd * cot;
            return total + total * Iof / 100.0;
        }
    }
}