using Solid.Ocp_CloseModification.Interfaces;
using System;


namespace Solid.Ocp_CloseModification
{
    public class PaymentProcessor : IPaymentStrategy
    {
        public void Payment(decimal amount)
        {
            // Process payment logic here
            Console.WriteLine($"Kredit karti ile odendi {amount:C}");
        }
    }
}
