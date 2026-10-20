using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Payment
{
    public interface IPayment
    {
        void PayWithCreditCard();
        void PayWithPayPal();
        void PayWithBitcoin();
    }
}
