using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class WordReportGenerator : IReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Word Report Generated :-)");
        }
    }
}
