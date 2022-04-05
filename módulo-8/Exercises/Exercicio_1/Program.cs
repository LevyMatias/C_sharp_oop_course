using Exercicio1.Entities;
using System;
using static System.Console; /* Simplificando o uso do Console.Writeline e Console.ReadLine com a Classe
                                 static System.Console, omitindo a repeticao do "Console. */
using static Exercicio1.Entities.Workers;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter department's name: ");
            string dPname = ReadLine();
            WriteLine();

            Write("Enter worker name: ");
            string name = ReadLine();
            WriteLine();

            Write("Enter Level: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(ReadLine());
            WriteLine();

            Write("Enter Base Salary: ");
            double baseSalary = double.Parse(ReadLine());
            WriteLine();

            var department = new Department(dPname);
            var worker = new Workers(level, name, baseSalary, department);


            Write("How many contracts to this worker?");
            int n = int.Parse(ReadLine());
            WriteLine();

            for (int i = 0; i < n; i++)
            {
                WriteLine($"Enter #{i} contract data");
                WriteLine();

                Write("(DD/MM/YYYY) -> Date:  ");
                DateTime dt = DateTime.Parse(ReadLine());
                WriteLine();

                Write("Salary per Hour: ");
                double valuePerHr= double.Parse(ReadLine());
                WriteLine();

                Write("Duration (hours): ");
                int hrs = int.Parse(ReadLine());

                var contract = new HourContract(dt, valuePerHr, hrs);
                worker.AddContract(contract);
            }

            WriteLine();
            Write("Enter month and year to calculate income (MM/YYYY): ");
            WriteLine();

            string monthAndYear = ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            WriteLine("Name : " + worker.Name);
            WriteLine("Department: " + worker.Department.Name);
            WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));

        }
    }
}
