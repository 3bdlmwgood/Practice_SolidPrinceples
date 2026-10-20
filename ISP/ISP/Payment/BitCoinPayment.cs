using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Payment
{
    public class BitCoinPayment : IBitCoinPayment
    {
        public void PayWithBitcoin()
        {
            Console.WriteLine("Payment with BitCoin.");
        }
    }
}
