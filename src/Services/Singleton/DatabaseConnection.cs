using System;
using Microsoft.Data.SqlClient;

namespace HotelBookingSystem.Services.Singleton
{
    public sealed class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> instance = new Lazy<DatabaseConnection>(() => new DatabaseConnection());
        private SqlConnection connection;

        private DatabaseConnection()
        {
            // Updated database name to match Docker setup
            string connectionString = "Server=localhost,1433;Database=master;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;ConnectRetryCount=5;ConnectRetryInterval=10;Connection Timeout=60";
            connection = new SqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get { return instance.Value; }
        }

        public SqlConnection Connection
        {
            get { return connection; }
        }

        public bool OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Number} - {ex.Message}");
                return false;
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