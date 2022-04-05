// Aula sobre TimeSpan que calcula a duracao em forma de ticks
using System;

namespace TimeSpanExemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TimeSpan exemplos
            TimeSpan e1 = new TimeSpan(0, 2, 45,15);
            Console.WriteLine(e1);
            Console.WriteLine(e1.Ticks);

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(99150000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 12, 45);
            TimeSpan t5 = new TimeSpan(1, 2, 12, 45, 571);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine();
            Console.WriteLine("Métodos From: ");
            Console.WriteLine();

            // TimeSpan com métodos From
            TimeSpan t6 = TimeSpan.FromDays(2.45);
            TimeSpan t7 = TimeSpan.FromHours(2.75);
            TimeSpan t8 = TimeSpan.FromMinutes(10.50);
            TimeSpan t9 = TimeSpan.FromSeconds(320.5000);
            TimeSpan t10 = TimeSpan.FromMilliseconds(8000.760);
            TimeSpan t11= TimeSpan.FromTicks(99110000000L);

            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);

        }
    }
}
