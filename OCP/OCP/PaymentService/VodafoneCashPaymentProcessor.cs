using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.PaymentService
{
    public class VodafoneCashPaymentProcessor : IPaymentProcessor
    {
        public void Process(decimal Amount)
        {
            Console.WriteLine($"Processing Vodafone Cash payment of {Amount}$");
        }
    }
}
