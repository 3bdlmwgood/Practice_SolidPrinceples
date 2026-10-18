using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class NotificationService
    {
        public enum enNotificationType { Email,SMS,Fax}
        
        public void SendNotification(string To,string Message, enNotificationType NotificationType)
        {
            if (NotificationType == enNotificationType.Email)
                SendEmail(To, Message);
            
            if (NotificationType == enNotificationType.SMS)
                SendSMS(To, Message);
            
            if (NotificationType == enNotificationType.Fax)
                SendFax(To, Message);
        }

        private void SendEmail(string To,string Message) 
        {
            Console.WriteLine($"Sending Email to {To}: {Message}");    
        }
        private void SendSMS(string To,string Message) 
        {
            Console.WriteLine($"Sending SMS to {To}: {Message}");    
        }
        private void SendFax(string To,string Message) 
        {
            Console.WriteLine($"Sending Fax to {To}: {Message}");    
        }
    }
}
