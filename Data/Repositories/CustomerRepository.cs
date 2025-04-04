using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelManagementSystem.Models;
using HotelManagementSystem.Patterns.Singleton;

namespace HotelManagementSystem.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DatabaseSingleton _dbSingleton;

        public CustomerRepository(DatabaseSingleton connectionString)
        {
            _dbSingleton = connectionString;
        }

        public void Add(Customer customer)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("INSERT INTO Customers (Name, Phone, Email, Address) VALUES (@Name, @Phone, @Email, @Address)", connection);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Phone", customer.Phone);
                command.Parameters.AddWithValue("@Email", customer.Email);
                command.Parameters.AddWithValue("@Address", customer.Address);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Customer customer)
        {
            using (var connection =  _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("UPDATE Customers SET Name = @Name, Phone = @Phone, Email = @Email, Address = @Address WHERE ID = @ID", connection);
                command.Parameters.AddWithValue("@ID", customer.ID);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Phone", customer.Phone);
                command.Parameters.AddWithValue("@Email", customer.Email);
                command.Parameters.AddWithValue("@Address", customer.Address);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("DELETE FROM Customers WHERE ID = @ID", connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Customer GetById(int id)
        {
            using (var connection =  _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("SELECT * FROM Customers WHERE ID = @ID", connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Customer
                        {
                            ID = (int)reader["ID"],
                            Name = reader["Name"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public IEnumerable<Customer> GetAll()
        {
            var customers = new List<Customer>();
            using (var connection =  _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("SELECT * FROM Customers", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            ID = (int)reader["ID"],
                            Name = reader["Name"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString()
                        });
                    }
                }
            }
            return customers;
        }
         public Customer GetByEmail(string email)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("SELECT * FROM Customers WHERE Email = @Email", connection);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Customer
                        {
                            ID = (int)reader["ID"],
                            Name = reader["Name"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public Customer GetByPhone(string phone)
        {
            using (var connection = _dbSingleton.CreateConnection())
            {
                var command = new SqlCommand("SELECT * FROM Customers WHERE Phone = @Phone", connection);
                command.Parameters.AddWithValue("@Phone", phone);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Customer
                        {
                            ID = (int)reader["ID"],
                            Name = reader["Name"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString()
                        };
                    }
                }
            }
            return null;
        }
    }
}