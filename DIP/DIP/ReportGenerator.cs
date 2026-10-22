using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class ReportGenerator
    {
        private IReportGenerator _ReportGenerator;

        public ReportGenerator(IReportGenerator reportGenerator)
        {
            _ReportGenerator = reportGenerator;
        }

        public void GenerateReport()
        {
            _ReportGenerator.Generate();
        }
    }
}
