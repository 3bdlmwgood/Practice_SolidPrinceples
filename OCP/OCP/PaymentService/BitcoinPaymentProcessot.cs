using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.PaymentService
{
    public class BitcoinPaymentProcessot
    {
        public static void Process(decimal Amount)
        {
            Console.WriteLine($"Processing Bit Coin payment of {Amount}$");
        }
    }
}
