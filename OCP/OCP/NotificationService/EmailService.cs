using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.NotificationService
{
    public class EmailService : INotification
    {
        public void Send(string To, string Message)
        {
            Console.WriteLine($"Sending Email to {To}: {Message}");
        }
    }
}
