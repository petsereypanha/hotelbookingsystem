using System;

namespace HotelManagementSystem.Patterns.Strategy
{
    public interface IBookingStrategy
    {
        void BookRoom(int customerId, int roomId, DateTime startDate, DateTime endDate);
    }
}