using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.PaymentService
{
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void Process(decimal Amount)
        {
            Console.WriteLine($"Processing PayPal payment of {Amount}$");
        }
    }
}