using System.Collections.Generic;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Data.Repositories
{
    public interface IRoomRepository : IRepository<Room>
    {
        // Add any room-specific repository methods here
        IEnumerable<Room> GetAvailableRooms();
        IEnumerable<Room> GetRoomsByType(string roomType);
    }
}