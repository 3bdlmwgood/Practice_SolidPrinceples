using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Device
{
    public class SmartPhone : IDevice
    {
        public void MakeCall()
        {
            Console.WriteLine("Making a call.");
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending Email.");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Taking Photo.");
        }

        public void UseGPS()
        {
            Console.WriteLine("Using GPS.");
        }
    }
}
