using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace LSP
{
    public class Eagle : FlyingBird
    {
        public override void Eat()
        {
            Console.WriteLine("Eagle Eating...");
        }

        public override void Fly()
        {
            Console.WriteLine("Eagle Flying...");
        }
    }
}
