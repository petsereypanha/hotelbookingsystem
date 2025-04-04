using System;
using HotelManagementSystem.Models;
using HotelManagementSystem.Services;

namespace HotelManagementSystem.Patterns.Command
{
    public class BookingCommand : ICommand
    {
        private readonly BookingService _bookingService;
        private readonly Booking _booking;

        public BookingCommand(BookingService bookingService, Booking booking)
        {
            _bookingService = bookingService;
            _booking = booking;
        }

        public void Execute()
        {
            _bookingService.CreateBooking(_booking);
        }
         public void Undo()
        {
            // Implement logic to undo the booking
            if (_booking.Booking_ID > 0)
            {
                _bookingService.DeleteBooking(_booking.Booking_ID);
            }
        }
    }
}