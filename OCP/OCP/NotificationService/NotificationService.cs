using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.NotificationService
{
    
    //before OCP
    public class NotificationService
    {
        public enum enNotificationType { Email, SMS, Fax , Telegram ,Whatsapp }

        public void SendNotification(string To, string Message, enNotificationType NotificationType)
        {
            if (NotificationType == enNotificationType.Email)
            {
                //EmailService.Send(To, Message);
            }
            else if (NotificationType == enNotificationType.SMS)
            {
                //SMSService.Send(To, Message);
            }
            else if (NotificationType == enNotificationType.Fax)
            {
                //FaxService.Send(To, Message);
            }
            else if (NotificationType == enNotificationType.Telegram)
            {
                //TelegramService.Send(To, Message);
            }
            else if (NotificationType == enNotificationType.Whatsapp)
            {
                //WhatsappService.Send(To, Message);
            }

        }
    }
}
