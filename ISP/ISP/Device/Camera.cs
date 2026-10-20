using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Device
{
    public class Camera : IPhotoDevice
    {
        public void TakePhoto()
        {
           Console.WriteLine("Taking Photo.");
        }
    }
}
