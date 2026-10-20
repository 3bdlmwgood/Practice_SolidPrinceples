using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Printer
{
    public class AdvancedPrinter : IPrinter
    {
        public void Print(string Content)
        {
            Console.WriteLine($"Printint: {Content}");
        }

        public void Scan()
        {
            Console.WriteLine("Scaning...");
        }

        public void Fax()
        {
            Console.WriteLine("Faxing...");
        }
    }
}
