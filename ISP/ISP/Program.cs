using ISP.Device;
using ISP.Payment;
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

            Console.WriteLine("-----------------------------------");

            CreditCardPayment CreditCardPayment = new CreditCardPayment();
            CreditCardPayment.PayWithCreditCard();
            //CreditCardPayment.PayWithPayPal();
            //CreditCardPayment.PayWithBitcoin();
            
            PayPalPayment PayPalPayment = new PayPalPayment();
            PayPalPayment.PayWithPayPal();
            //PayPalPayment.PayWithCreditCard();
            //PayPalPayment.PayWithBitcoin();

            BitCoinPayment BitCoinPayment = new BitCoinPayment();
            BitCoinPayment.PayWithBitcoin();

            AllPayments AllPayments = new AllPayments();
            AllPayments.PayWithCreditCard();
            AllPayments.PayWithPayPal();
            AllPayments.PayWithBitcoin();

            Console.WriteLine("-----------------------------------");

            SmartPhone SmartPhone = new SmartPhone();
            SmartPhone.SendEmail();
            SmartPhone.TakePhoto();
            SmartPhone.MakeCall();
            SmartPhone.UseGPS();

            Computer Computer = new Computer();
            Computer.SendEmail();
            //Computer.TakePhoto();
            //Computer.MakeCall();
            //Computer.UseGPS();

            Camera Camera = new Camera();
            Camera.TakePhoto();

            AdvancedCamera AdvancedCamera= new AdvancedCamera();
            AdvancedCamera.TakePhoto();
            AdvancedCamera.SendEmail();
        }
    }
}
