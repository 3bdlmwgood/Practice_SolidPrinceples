using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Payment
{
    public class PayPalPayment : IPayPalPayment
    {
        public void PayWithPayPal()
        {
            Console.WriteLine("Payment with PayPal.");
        }

        //public void PayWithBitcoin()
        //{
        //    throw new NotImplementedException();
        //}

        //public void PayWithCreditCard()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
