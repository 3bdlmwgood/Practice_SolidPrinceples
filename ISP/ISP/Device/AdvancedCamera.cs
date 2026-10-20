using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Device
{
    public class AdvancedCamera : IPhotoDevice, IEmailDevice
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending Email.");
        }

        public void TakePhoto()
        {
           Console.WriteLine("Taking Photo.");
        }
    }
}
