using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car Engine Started...");
        }

        public override void Drive()
        {
            Console.WriteLine("Car is Driving...");
        }
    }
}
