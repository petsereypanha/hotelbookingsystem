using System.Collections.Generic;
using HotelManagementSystem.Data.Repositories;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Services
{
    public class RoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return _roomRepository.GetAll();
        }

        public Room GetRoomById(int roomId)
        {
            return _roomRepository.GetById(roomId);
        }

        public void AddRoom(Room room)
        {
            _roomRepository.Add(room);
        }

        public void UpdateRoom(Room room)
        {
            _roomRepository.Update(room);
        }

        public void DeleteRoom(int roomId)
        {
            _roomRepository.Delete(roomId);
        }

        public IEnumerable<Room> GetAvailableRooms()
        {
            return _roomRepository.GetAvailableRooms();
        }
    }
}