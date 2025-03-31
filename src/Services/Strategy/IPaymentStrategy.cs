namespace HotelBookingSystem.Services.Strategy
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}