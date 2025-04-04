using System;
using HotelManagementSystem.Data.Repositories;
using HotelManagementSystem.Patterns.Singleton;

namespace HotelManagementSystem.Patterns.Factory
{
    public static class RepositoryFactory
    {
        public static T CreateRepository<T>() where T : class
        {
            var dbSingleton = DatabaseSingleton.Instance;
            
            if (typeof(T) == typeof(IRepository<>))
            {
                return new CustomerRepository(dbSingleton) as T;
            }
            else if (typeof(T) == typeof(RoomRepository))
            {
                return new RoomRepository(dbSingleton) as T;
            }
            else if (typeof(T) == typeof(BookingRepository))
            {
                return new BookingRepository(dbSingleton) as T;
            }
            else if (typeof(T) == typeof(BookingHistoryRepository))
            {
                return new BookingHistoryRepository(dbSingleton) as T;
            }
            throw new ArgumentException("Repository type not recognized.");
        }
    }
}