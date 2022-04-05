using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Exercicio
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Employee(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public double AumentoSalario(double percentage)
        {
           
            return Salario = Salario + (Salario * percentage / 100);
        }

        public override string ToString() 
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2");
        }
    }
}
