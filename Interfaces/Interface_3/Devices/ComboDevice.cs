using System;

namespace Interface_3.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Combo device processing: " + text);
        }

        public override void ProcessDoc(string text)
        {
            Console.WriteLine("Combo Device print: " + text);
        }

        public string Scan()
        {
            return "Combo device scan result!";
        }
    }
}
