using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Device
{
    public interface IDevice
    {
        void MakeCall();
        void TakePhoto();
        void SendEmail();
        void UseGPS();
    }
}
