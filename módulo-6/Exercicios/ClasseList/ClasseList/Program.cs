using System;
using System.Collections.Generic;

namespace ClasseList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Marcos");  
            list.Add("Julia");  
            list.Add("Nicolas");  
            list.Add("Joao");
            list.Insert(0, "Levy");

            foreach (string s in list) 
            { 
                Console.WriteLine(s); 
            }    
            Console.WriteLine("List count: "+ list.Count);

            string s1 = list.Find(x => x[0] == 'L');
            Console.WriteLine("First 'A': "+s1);

            string s2 = list.FindLast(x => x[0] == 'J');
            Console.WriteLine("Last 'J': "+s2);

            int pos1 = list.FindIndex(x => x[0] == 'J');
            Console.WriteLine("First position 'A':" + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'J');
            Console.WriteLine("Last position 'A':" + pos2);


            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------");

            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }

            list.Remove("Levy");
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
