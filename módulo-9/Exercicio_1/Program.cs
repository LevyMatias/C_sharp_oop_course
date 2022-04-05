using Exercicio_1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Write("Enter the number of employees: ");
            int n = int.Parse(ReadLine());

            for(int i = 1; i < n; i++)
            {
                WriteLine($"Employee #{i} data: ");
                Write("Outsourced? ( y / n ) ");

                string response = ReadLine();

                Write("Name: ");
                string name = ReadLine();

                Write("Hours: ");
                int hours = int.Parse(ReadLine());

                Write("Value per Hours: ");
                double valuePerHour = double.Parse(ReadLine());

                if(response == "y" || response == "Y")
                {
                    Write("Additional charge: ");
                    double additionalCharge = double.Parse(ReadLine());
                    list.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            WriteLine();
            WriteLine("Payments:");
            foreach(Employee employee in list)
            {
                WriteLine(employee.Name + " - $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
