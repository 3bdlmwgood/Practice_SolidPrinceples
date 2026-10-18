using OCP.LoggingService;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Example_2
{
    public class LoggingService_OCP
    {
        private ILogging _logging;

        public LoggingService_OCP(ILogging LoggingService)
        {
            _logging = LoggingService;
        }

        public void Log(string Message)
        {
            _logging.Log(Message);
        }
    }
}
