using System;

namespace HotelManagementSystem.Models
{
    public class Room
    {
        public int Room_ID { get; set; }
        public string Room_Type { get; set; }
        public decimal Price { get; set; }
        public bool AvailabilityStatus { get; set; }
    }
}