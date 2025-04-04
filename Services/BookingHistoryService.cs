using System;
using System.Collections.Generic;
using HotelManagementSystem.Data.Repositories;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Services
{
    public class BookingHistoryService
    {
        private readonly IBookingHistoryRepository _bookingHistoryRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IRoomRepository _roomRepository;

        public BookingHistoryService(
            IBookingHistoryRepository bookingHistoryRepository,
            ICustomerRepository customerRepository,
            IRoomRepository roomRepository)
        {
            _bookingHistoryRepository = bookingHistoryRepository ?? throw new ArgumentNullException(nameof(bookingHistoryRepository));
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
            _roomRepository = roomRepository ?? throw new ArgumentNullException(nameof(roomRepository));
        }

        public IEnumerable<BookingHistory> GetAllBookingHistory()
        {
            return _bookingHistoryRepository.GetAll();
        }

        public IEnumerable<BookingHistory> GetBookingHistoryByCustomerName(string customerName)
        {
            return _bookingHistoryRepository.GetByCustomer(customerName);
        }

        public IEnumerable<BookingHistory> GetBookingHistoryByPaymentStatus(string paymentStatus)
        {
            return _bookingHistoryRepository.GetByPaymentStatus(paymentStatus);
        }

        public IEnumerable<BookingHistory> GetBookingHistoryByDateRange(DateTime startDate, DateTime endDate)
        {
            return _bookingHistoryRepository.GetByDateRange(startDate, endDate);
        }

        public IEnumerable<BookingHistory> GetBookingHistoryByRoomId(int roomId)
        {
            return _bookingHistoryRepository.GetByRoomId(roomId);
        }

        public int GetTotalBookingCount()
        {
            return _bookingHistoryRepository.GetTotalBookingCount();
        }

        public int GetPaidBookingsCount()
        {
            return _bookingHistoryRepository.GetPaidBookingsCount();
        }

        public decimal GetPaidBookingsPercentage()
        {
            int total = GetTotalBookingCount();
            if (total == 0) return 0;
            
            int paid = GetPaidBookingsCount();
            return (decimal)paid / total * 100;
        }

        public BookingHistory CreateBookingHistoryFromBooking(Booking booking)
        {
            if (booking == null)
            {
                throw new ArgumentNullException(nameof(booking));
            }

            var customer = _customerRepository.GetById(booking.Customer_ID);
            string customerName = customer != null ? customer.Name : "Unknown";

            return new BookingHistory
            {
                Booking_ID = booking.Booking_ID,
                Customer = customerName,
                Room_ID = booking.Room_ID,
                Start_Date = booking.Start_Date,
                End_Date = booking.End_Date,
                Payment_Status = booking.Payment_Status
            };
        }
    }
}