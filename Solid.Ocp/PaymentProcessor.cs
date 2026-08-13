using System;

// This code violates the Open/Closed Principle (OCP) because the PaymentProcessor class is not closed for modification.
// If we want to add support for a new payment type, we would have to modify the ProcessPayment method, which is not ideal.
// Instead, we can refactor the code to use polymorphism and create separate classes for each payment type.
namespace Solid.Ocp
{
    public class PaymentProcessor
    {
        public void ProcessPayment(string paymentType, decimal amount)
        {
            if (paymentType == "CreditCard")
            {
                // Process credit card payment
                Console.WriteLine($"Processing credit card payment of {amount:C}");
            }
            else if (paymentType == "PayPal")
            {
                // Process PayPal payment
                Console.WriteLine($"Processing PayPal payment of {amount:C}");
            }
            else
            {
                throw new NotSupportedException($"Payment type '{paymentType}' is not supported.");
            }
        }   
    }
}
