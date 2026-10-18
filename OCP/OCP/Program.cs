using OCP.NotificationService;
using SRP.Example_2;
using OCP.PaymentService;

namespace OCP
{
    internal class Program
    {
        
        static void NotificationService()
        {
            NotificationService_OCP notificationEmail = new NotificationService_OCP(new EmailService());
            notificationEmail.SendNotification("abdallah@gmail.com", "Hello Abdallah");

            NotificationService_OCP notificationFax = new NotificationService_OCP(new FaxService());
            notificationFax.SendNotification("123-456-789", "Hello Abdallah");

            NotificationService_OCP notificationSMS = new NotificationService_OCP(new SMSService());
            notificationSMS.SendNotification("01096224620", "Hello Abdallah");

            NotificationService_OCP notificationTelegram = new NotificationService_OCP(new TelegramService());
            notificationTelegram.SendNotification("01096224620", "Hello Abdallah");

            NotificationService_OCP notificationWhatsapp = new NotificationService_OCP(new WhatsappService());
            notificationWhatsapp.SendNotification("01096224620", "Hello Abdallah");
        }

        static void LoggingService()
        {
            LoggingService_OCP loggingServiceDataBase = new LoggingService_OCP(new DatabaseLoggingService());
            loggingServiceDataBase.Log("Error Occured Line 244");

            LoggingService_OCP loggingServiceEventLog = new LoggingService_OCP(new EventLogLoggingService());
            loggingServiceEventLog.Log("Error Occured Line 244");

            LoggingService_OCP loggingServiceFile = new LoggingService_OCP(new FileLoggingService());
            loggingServiceFile.Log("Error Occured Line 244");

        }

        static void PaymentServicce()
        {
            PaymentService.PaymentService paymentBank = new PaymentService.PaymentService(new BankTransferPaymentProcessor());
            paymentBank.ProcessPAyment(2502.5m);

            PaymentService.PaymentService paymentPayPal = new PaymentService.PaymentService(new PayPalPaymentProcessor());
            paymentPayPal.ProcessPAyment(14502.554m);
            
            PaymentService.PaymentService paymentCreditCard = new PaymentService.PaymentService(new CreditCardPaymentProcessor());
            paymentCreditCard.ProcessPAyment(29982.545m);
            
            PaymentService.PaymentService paymentBitCoin = new PaymentService.PaymentService(new BitcoinPaymentProcessot());
            paymentBitCoin.ProcessPAyment(7952.7m);

            PaymentService.PaymentService paymentVodafoneCash = new PaymentService.PaymentService(new VodafoneCashPaymentProcessor());
            paymentVodafoneCash.ProcessPAyment(3252.94m);
        }

        static void Main(string[] args)
        {
            //NotificationService();
            //LoggingService();
            PaymentServicce();
        }
    }
}
