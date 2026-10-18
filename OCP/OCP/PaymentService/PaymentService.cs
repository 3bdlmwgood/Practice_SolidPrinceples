using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.PaymentService
{
    public class PaymentService
    {
        private IPaymentProcessor _paymentProcessor;

        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void ProcessPAyment(decimal Amount)
        {
            _paymentProcessor.Process(Amount);
        }
    }
}
