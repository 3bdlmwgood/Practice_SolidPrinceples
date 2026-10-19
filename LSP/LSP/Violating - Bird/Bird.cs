using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
}
