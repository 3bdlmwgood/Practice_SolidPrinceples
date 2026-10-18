using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.PaymentService
{
    public class PaymentService
    {
        public enum enPaymentProcessor { PayPal,BankTransfer,Bitcoin,CreditCard}
        
        public void ProcessPayment(decimal Amount,enPaymentProcessor paymentProcessor)
        {
            if(paymentProcessor == enPaymentProcessor.PayPal)
            {
                PayPalPaymentProcessor.Process(Amount);
            }
            else if (paymentProcessor == enPaymentProcessor.BankTransfer)
            {
                BankTransferPaymentProcessor.Process(Amount);
            }
            else if (paymentProcessor == enPaymentProcessor.Bitcoin)
            {
                BitcoinPaymentProcessot.Process(Amount);
            }
            else if (paymentProcessor == enPaymentProcessor.CreditCard)
            {
                CreditCardPaymentProcessor.Process(Amount);
            }

        }
    }
}
