using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting Engine...");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
}
