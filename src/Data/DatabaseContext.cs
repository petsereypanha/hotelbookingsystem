using Microsoft.EntityFrameworkCore;
            using HotelBookingSystem.Models;
            
            namespace HotelBookingSystem.Data
            {
                public class DatabaseContext : DbContext
                {
                    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
                    {
                    }
            
                    // Empty constructor for design-time tools
                    public DatabaseContext()
                    {
                    }
            
                    public DbSet<Booking> Bookings { get; set; }
                    public DbSet<Customer> Customers { get; set; }
                    public DbSet<Room> Rooms { get; set; }
                    public DbSet<Payment> Payments { get; set; }
                    public DbSet<Employee> Employees { get; set; }
            
                    protected override void OnModelCreating(ModelBuilder modelBuilder)
                    {
                        // Configure entity properties and relationships here
                        base.OnModelCreating(modelBuilder);
                    }
            
                    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                    {
                        if (!optionsBuilder.IsConfigured)
                        {
                             string connectionString = "Server=localhost,1433;Database=master;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;Connection Timeout=30";
                            optionsBuilder.UseSqlServer(connectionString, sqlOptions =>
                                sqlOptions.EnableRetryOnFailure(
                                    maxRetryCount: 5,
                                    maxRetryDelay: TimeSpan.FromSeconds(10),
                                    errorNumbersToAdd: null));
                        }
                    }
            
                    public override int SaveChanges()
                    {
                        return base.SaveChanges();
                    }
                }
            }