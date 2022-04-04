/* escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar.*/
using System;

namespace compras
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] codigo = Console.ReadLine().Split(' ');
            int item = int.Parse(codigo[0]);
            int qntd = int.Parse(codigo[1]);

            double preco1 = 4.00, preco2 = 4.50, preco3 = 5.00;

           if(item == 1)
           {
               double total = qntd * preco1;
               Console.WriteLine("Total: {0:C}",total);
           }
           else if(item == 2)
           {
               double total = qntd * preco2;
                Console.WriteLine("Total: {0:C}",total);
           }
           else if(item == 3)
           {
               double total = qntd * preco3;
                Console.WriteLine("Total: {0:C}",total);
           }
        }
    }
}
