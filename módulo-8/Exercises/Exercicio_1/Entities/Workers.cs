using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    class Workers 
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Workers(WorkerLevel level, string name, double salary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = salary;
            Department = department;
        }
       public enum WorkerLevel : int
        {
            Junior = 1,
            Pleno = 2,
            Senior = 3
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double s = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    s += contract.TotalValue();
                }
            }
            return s;

        }
    }
}
