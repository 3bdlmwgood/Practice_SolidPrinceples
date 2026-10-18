using OCP.NotificationService;

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

        static void Main(string[] args)
        {
            NotificationService();
        }
    }
}
