using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelBookingSystem.Data.Repository;

namespace HotelBookingSystem.Data
{
    public class UnitOfWork : IDisposable
    {
        private readonly DatabaseContext _context;
        private BookingRepository _bookingRepository;
        private CustomerRepository _customerRepository;
        private RoomRepository _roomRepository;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public BookingRepository BookingRepository
        {
            get
            {
                return _bookingRepository ??= new BookingRepository(_context);
            }
        }

        public CustomerRepository CustomerRepository
        {
            get
            {
                return _customerRepository ??= new CustomerRepository(_context);
            }
        }

        public RoomRepository RoomRepository
        {
            get
            {
                return _roomRepository ??= new RoomRepository(_context);
            }
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}