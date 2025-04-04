using System;
using System.Collections.Generic;
using HotelManagementSystem.Data.Repositories;
using HotelManagementSystem.Models;
using HotelManagementSystem.Patterns.Singleton;
using HotelManagementSystem.Services;

namespace HotelManagementSystem.Patterns.Facade
{
    public class BookingFacade
    {
        private readonly BookingService _bookingService;
        private readonly CustomerService _customerService;
        private readonly RoomService _roomService;
        private readonly BookingHistoryRepository _bookingHistoryService;

        public BookingFacade()
        {
            var dbSingleton = DatabaseSingleton.Instance;
            
            var bookingRepository = new BookingRepository(dbSingleton);
            var customerRepository = new CustomerRepository(dbSingleton);
            var roomRepository = new RoomRepository(dbSingleton);
            
            _bookingService = new BookingService(bookingRepository, customerRepository, roomRepository);
            _customerService = new CustomerService(customerRepository);
            _roomService = new RoomService(roomRepository);
        }

        public void MakeBooking(int customerId, int roomId, DateTime startDate, DateTime endDate)
        {
            var customer = _customerService.GetCustomerById(customerId);
            var room = _roomService.GetRoomById(roomId);

            if (customer == null)
            {
                throw new Exception("Customer not found.");
            }

            if (room == null || !room.AvailabilityStatus)
            {
                throw new Exception("Room not available.");
            }

            var booking = new Booking
            {
                Customer_ID = customerId,
                Room_ID = roomId,
                Start_Date = startDate,
                End_Date = endDate,
                Payment_Status = "Pending",
                Total = CalculateTotal(room.Price, startDate, endDate)
            };

            _bookingService.CreateBooking(booking);
        }

        private decimal CalculateTotal(decimal price, DateTime startDate, DateTime endDate)
        {
            var totalDays = (endDate - startDate).Days;
            return totalDays * price;
        }

        public List<BookingHistory> GetBookingHistory(int customerId)
        {
            return _bookingHistoryService.GetBookingHistoryByCustomerID(customerId);
        }
    }
}