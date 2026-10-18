using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.PaymentService
{
    public interface IPaymentProcessor
    {
        public void Process(decimal Amount);
    }
}
