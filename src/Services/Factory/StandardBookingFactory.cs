using System;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Services.Factory
{
    public class StandardBookingFactory : IBookingFactory
    {
        public Booking CreateBooking(int customerId, int roomId, DateTime startDate, DateTime endDate)
        {
            return new Booking
            {
                CustomerId = customerId,
                RoomId = roomId,
                StartDate = startDate,
                EndDate = endDate,
                PaymentStatus = "Pending"
            };
        }
    }
}