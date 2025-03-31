using System;

namespace HotelBookingSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string ContactInfo { get; set; }

        public Employee(int employeeId, string name, string position, string contactInfo)
        {
            EmployeeId = employeeId;
            Name = name;
            Position = position;
            ContactInfo = contactInfo;
        }
    }
}