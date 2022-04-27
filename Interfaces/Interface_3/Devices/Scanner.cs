using System;

namespace Interface_3.Devices
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string text)
        {
            Console.WriteLine("Scanner processing: " + text);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
