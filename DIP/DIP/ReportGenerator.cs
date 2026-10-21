using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class ReportGenerator
    {
        private PdfReportGenerator _pdfReportGenerator;

        public ReportGenerator()
        {
            _pdfReportGenerator = new PdfReportGenerator();
        }

        public void GenerateReport()
        {
            _pdfReportGenerator.Generate();
        }
    }
}
