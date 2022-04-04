/* Fazer um programa para ler os dados de um funcionário (nome,
salário bruto e imposto). Em seguida, mostrar os dados do
funcionário (nome e salário líquido). Em seguida, aumentar o salário
do funcionário com base em uma porcentagem dada (somente o
salário bruto é afetado pela porcentagem) e mostrar novamente os
dados do funcionário. Use a classe projetada abaixo.*/
using System;
using System.Globalization;

namespace dadosFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario dados = new Funcionario();
		
	  Console.Write("Nome: ");
            dados.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            dados.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            dados.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.SalarioLiquido();

	   Console.WriteLine();
            Console.WriteLine("Funcionario: "+ dados);

            Console.WriteLine("Digite a porcentagem para o aumento do salario: ");
            double porcent = double.Parse(Console.ReadLine());
            dados.AumentarSalario(porcent);

            Console.WriteLine("Funcionario dados atualizados: "+ dados);

        }
    }
}
