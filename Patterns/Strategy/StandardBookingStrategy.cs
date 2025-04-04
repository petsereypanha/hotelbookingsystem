using System;

namespace HotelManagementSystem.Patterns.Strategy
{
    public class StandardBookingStrategy : IBookingStrategy
    {
        public void BookRoom(int customerId, int roomId, DateTime startDate, DateTime endDate)
        {
            // Implementation for standard booking logic
            // This could include checking room availability, creating a booking record, etc.
        }
    }
}