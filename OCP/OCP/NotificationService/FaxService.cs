using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.NotificationService
{
    public class FaxService : INotification
    {
        public void Send(string To, string Message)
        {
            Console.WriteLine($"Sending Fax to {To}: {Message}");
        }
    }
}
