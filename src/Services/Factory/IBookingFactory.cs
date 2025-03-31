using System;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Services.Factory
{
    public interface IBookingFactory
    {
        Booking CreateBooking(int customerId, int roomId, DateTime startDate, DateTime endDate);
    }
}