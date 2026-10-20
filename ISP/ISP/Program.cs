using ISP.Printer;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicPrinter BasicPrinter = new BasicPrinter();
            BasicPrinter.Print("Solid Princeples is very Intersting");
            //BasicPrinter.Scan();
            //BasicPrinter.Fax();

            AdvancedPrinter AdvancedPrinter = new AdvancedPrinter();
            AdvancedPrinter.Print("Solid Princeples is very Intersting");
            AdvancedPrinter.Scan();
            AdvancedPrinter.Fax();
            AdvancedPrinter.Copy();


        }
    }
}
