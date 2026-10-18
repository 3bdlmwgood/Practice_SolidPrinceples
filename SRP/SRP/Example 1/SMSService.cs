using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class SMSService
    {
        public static void Send(string To, string Message)
        {
            Console.WriteLine($"Sending SMS to {To}: {Message}");
        }
    }
}
