using System;

namespace HotelManagementSystem.Models
{
    public class Booking : IBooking
    {
        public int Booking_ID { get; set; }
        public int Customer_ID { get; set; }
        public int Room_ID { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Payment_Status { get; set; }
        public decimal Total { get; set; }
    }
}