/* Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.*/
using System;
using System.Globalization;

namespace ClassFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1 = new Funcionario();
            Funcionario F2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            
            Console.Write("Nome: ");
            F1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            F1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            
            Console.Write("Nome: ");
            F2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            F2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (F1.Salary + F2.Salary) / 2;
            
            
            Console.WriteLine("Media: {0}",media.ToString("C2"));
        }
    }
}
