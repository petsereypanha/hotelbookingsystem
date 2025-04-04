using System;
using System.Collections.Generic;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Data.Repositories
{
    public interface IBookingHistoryRepository : IRepository<BookingHistory>
    {
        // Get bookings by customer name
        IEnumerable<BookingHistory> GetByCustomer(string customerName);
        
        // Get bookings by payment status
        IEnumerable<BookingHistory> GetByPaymentStatus(string paymentStatus);
        
        // Get bookings within a date range
        IEnumerable<BookingHistory> GetByDateRange(DateTime startDate, DateTime endDate);
        
        // Get bookings for a specific room
        IEnumerable<BookingHistory> GetByRoomId(int roomId);
        
        // Get total booking count
        int GetTotalBookingCount();
        
        // Get paid bookings count
        int GetPaidBookingsCount();
        public List<BookingHistory> GetBookingHistoryByCustomerID(int customerId);
    }
}