using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using HotelManagementSystem.Models;
using HotelManagementSystem.Patterns.Singleton;

namespace HotelManagementSystem.Data.Repositories
{
    public class BookingHistoryRepository : IBookingHistoryRepository
    {
        private readonly DatabaseSingleton _dbSingleton;
        
        public BookingHistoryRepository(DatabaseSingleton connectionString)
        {
            _dbSingleton = connectionString;
        }

        public IEnumerable<BookingHistory> GetByCustomer(string customerName)
        {
            var bookings = new List<BookingHistory>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand(
                    "SELECT * FROM Booking_History WHERE Customer LIKE @CustomerName", 
                    connection);
                command.Parameters.AddWithValue("@CustomerName", $"%{customerName}%");

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(new BookingHistory
                        {
                            Booking_ID = reader.GetInt32(0),
                            Customer = reader.GetString(1),
                            Room_ID = reader.GetInt32(2),
                            Start_Date = reader.GetDateTime(3),
                            End_Date = reader.GetDateTime(4),
                            Payment_Status = reader.GetString(5)
                        });
                    }
                }
            }
            return bookings;
        }

        public IEnumerable<BookingHistory> GetByPaymentStatus(string paymentStatus)
        {
            var bookings = new List<BookingHistory>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand(
                    "SELECT * FROM Booking_History WHERE Payment_Status = @PaymentStatus", 
                    connection);
                command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(new BookingHistory
                        {
                            Booking_ID = reader.GetInt32(0),
                            Customer = reader.GetString(1),
                            Room_ID = reader.GetInt32(2),
                            Start_Date = reader.GetDateTime(3),
                            End_Date = reader.GetDateTime(4),
                            Payment_Status = reader.GetString(5)
                        });
                    }
                }
            }
            return bookings;
        }

        public IEnumerable<BookingHistory> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            var bookings = new List<BookingHistory>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand(
                    "SELECT * FROM Booking_History WHERE Start_Date >= @StartDate AND End_Date <= @EndDate", 
                    connection);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(new BookingHistory
                        {
                            Booking_ID = reader.GetInt32(0),
                            Customer = reader.GetString(1),
                            Room_ID = reader.GetInt32(2),
                            Start_Date = reader.GetDateTime(3),
                            End_Date = reader.GetDateTime(4),
                            Payment_Status = reader.GetString(5)
                        });
                    }
                }
            }
            return bookings;
        }

        public IEnumerable<BookingHistory> GetByRoomId(int roomId)
        {
            var bookings = new List<BookingHistory>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand(
                    "SELECT * FROM Booking_History WHERE Room_ID = @RoomId", 
                    connection);
                command.Parameters.AddWithValue("@RoomId", roomId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(new BookingHistory
                        {
                            Booking_ID = reader.GetInt32(0),
                            Customer = reader.GetString(1),
                            Room_ID = reader.GetInt32(2),
                            Start_Date = reader.GetDateTime(3),
                            End_Date = reader.GetDateTime(4),
                            Payment_Status = reader.GetString(5)
                        });
                    }
                }
            }
            return bookings;
        }

        public int GetTotalBookingCount()
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("SELECT COUNT(*) FROM Booking_History", connection);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public int GetPaidBookingsCount()
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand(
                    "SELECT COUNT(*) FROM Booking_History WHERE Payment_Status = 'Paid'", 
                    connection);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public IEnumerable<BookingHistory> GetAll()
        {
            var bookings = new List<BookingHistory>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("SELECT * FROM Booking_History", connection);
                
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(new BookingHistory
                        {
                            Booking_ID = reader.GetInt32(0),
                            Customer = reader.GetString(1),
                            Room_ID = reader.GetInt32(2),
                            Start_Date = reader.GetDateTime(3),
                            End_Date = reader.GetDateTime(4),
                            Payment_Status = reader.GetString(5)
                        });
                    }
                }
            }
            return bookings;
        }

        public BookingHistory GetById(int id)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand(
                    "SELECT * FROM Booking_History WHERE Booking_ID = @BookingId",
                    connection);
                command.Parameters.AddWithValue("@BookingId", id);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new BookingHistory
                        {
                            Booking_ID = reader.GetInt32(0),
                            Customer = reader.GetString(1),
                            Room_ID = reader.GetInt32(2),
                            Start_Date = reader.GetDateTime(3),
                            End_Date = reader.GetDateTime(4),
                            Payment_Status = reader.GetString(5)
                        };
                    }
                    return null;
                }
            }
        }

        public void Add(BookingHistory entity)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand(
                    "INSERT INTO Booking_History (Customer, Room_ID, Start_Date, End_Date, Payment_Status) " +
                    "VALUES (@Customer, @RoomId, @StartDate, @EndDate, @PaymentStatus)",
                    connection);
                
                command.Parameters.AddWithValue("@Customer", entity.Customer);
                command.Parameters.AddWithValue("@RoomId", entity.Room_ID);
                command.Parameters.AddWithValue("@StartDate", entity.Start_Date);
                command.Parameters.AddWithValue("@EndDate", entity.End_Date);
                command.Parameters.AddWithValue("@PaymentStatus", entity.Payment_Status);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(BookingHistory entity)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand(
                    "UPDATE Booking_History SET Customer = @Customer, Room_ID = @RoomId, " +
                    "Start_Date = @StartDate, End_Date = @EndDate, Payment_Status = @PaymentStatus " +
                    "WHERE Booking_ID = @BookingId",
                    connection);
                
                command.Parameters.AddWithValue("@BookingId", entity.Booking_ID);
                command.Parameters.AddWithValue("@Customer", entity.Customer);
                command.Parameters.AddWithValue("@RoomId", entity.Room_ID);
                command.Parameters.AddWithValue("@StartDate", entity.Start_Date);
                command.Parameters.AddWithValue("@EndDate", entity.End_Date);
                command.Parameters.AddWithValue("@PaymentStatus", entity.Payment_Status);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand(
                    "DELETE FROM Booking_History WHERE Booking_ID = @BookingId",
                    connection);
                command.Parameters.AddWithValue("@BookingId", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public List<BookingHistory> GetBookingHistoryByCustomerID(int customerId)
        {
            var bookings = new List<BookingHistory>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                string customerName = null;
                var customerCommand = new SqlCommand(
                    "SELECT Name FROM Customer WHERE Customer_ID = @CustomerId", 
                    connection);
                customerCommand.Parameters.AddWithValue("@CustomerId", customerId);
                
                connection.Open();
                var customerResult = customerCommand.ExecuteScalar();
                if (customerResult != null)
                {
                    customerName = customerResult.ToString();
                    return GetByCustomer(customerName).ToList();
                }
            }
            return bookings;
        }
    }
}