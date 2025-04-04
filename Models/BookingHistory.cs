using System;

public class BookingHistory
{
    public int Booking_ID { get; set; }
    public string Customer { get; set; }
    public int Room_ID { get; set; }
    public DateTime Start_Date { get; set; }
    public DateTime End_Date { get; set; }
    public string Payment_Status { get; set; }
}