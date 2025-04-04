using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelManagementSystem.Models;
using HotelManagementSystem.Patterns.Singleton;

namespace HotelManagementSystem.Data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DatabaseSingleton _dbSingleton;

        public RoomRepository(DatabaseSingleton connectionString)
        {
            _dbSingleton = connectionString;
        }

        public void Add(Room room)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                string query = "INSERT INTO Rooms (Room_Type, Price, AvailabilityStatus) VALUES (@RoomType, @Price, @AvailabilityStatus)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomType", room.Room_Type);
                command.Parameters.AddWithValue("@Price", room.Price);
                command.Parameters.AddWithValue("@AvailabilityStatus", room.AvailabilityStatus);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Room room)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                string query = "UPDATE Rooms SET Room_Type = @RoomType, Price = @Price, AvailabilityStatus = @AvailabilityStatus WHERE Room_ID = @RoomId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomId", room.Room_ID);
                command.Parameters.AddWithValue("@RoomType", room.Room_Type);
                command.Parameters.AddWithValue("@Price", room.Price);
                command.Parameters.AddWithValue("@AvailabilityStatus", room.AvailabilityStatus);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                string query = "DELETE FROM Rooms WHERE Room_ID = @RoomId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomId", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Room GetById(int id)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                string query = "SELECT * FROM Rooms WHERE Room_ID = @RoomId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomId", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Room
                    {
                        Room_ID = (int)reader["Room_ID"],
                        Room_Type = reader["Room_Type"].ToString(),
                        Price = (decimal)reader["Price"],
                        AvailabilityStatus = Convert.ToBoolean(reader["AvailabilityStatus"].ToString())
                    };
                }
                return null;
            }
        }

        public IEnumerable<Room> GetAll()
        {
            var rooms = new List<Room>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                string query = "SELECT * FROM Rooms";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rooms.Add(new Room
                    {
                        Room_ID = (int)reader["Room_ID"],
                        Room_Type = reader["Room_Type"].ToString(),
                        Price = (decimal)reader["Price"],
                        AvailabilityStatus = Convert.ToBoolean(reader["AvailabilityStatus"].ToString())
                    });
                }
            }
            return rooms;
        }
        public IEnumerable<Room> GetAvailableRooms()
        {
            var rooms = new List<Room>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                string query = "SELECT * FROM Rooms WHERE AvailabilityStatus = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rooms.Add(new Room
                    {
                        Room_ID = (int)reader["Room_ID"],
                        Room_Type = reader["Room_Type"].ToString(),
                        Price = (decimal)reader["Price"],
                        AvailabilityStatus = Convert.ToBoolean(reader["AvailabilityStatus"].ToString())
                    });
                }
            }
            return rooms;
        }
        public IEnumerable<Room> GetUnavailableRooms()
        {
            var rooms = new List<Room>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                string query = "SELECT * FROM Rooms WHERE AvailabilityStatus = 0";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rooms.Add(new Room
                    {
                        Room_ID = (int)reader["Room_ID"],
                        Room_Type = reader["Room_Type"].ToString(),
                        Price = (decimal)reader["Price"],
                        AvailabilityStatus = Convert.ToBoolean(reader["AvailabilityStatus"].ToString())
                    });
                }
            }
            return rooms;
        }
                public IEnumerable<Room> GetRoomsByType(string roomType)
        {
            var rooms = new List<Room>();
            using (var connection = _dbSingleton.CreateConnection())
            {
                string query = "SELECT * FROM Rooms WHERE Room_Type = @RoomType";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomType", roomType);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rooms.Add(new Room
                    {
                        Room_ID = (int)reader["Room_ID"],
                        Room_Type = reader["Room_Type"].ToString(),
                        Price = (decimal)reader["Price"],
                        AvailabilityStatus = Convert.ToBoolean(reader["AvailabilityStatus"].ToString())
                    });
                }
            }
            return rooms;
        }
    }
}