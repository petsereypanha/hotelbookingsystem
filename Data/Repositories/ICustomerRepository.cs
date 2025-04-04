using System.Collections.Generic;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Data.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        
        Customer GetByEmail(string email);
        Customer GetByPhone(string phone);
    }
}