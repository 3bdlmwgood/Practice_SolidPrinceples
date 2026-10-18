using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Example_2
{
    public class NewLoggingService
    {
        public enum enLoggingType { ToFile, ToEventLog, ToDatabase }

        public void Log(string Message, enLoggingType LoggingType)
        {
            if (LoggingType == enLoggingType.ToFile)
            {
                FileLoggingService.Log(Message);
            }

            else if (LoggingType == enLoggingType.ToEventLog)
            {
                EventLogLoggingService.Log(Message);
            }

            else if (LoggingType == enLoggingType.ToDatabase)
            {
                DatabaseLoggingService.Log(Message);
            }
        }
    }
}
