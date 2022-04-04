/* Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
este problema*/
using System;
using System.Globalization;

namespace notaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno nota = new Aluno();

            nota.Trimestre1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota.Trimestre2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota.Trimestre3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double notaFinal = nota.Trimestre1 + nota.Trimestre2 + nota.Trimestre3;

            Console.WriteLine("Nota Final: "+notaFinal.ToString("F2", CultureInfo.InvariantCulture));

            nota.Condicao(notaFinal);
        }
    }
}
