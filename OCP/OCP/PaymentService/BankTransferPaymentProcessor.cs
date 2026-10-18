using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.PaymentService
{
    public class BankTransferPaymentProcessor: IPaymentProcessor
    {
        public void Process(decimal Amount)
        {
            Console.WriteLine($"Processing Bank Transfer payment of {Amount}$");
        }
    }
}
