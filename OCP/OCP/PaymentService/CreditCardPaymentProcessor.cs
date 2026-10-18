using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.PaymentService
{
    public class CreditCardPaymentProcessor
    {
        public static void Process(decimal Amount)
        {
            Console.WriteLine($"Processing Credit Card payment of {Amount}$");
        }
    }
}
