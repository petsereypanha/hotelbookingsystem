using System;

namespace HotelManagementSystem.Models
{
    public interface IBooking
    {
        int Booking_ID { get; set; }
        int Customer_ID { get; set; }
        int Room_ID { get; set; }
        DateTime Start_Date { get; set; }
        DateTime End_Date { get; set; }
        string Payment_Status { get; set; }
        decimal Total { get; set; }
        public void Book()
        {
            // Implement booking logic here
            // For example, update availability status or save to database
            Payment_Status = "Pending";
        }

        public decimal GetTotal()
        {
            // Return the stored total or calculate it if needed
            return Total;
        }
    }
}