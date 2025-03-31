using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace HotelBookingSystem.Services.Singleton
{
    public sealed class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> instance = new Lazy<DatabaseConnection>(() => new DatabaseConnection());
        private SqlConnection connection;

        private DatabaseConnection()
        {
            // Initialize the database connection
            string connectionString = "YourConnectionStringHere"; // Replace with your actual connection string
            connection = new SqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public SqlConnection Connection
        {
            get
            {
                return connection;
            }
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}