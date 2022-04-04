/* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, 
o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e 
o salário do funcionário, com duas casas decimais.*/
using System;
using System.Globalization;

namespace Salario.Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
           int numeroFuncionario = int.Parse(Console.ReadLine());
           decimal horasTrabalhada = decimal.Parse(Console.ReadLine());
           decimal valorPorHoras = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           decimal totalSalario = (horasTrabalhada * valorPorHoras);

           Console.Write("Number = {0}"+"\nSalario = U$ {1}",numeroFuncionario,totalSalario.ToString("F2"));
           
        }
    }
}
