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
                            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HotelBookingDB;Trusted_Connection=True;");
                        }
                    }
            
                    public override int SaveChanges()
                    {
                        return base.SaveChanges();
                    }
                }
            }