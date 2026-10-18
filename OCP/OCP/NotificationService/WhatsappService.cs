using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.NotificationService
{
    public class WhatsappService : INotification
    {
        public void Send(string To, string Message)
        {
            Console.WriteLine($"Sending Whatsapp Message to {To}: {Message}");
        }
    }
}
