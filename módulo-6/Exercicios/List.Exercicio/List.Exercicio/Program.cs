using System;
using System.Collections.Generic;
using System.Globalization;

namespace List.Exercicio
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, nome, salario)); // adiciona na lista o id, nome eo salario

            }

            Console.Write("Enter the employee id that will have salary increase :");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId); // Expressao lambda

            if (emp != null)
            {
                Console.WriteLine("Enter the percentage:");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.AumentoSalario(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees:");

            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }


    }
}
