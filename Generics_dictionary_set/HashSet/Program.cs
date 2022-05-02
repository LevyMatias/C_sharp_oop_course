using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Strewberry");
            set.Add("Orange");
            set.Add("Bananas");
            set.Add("Apple");

            Console.WriteLine(set.Contains("Bananas"));

            foreach (String f in set)
            {
                Console.WriteLine(f);
            }
        }
    }
}
