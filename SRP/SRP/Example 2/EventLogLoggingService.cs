using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Example_2
{
    public class EventLogLoggingService
    {
        public static void Log(string Message)
        {
            Console.WriteLine($"Log to Event Log: {Message}");
        }
    }
}
