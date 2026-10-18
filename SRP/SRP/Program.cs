using SRP.Example_2;

namespace SRP
{
    internal class Program
    {
        
        static void Ex1()
        {
            NotificationService NotificationService = new NotificationService();

            NotificationService.SendNotification("abdallah@gmail.com", "Welcome to our Service", NotificationService.enNotificationType.Email);
            NotificationService.SendNotification("01096224620", "Your OTP code is 1234", NotificationService.enNotificationType.SMS);
            NotificationService.SendNotification("123-456-789", "Fax Message: Important Document", NotificationService.enNotificationType.Fax);

            Console.WriteLine("-----------------------------------------------------------");

            NewNotificationService NewNotificationService = new NewNotificationService();

            NewNotificationService.SendNotification("abdallah@gmail.com", "Welcome to our Service", NewNotificationService.enNotificationType.Email);
            NewNotificationService.SendNotification("01096224620", "Your OTP code is 1234", NewNotificationService.enNotificationType.SMS);
            NewNotificationService.SendNotification("123-456-789", "Fax Message: Important Document", NewNotificationService.enNotificationType.Fax);
        }

        static void Ex2()
        {
            LoggingService loggingService = new LoggingService();

            loggingService.Log("Error Occured in Line 244", LoggingService.enLoggingType.ToFile);
            loggingService.Log("Error Occured in Line 244", LoggingService.enLoggingType.ToEventLog);
            loggingService.Log("Error Occured in Line 244", LoggingService.enLoggingType.ToDatabase);

            Console.WriteLine("-------------------------------------------");

            NewLoggingService NewloggingService = new NewLoggingService();

            NewloggingService.Log("Error Occured in Line 244", NewLoggingService.enLoggingType.ToFile);
            NewloggingService.Log("Error Occured in Line 244", NewLoggingService.enLoggingType.ToEventLog);
            NewloggingService.Log("Error Occured in Line 244", NewLoggingService.enLoggingType.ToDatabase);
        }

        static void Main(string[] args)
        {
            //Ex1();
            Ex2();
        }
    }
}
