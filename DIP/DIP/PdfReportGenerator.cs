using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class PdfReportGenerator : IReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("PDF Report Genrated :-)");
        }
    }
}
