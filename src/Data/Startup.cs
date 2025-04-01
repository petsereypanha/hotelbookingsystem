using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using HotelBookingSystem.Data;

namespace HotelBookingSystem
{
    public static class Startup
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            
            string connectionString = "Server=localhost,1433;Database=HotelBooking;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True";
            
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(connectionString, sqlOptions =>
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: TimeSpan.FromSeconds(10),
                        errorNumbersToAdd: null)));
            
            // Add other services
            
            return services.BuildServiceProvider();
        }
    }
}