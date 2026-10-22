using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class ExcelReportGenerator : IReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Excel Report Generated :-)");
        }
    }
}
