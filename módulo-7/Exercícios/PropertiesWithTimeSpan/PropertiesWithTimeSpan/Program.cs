// Propriedades com timespan
using System;

namespace PropertiesWithTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t = new TimeSpan(3, 4, 5, 7, 12);

            Console.WriteLine(t);
            Console.WriteLine();

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine();

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            // Usando métodos de operacões aritméticas em TimeSpan

            TimeSpan t1 = new TimeSpan(1, 20, 10);
            TimeSpan t2 = new TimeSpan(0, 12, 4);

            TimeSpan soma = t1.Add(t2); // soma do t1 e do t2
            TimeSpan dif = t1.Subtract(t2); // subtrai o valor de t1 pelo t2
            TimeSpan mult = t2.Multiply(3.0); // multiplica o valor de t2
            TimeSpan div = t2.Divide(2.0); // divide o valor de t2

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(soma);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

        }
    }
}
