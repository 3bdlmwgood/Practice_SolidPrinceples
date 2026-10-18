using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class FaxService
    {
        public static void Send(string To, string Message)
        {
            Console.WriteLine($"Sending Fax to {To}: {Message}");
        }
    }
}
