using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dic = new Dictionary<string,int>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int voto = int.Parse(line[1]);

                        if (dic.ContainsKey(name))
                        {
                            dic[name] += voto;
                        }
                        else
                        {
                            dic[name] = voto;
                        }
                    }
                }

                foreach (var item in dic)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
