using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.PaymentService
{
    public class BitcoinPaymentProcessot : IPaymentProcessor
    {
        public void Process(decimal Amount)
        {
            Console.WriteLine($"Processing Bit Coin payment of {Amount}$");
        }
    }
}
