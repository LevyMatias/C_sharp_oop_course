using System;
using System.Globalization;

namespace ExercicioFixacao
{
    public class ContaBancaria
    {
        public int NumeroConta{get; private set;}
        public string NomeTitular { get; set; }
        public double Saldo {get; private set;}

        public ContaBancaria()
        {
        }
        public ContaBancaria(int numero, string titular) {
            NumeroConta = numero;
            NomeTitular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicio) : this(numero, titular) {
            Depositar(depositoInicio);
        }

        // métodos

        public void NumeroDaConta()
        {
            int numero = int.Parse(Console.ReadLine());
            NumeroConta = numero;
        }
        public void NomeDoTitular()
        {
            string titular = Console.ReadLine();
            NomeTitular = titular;
        }
        public void DepositoInicio()
        {
            char letra = char.Parse(Console.ReadLine());
            if(letra == 's' || letra == 'S')
            {
                Console.WriteLine("Entre com o valor do deposito inicial: ");
                double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Saldo += quantidade;
            }
            else
            {
                Saldo = 0.00;
            }   
        }

        public void Depositar(double quantidade)
        {
            Saldo += quantidade;
        }
        public void Sacar()
        {
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Saldo -= quantidade + 5.00;
        }



        public override string ToString()
        {
            return "Conta: " + NumeroConta
            + ", Titular: "
            + NomeTitular
            + ", "
            + "$ "
            + Saldo;
        }
    }
}