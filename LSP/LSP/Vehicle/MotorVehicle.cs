using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class MotorVehicle : Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting Engine...");
        }
    }
}
