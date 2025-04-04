using System;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Patterns.Decorator
{
    public class DiscountBookingDecorator : BookingDecorator
    {
        private readonly decimal _discountPercentage;

        public DiscountBookingDecorator(IBooking booking, decimal discountPercentage) : base(booking)
        {
            _discountPercentage = discountPercentage;
        }

        public override decimal GetTotal()
        {
            decimal total = base.GetTotal();
            return total - (total * _discountPercentage / 100);
        }
    }
}