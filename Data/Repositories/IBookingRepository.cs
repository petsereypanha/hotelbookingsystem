using System.Collections.Generic;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Data.Repositories
{
    public interface IBookingRepository : IRepository<Booking>
    {
        // Add any booking-specific repository methods here
        IEnumerable<Booking> GetBookingsByCustomerId(int customerId);
        IEnumerable<Booking> GetBookingsByRoomId(int roomId);
        new List<Booking> GetAll();
    }
}