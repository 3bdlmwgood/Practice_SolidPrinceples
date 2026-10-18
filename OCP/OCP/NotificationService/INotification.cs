using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.NotificationService
{
    public interface INotification
    {
        public void Send(string To, string Message);
    }
}
