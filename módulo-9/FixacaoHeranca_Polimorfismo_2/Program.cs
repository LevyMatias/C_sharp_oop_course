using FixacaoHeranca_Polimorfismo_2.Entities;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;

namespace FixacaoHeranca_Polimorfismo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            WriteLine("Enter the number of tax payers: ");
            byte n = byte.Parse(ReadLine());

            for (byte i = 1; i <= n; i++)
            {
                WriteLine($"Tax payer #{i} data:");
                Write("Individual or company (i/c)? ");
                char ic = char.Parse(ReadLine());

                Write("Name: ");
                string name = ReadLine();

                Write("Anual income: ");
                float anualIncome = float.Parse(ReadLine(), CultureInfo.InvariantCulture);

                if (ic == 'i')
                {
                    Write("Health expenditures: ");
                    float healthExpediture = float.Parse(ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new Individual(healthExpediture, name, anualIncome));
                }
                else
                {
                    Write("Number of employees: ");
                    byte emp = byte.Parse(ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Company(emp, name, anualIncome));
                }
            }

            float sum = 0.00f;
            WriteLine();
            WriteLine("TAXES PAID: ");

            foreach (var taxes in list)
            {
                float totalTax = taxes.Tax();
                WriteLine(taxes.Print());
                WriteLine();
                sum += totalTax;
            }

            WriteLine("Total taxes: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
