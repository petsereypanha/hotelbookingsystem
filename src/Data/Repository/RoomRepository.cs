using System.Collections.Generic;
using System.Linq;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Data.Repository
{
    public class RoomRepository : IRepository<Room>
    {
        private readonly DatabaseContext _context;

        public RoomRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Add(Room entity)
        {
            _context.Rooms.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Room entity)
        {
            _context.Rooms.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Room entity)
        {
            _context.Rooms.Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var room = _context.Rooms.Find(id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
        }

        public Room GetById(int id)
        {
            return _context.Rooms.Find(id);
        }

        public IEnumerable<Room> GetAll()
        {
            return _context.Rooms.ToList();
        }
    }
}