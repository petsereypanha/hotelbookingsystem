using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem.Patterns.Singleton
{
    public sealed class DatabaseSingleton
    {
        private static readonly Lazy<DatabaseSingleton> instance = new Lazy<DatabaseSingleton>(() => new DatabaseSingleton());
        private readonly string _connectionString;

         private DatabaseSingleton()
        {
            try
            {
                // Try to get from config
                var connectionStringSettings = ConfigurationManager.ConnectionStrings["master"];
                
                if (connectionStringSettings != null)
                {
                    _connectionString = connectionStringSettings.ConnectionString;
                }
                else
                {
                    // Fallback to a default connection string
                    _connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
                    
                    // Log that we're using a default connection
                    Console.WriteLine("Warning: Using default connection string. 'master' connection string not found in configuration.");
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error initializing database connection: {ex.Message}");
                
                // Use a default connection string
                _connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
            }
        }

        public static DatabaseSingleton Instance
        {
            get { return instance.Value; }
        }

        public string ConnectionString
        {
            get { return _connectionString; }
        }

        public SqlConnection CreateConnection()
        {
            var connection = new SqlConnection(_connectionString);
            return connection;
        }

        public SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection(_connectionString);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }
    }
}