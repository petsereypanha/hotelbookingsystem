using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelManagementSystem.Models;
using HotelManagementSystem.Patterns.Singleton;

namespace HotelManagementSystem.Data.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly DatabaseSingleton _dbSingleton;

        public BookingRepository(DatabaseSingleton dbSingleton)
        {
            _dbSingleton = dbSingleton;
        }

        public void Add(Booking booking)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("INSERT INTO Booking (Customer_ID, Room_ID, Start_Date, End_Date, Payment_Status, Total) VALUES (@CustomerId, @RoomId, @StartDate, @EndDate, @PaymentStatus, @Total)", connection);
                command.Parameters.AddWithValue("@CustomerId", booking.Customer_ID);
                command.Parameters.AddWithValue("@RoomId", booking.Room_ID);
                command.Parameters.AddWithValue("@StartDate", booking.Start_Date);
                command.Parameters.AddWithValue("@EndDate", booking.End_Date);
                command.Parameters.AddWithValue("@PaymentStatus", booking.Payment_Status);
                command.Parameters.AddWithValue("@Total", booking.Total);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Booking booking)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("UPDATE Booking SET Customer_ID = @CustomerId, Room_ID = @RoomId, Start_Date = @StartDate, End_Date = @EndDate, Payment_Status = @PaymentStatus, Total = @Total WHERE Booking_ID = @BookingId", connection);
                command.Parameters.AddWithValue("@BookingId", booking.Booking_ID);
                command.Parameters.AddWithValue("@CustomerId", booking.Customer_ID);
                command.Parameters.AddWithValue("@RoomId", booking.Room_ID);
                command.Parameters.AddWithValue("@StartDate", booking.Start_Date);
                command.Parameters.AddWithValue("@EndDate", booking.End_Date);
                command.Parameters.AddWithValue("@PaymentStatus", booking.Payment_Status);
                command.Parameters.AddWithValue("@Total", booking.Total);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("DELETE FROM Booking WHERE Booking_ID = @BookingId", connection);
                command.Parameters.AddWithValue("@BookingId", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Booking GetById(int id)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("SELECT * FROM Booking WHERE Booking_ID = @BookingId", connection);
                command.Parameters.AddWithValue("@BookingId", id);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Booking
                        {
                            Booking_ID = (int)reader["Booking_ID"],
                            Customer_ID = (int)reader["Customer_ID"],
                            Room_ID = (int)reader["Room_ID"],
                            Start_Date = (DateTime)reader["Start_Date"],
                            End_Date = (DateTime)reader["End_Date"],
                            Payment_Status = (string)reader["Payment_Status"],
                            Total = (decimal)reader["Total"]
                        };
                    }
                }
            }
            return null;
        }

        public List<Booking> GetAll()
        {
            var bookings = new List<Booking>();
            // Existing implementation
            return bookings;
        }

        public IEnumerable<Booking> GetBookingsByCustomerId(int customerId)
        {
            var bookings = new List<Booking>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("SELECT * FROM Booking WHERE Customer_ID = @CustomerId", connection);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(new Booking
                        {
                            Booking_ID = (int)reader["Booking_ID"],
                            Customer_ID = (int)reader["Customer_ID"],
                            Room_ID = (int)reader["Room_ID"],
                            Start_Date = (DateTime)reader["Start_Date"],
                            End_Date = (DateTime)reader["End_Date"],
                            Payment_Status = (string)reader["Payment_Status"],
                            Total = (decimal)reader["Total"]
                        });
                    }
                }
            }
            return bookings;
        }

        public IEnumerable<Booking> GetBookingsByRoomId(int roomId)
        {
            var bookings = new List<Booking>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("SELECT * FROM Booking WHERE Room_ID = @RoomId", connection);
                command.Parameters.AddWithValue("@RoomId", roomId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(new Booking
                        {
                            Booking_ID = (int)reader["Booking_ID"],
                            Customer_ID = (int)reader["Customer_ID"],
                            Room_ID = (int)reader["Room_ID"],
                            Start_Date = (DateTime)reader["Start_Date"],
                            End_Date = (DateTime)reader["End_Date"],
                            Payment_Status = (string)reader["Payment_Status"],
                            Total = (decimal)reader["Total"]
                        });
                    }
                }
            }
            return bookings;
        }

        // Make sure IEnumerable<Booking> GetAll() is marked as explicit implementation
        IEnumerable<Booking> IRepository<Booking>.GetAll()
        {
            return this.GetAll();
        }
    }
}