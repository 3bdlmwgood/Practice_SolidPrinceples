namespace DIP
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            ReportGenerator PdfReportGenerator = new ReportGenerator(new PdfReportGenerator());
            PdfReportGenerator.GenerateReport();

            ReportGenerator ExcelReportGenerator = new ReportGenerator(new ExcelReportGenerator());
            ExcelReportGenerator.GenerateReport();
            
            ReportGenerator WordReportGenerator = new ReportGenerator(new WordReportGenerator());
            WordReportGenerator.GenerateReport();
            
            ReportGenerator CrystalReportGenerator = new ReportGenerator(new CrystalReportGenerator());
            CrystalReportGenerator.GenerateReport();

        }
    }
}
