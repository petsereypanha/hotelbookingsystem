using System;
using System.Data.SqlClient;

namespace HotelManagementSystem.Data
{
    public class DatabaseConnection
    {
        private readonly string connectionString;

        public DatabaseConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}