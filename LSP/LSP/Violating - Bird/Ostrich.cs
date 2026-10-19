using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Ostrich : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Ostriches Eating...");
        }

        //public override void Fly()
        //{
        //    throw new NotSupportedException("Ostriches can't fly");
        //}
    }
}
