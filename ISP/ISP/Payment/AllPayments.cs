using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Payment
{
    public class AllPayments : IPayPalPayment, ICreditCardPayment, IBitCoinPayment
    {
        public void PayWithBitcoin()
        {
            Console.WriteLine("Payment with BitCoin.");
        }

        public void PayWithCreditCard()
        {
            Console.WriteLine("Payment with Credit Card.");
        }

        public void PayWithPayPal()
        {
            Console.WriteLine("Payment with PayPal.");
        }
    }
}
