using System;
using System.Collections.Generic;
using System.Linq;
using HotelManagementSystem.Models;
using HotelManagementSystem.Data.Repositories;

namespace HotelManagementSystem.Services
{
    public class BookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IRoomRepository _roomRepository;
        
        public BookingService(IBookingRepository bookingRepository, ICustomerRepository customerRepository, IRoomRepository roomRepository)
        {
            _bookingRepository = bookingRepository;
            _customerRepository = customerRepository;
            _roomRepository = roomRepository;
        }

        public Booking CreateBooking(int customerId, int roomId, DateTime startDate, DateTime endDate)
        {
            var customer = _customerRepository.GetById(customerId);
            var room = _roomRepository.GetById(roomId);

            if (customer == null || room == null || !room.AvailabilityStatus)
            {
                throw new InvalidOperationException("Invalid booking details.");
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

            _bookingRepository.Add(booking);
            return booking;
        }

        public List<Booking> GetAllBookings()
        {
            return _bookingRepository.GetAll();
        }

        public Booking GetBookingById(int bookingId)
        {
            return _bookingRepository.GetById(bookingId);
        }

        public void UpdateBooking(Booking booking)
        {
            _bookingRepository.Update(booking);
        }

        public void DeleteBooking(int bookingId)
        {
            _bookingRepository.Delete(bookingId);
        }

        private decimal CalculateTotal(decimal price, DateTime startDate, DateTime endDate)
        {
            var totalDays = (endDate - startDate).Days;
            return price * totalDays;
        }
                // Add this method to support creating from a Booking object
        public Booking CreateBooking(Booking booking)
        {
            var customer = _customerRepository.GetById(booking.Customer_ID);
            var room = _roomRepository.GetById(booking.Room_ID);
        
            if (customer == null || room == null || !room.AvailabilityStatus)
            {
                throw new InvalidOperationException("Invalid booking details.");
            }
        
            // If total isn't set, calculate it
            if (booking.Total == 0)
            {
                booking.Total = CalculateTotal(room.Price, booking.Start_Date, booking.End_Date);
            }
        
            // Set default payment status if not set
            if (string.IsNullOrEmpty(booking.Payment_Status))
            {
                booking.Payment_Status = "Pending";
            }
        
            _bookingRepository.Add(booking);
            return booking;
        }
        
        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetById(id);
        }
    }
}