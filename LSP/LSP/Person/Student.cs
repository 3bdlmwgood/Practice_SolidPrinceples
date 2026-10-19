using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Student : Person
    {
        //public override void PaySalary()
        //{
        //    throw new InvalidOperationException("Student dont's recieve a Salary.");
        //}

        public override void SendEmail()
        {
            Console.WriteLine("Sending Email to a Student...");
        }
    }
}
