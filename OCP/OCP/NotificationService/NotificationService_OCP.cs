using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.NotificationService
{
    public class NotificationService_OCP
    {
        private INotification _Notification;

        public NotificationService_OCP(INotification Notification)
        {
            _Notification = Notification;
        }

        public void SendNotification(string To, string Message)
        {
            _Notification.Send(To, Message);
        }

    }        
}
