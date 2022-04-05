/* Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). Ao final,
mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados.
Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e
produtos usados possuem data de fabricação.Estes dados específicos devem ser acrescentados na etiqueta de preço */
using FixacaoHeranca_Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;

namespace FixacaoHeranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Write("Enter the number of products:");
            int n = int.Parse(ReadLine());

            for(int i = 1; i <= n; i++)
            {
                WriteLine($"Product #{i} data:");
                WriteLine();

                Write("Common, used or imported? (c / u / i ) ");
                char response = char.Parse(ReadLine());
                WriteLine();

                Write("Name: ");
                string name = ReadLine();

                Write("Price: ");
                double price = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                if(response == 'i')
                {
                    Write("Custom fee: ");
                    double customFee = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Imported(customFee, name, price));
                }
                else if(response == 'u')
                {
                    Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(ReadLine());

                    list.Add(new Used(manufacture, name, price));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            WriteLine();
            foreach(Product p in list)
            {
                WriteLine(p.PriceTag());
            }

        }
    }
}
