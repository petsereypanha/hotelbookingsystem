using System;

namespace HotelBookingSystem.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int BedCount { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public bool AvailabilityStatus { get; set; }
        

        public Room(int roomId, string roomType, decimal price, bool availabilityStatus, int bedCount)
        {
            RoomId = roomId;
            RoomType = roomType;
            Price = price;
            AvailabilityStatus = availabilityStatus;
            BedCount = bedCount;
        }
        
    }
}