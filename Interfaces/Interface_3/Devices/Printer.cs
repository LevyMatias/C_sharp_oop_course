using System;

namespace Interface_3.Devices
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string text)
        {
            Console.WriteLine("Printer processing: " + text);
        }

        public void Print(string text)
        {
            Console.WriteLine("Printer print " + text);
        }
    }
}
