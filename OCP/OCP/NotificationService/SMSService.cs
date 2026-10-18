using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.NotificationService
{
    public class SMSService : INotification
    {
        public void Send(string To, string Message)
        {
            Console.WriteLine($"Sending SMS to {To}: {Message}");
        }
    }
}
