using System;
using System.Text.RegularExpressions;

namespace HotelManagementSystem.Utils
{
    public static class ValidationHelper
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            var phonePattern = @"^\+?[1-9]\d{1,14}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        public static bool IsValidRoomType(string roomType)
        {
            return !string.IsNullOrWhiteSpace(roomType);
        }

        public static bool IsValidDateRange(DateTime startDate, DateTime endDate)
        {
            return startDate < endDate;
        }

        public static bool IsValidTotal(decimal total)
        {
            return total >= 0;
        }
    }
}