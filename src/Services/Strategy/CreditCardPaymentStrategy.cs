using System;

namespace HotelBookingSystem.Services.Strategy
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        // Implement the interface method
        public void ProcessPayment(decimal amount)
        {
            // Call the detailed implementation
            ProcessPayment(amount, "", "", "", "");
        }

        // Keep your detailed implementation as a separate method
        public bool ProcessPayment(decimal amount, string cardNumber, string cardHolder, string expiryDate, string cvv)
        {
            // Implement credit card payment processing logic here
            // This is a placeholder for actual payment processing logic
            Console.WriteLine($"Processing credit card payment of {amount:C} for {cardHolder}.");
            return true; // Return true if payment is successful
        }
    }
}