using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Payment
{
    public class CreditCardPayment : ICreditCardPayment
    {

        public void PayWithCreditCard()
        {
            Console.WriteLine("Payment with Credit Card.");
        }

        //public void PayWithBitcoin()
        //{
        //    throw new NotImplementedException();
        //}

        //public void PayWithPayPal()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
