using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Printer
{
    public class BasicPrinter : IPrint 
    {
        public void Print(string Content)
        {
            Console.WriteLine($"Printint: {Content}");
        }

        //public void Scan()
        //{
        //    throw new NotSupportedException();
        //}

        //public void Fax()
        //{
        //    throw new NotSupportedException();
        //}

    }
}
