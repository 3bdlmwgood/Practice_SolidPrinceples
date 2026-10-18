using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class EmailService
    {
        public static void Send(string To, string Message)
        {
            Console.WriteLine($"Sending Email to {To}: {Message}");
        }
    }
}
