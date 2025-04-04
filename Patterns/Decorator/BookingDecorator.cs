using System;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Patterns.Decorator
{
    public abstract class BookingDecorator : IBooking
    {
        protected IBooking booking;

        public BookingDecorator(IBooking booking)
        {
            this.booking = booking;
        }

        // Implement required IBooking properties
        public int Booking_ID 
        { 
            get { return booking.Booking_ID; } 
            set { booking.Booking_ID = value; } 
        }

        public int Customer_ID 
        { 
            get { return booking.Customer_ID; } 
            set { booking.Customer_ID = value; } 
        }

        public int Room_ID 
        { 
            get { return booking.Room_ID; } 
            set { booking.Room_ID = value; } 
        }

        public DateTime Start_Date 
        { 
            get { return booking.Start_Date; } 
            set { booking.Start_Date = value; } 
        }

        public DateTime End_Date 
        { 
            get { return booking.End_Date; } 
            set { booking.End_Date = value; } 
        }

        public string Payment_Status 
        { 
            get { return booking.Payment_Status; } 
            set { booking.Payment_Status = value; } 
        }

        public decimal Total 
        { 
            get { return booking.Total; } 
            set { booking.Total = value; } 
        }

        // Maintain existing methods
        public virtual void Book()
        {
            booking.Book();
        }

        public virtual decimal GetTotal()
        {
            return booking.GetTotal();
        }
    }
}