using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Manager : Employee
    {
        public override void PaySalary()
        {
            Console.WriteLine("Paying Salary to Manager...");
        }

        public override void SendEmail()
        {
            Console.WriteLine("Sending Email to a Manger...");
        }
    }
}
