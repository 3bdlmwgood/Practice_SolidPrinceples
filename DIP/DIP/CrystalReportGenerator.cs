using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class CrystalReportGenerator : IReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Crystal Report Generated :-)"); ;
        }
    }
}
