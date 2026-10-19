using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Bicycle : Vehicle
    {
        public override void StartEngine()
        {
            throw new NotSupportedException("Bicycles don't have Engine Started...");
        }

        public override void Drive()
        {
            Console.WriteLine("Bicycle is Riding...");
        }
    }
}
