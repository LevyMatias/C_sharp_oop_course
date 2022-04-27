using System;

namespace problemEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var print = new PrintService<int>();
            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());
            for (var i = 0; i<n; i++)
            {
                int values = int.Parse(Console.ReadLine());
                print.AddValue(values); 
            }

            print.Print();
            Console.WriteLine("First: " + print.First());

        }
    }
}
