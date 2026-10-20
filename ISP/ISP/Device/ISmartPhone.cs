using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Device
{
    public interface ISmartPhone : ICallDevice, IPhotoDevice, IGPSDevice, IEmailDevice
    {

    }
}
