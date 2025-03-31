using System;
using System.Collections.Generic;
using System.Linq;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Data.Repository
{
    public class BookingRepository : IRepository<Booking>
    {
        private readonly DatabaseContext _context;

        public BookingRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Add(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        public void Update(Booking booking)
        {
            var existingBooking = _context.Bookings.Find(booking.BookingId);
            if (existingBooking != null)
            {
                existingBooking.CustomerId = booking.CustomerId;
                existingBooking.RoomId = booking.RoomId;
                existingBooking.StartDate = booking.StartDate;
                existingBooking.EndDate = booking.EndDate;
                existingBooking.PaymentStatus = booking.PaymentStatus;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var booking = _context.Bookings.Find(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                _context.SaveChanges();
            }
        }

        public Booking GetById(int id)
        {
            return _context.Bookings.Find(id);
        }

        public IEnumerable<Booking> GetAll()
        {
            return _context.Bookings.ToList();
        }
    }
}