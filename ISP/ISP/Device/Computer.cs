using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Device
{
    internal class Computer : IDevice
    {
        public void MakeCall()
        {
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending Email.");
        }

        public void TakePhoto()
        {
            throw new NotImplementedException();
        }

        public void UseGPS()
        {
            throw new NotImplementedException();
        }
    }
}
