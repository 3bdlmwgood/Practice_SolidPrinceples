using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Employee : Person
    {
        public virtual void PaySalary()
        {
            Console.WriteLine("Paying Salary to Employee...");
        }

        public override void SendEmail()
        {
            Console.WriteLine("Sending Email to a Employee...");
        }
    }
}
