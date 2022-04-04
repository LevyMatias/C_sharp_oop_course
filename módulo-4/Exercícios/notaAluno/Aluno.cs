using System;
using System.Globalization;

namespace notaAluno
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Trimestre1 { get; set; }
        public double Trimestre2 { get; set; }
        public double Trimestre3 { get; set; }

        public void Condicao(double notaFinal)
        {
            int notaLimite = 100;
            int notaMinima = 60;

            if(notaFinal > notaLimite)
            {
                Console.WriteLine("Esta fora do Limite de 100 pontos!");
            }
            else if(notaFinal >= 60)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram: "+ (notaMinima - notaFinal).ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }
        }
    }
}