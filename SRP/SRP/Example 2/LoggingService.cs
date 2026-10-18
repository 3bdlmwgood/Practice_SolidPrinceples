using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Example_2
{
    public class LoggingService
    {
        public enum enLoggingType { ToFile, ToEventLog, ToDatabase }

        public void Log(string Message , enLoggingType LoggingType)
        {
            if(LoggingType == enLoggingType.ToFile)
            {
                LogToFile(Message);
            }
            
            else if (LoggingType == enLoggingType.ToEventLog)
            {
                LogToEventLog(Message);
            }

            else if (LoggingType == enLoggingType.ToDatabase)
            {
                LogToDatabase(Message);
            }
        }

        private void LogToFile(string Message) 
            => Console.WriteLine($"Log to File: {Message}"); 
        
        private void LogToEventLog(string Message) 
            => Console.WriteLine($"Log to Event Log: {Message}"); 
        
        private void LogToDatabase(string Message) 
            => Console.WriteLine($"Log to Database: {Message}"); 
    }
}
