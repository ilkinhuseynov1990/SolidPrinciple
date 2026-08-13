using Solid.Ocp_CloseModification.Interfaces;
using System;

namespace Solid.Ocp_CloseModification
{
    public class PaypalPayment : IPaymentStrategy
    {
        public void Payment(decimal amount)
        {
            // Process payment logic here
            Console.WriteLine($"Paypal ile odendi {amount:C}");
        }
    }
}
