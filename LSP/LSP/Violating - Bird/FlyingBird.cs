using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class FlyingBird : Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
}
