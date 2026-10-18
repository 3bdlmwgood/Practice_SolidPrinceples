using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class NewNotificationService
    {
        public enum enNotificationType { Email, SMS, Fax }

        public void SendNotification(string To, string Message, enNotificationType NotificationType)
        {
            if (NotificationType == enNotificationType.Email)
            {
                EmailService.Send(To, Message);
            }
            if (NotificationType == enNotificationType.SMS)
            {
                SMSService.Send(To, Message);
            }
            if (NotificationType == enNotificationType.Fax)
            {
                FaxService.Send(To, Message);
            }
        }

    }        
}
