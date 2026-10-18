using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.PaymentService
{
    public class PayPalPaymentProcessor
    {
        public static void Process(decimal Amount)
        {
            Console.WriteLine($"Processing PayPal payment of {Amount}$");
        }
    }
}
