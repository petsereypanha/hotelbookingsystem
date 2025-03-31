using System.Collections.Generic;
using System.Linq;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Data.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly DatabaseContext _context;

        public CustomerRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Add(Customer entity)
        {
            _context.Customers.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Customer entity)
        {
            _context.Customers.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public Customer GetById(int id)
        {
            return _context.Customers.Find(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
    }
}