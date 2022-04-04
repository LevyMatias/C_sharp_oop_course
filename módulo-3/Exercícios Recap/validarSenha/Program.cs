/*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002*/

using System;

namespace validarSenha
{
    class Program
    {
        static void Main(string[] args)
        {

            int senha = 0;
            while (senha != 2002)
            {
                senha = int.Parse(Console.ReadLine());
                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido!");
                }
                else
                {
                    Console.WriteLine("Acesso Negado!");
                }
            }

            OutraForma();

        }

        static void OutraForma()
        {
            Console.WriteLine("Outro Exemplo:");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
