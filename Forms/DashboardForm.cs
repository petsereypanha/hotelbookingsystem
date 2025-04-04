using System;
using System.Linq;
using System.Windows.Forms;
using HotelManagementSystem.Data.Repositories;
using HotelManagementSystem.Models;
using HotelManagementSystem.Patterns.Singleton;
using HotelManagementSystem.Services;

namespace HotelManagementSystem.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly RoomService _roomService;
        private readonly CustomerService _customerService;
        private readonly BookingService _bookingService;

        public DashboardForm()
        {
            InitializeComponent();
            
            // Initialize services
            var dbSingleton = DatabaseSingleton.Instance;
            var roomRepository = new RoomRepository(dbSingleton);
            var customerRepository = new CustomerRepository(dbSingleton);
            var bookingRepository = new BookingRepository(dbSingleton);
            
            _roomService = new RoomService(roomRepository);
            _customerService = new CustomerService(customerRepository);
            _bookingService = new BookingService(bookingRepository, customerRepository, roomRepository);
            
            // Set form load event
            this.Load += DashboardForm_Load;
        }
        
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
        
        private void LoadDashboardData()
        {
            try
            {
                // Get all rooms, customers, and bookings
                var rooms = _roomService.GetAllRooms().ToList();
                var customers = _customerService.GetAllCustomers().ToList();
                var bookings = _bookingService.GetAllBookings().ToList();
                
                // Calculate dashboard statistics
                
                // 1. Available rooms
                int availableRooms = rooms.Count(r => r.AvailabilityStatus);
                lblAvailableRoomsCount.Text = availableRooms.ToString();
                
                // 2. Booked rooms
                int bookedRooms = rooms.Count(r => !r.AvailabilityStatus);
                lblBookedRoomsCount.Text = $"{bookedRooms}/{rooms.Count}";
                
                // 3. Room 1 Bed count
                int singleBedRooms = rooms.Count(r => r.Room_Type?.ToLower() == "standard");
                lblRoom1BedCount.Text = singleBedRooms.ToString();
                
                // 4. Room 2 Bed count
                int doubleBedRooms = rooms.Count(r => r.Room_Type?.ToLower() == "premium");
                lblRoom2BedCount.Text = doubleBedRooms.ToString();
                
                // 5. Total customers
                lblTotalCustomersCount.Text = customers.Count.ToString();
                
                // Set colors based on availability
                SetPanelColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Exception in LoadDashboardData: {ex}");
            }
        }
        
        private void SetPanelColors()
        {
            // Get room counts for color coding
            int availableCount = int.Parse(lblAvailableRoomsCount.Text);
            string[] bookedParts = lblBookedRoomsCount.Text.Split('/');
            int bookedCount = int.Parse(bookedParts[0]);
            int totalCount = int.Parse(bookedParts[1]);
            
            // Set colors based on availability percentage
            if (availableCount > totalCount * 0.5)
            {
                panelAvailableRooms.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            else if (availableCount > totalCount * 0.2)
            {
                panelAvailableRooms.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                panelAvailableRooms.BackColor = System.Drawing.Color.IndianRed;
            }
            
            // Set colors for booked rooms panel
            if (bookedCount > totalCount * 0.8)
            {
                panelBookedRooms.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
            else if (bookedCount > totalCount * 0.4)
            {
                panelBookedRooms.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                panelBookedRooms.BackColor = System.Drawing.Color.LightGray;
            }
            
            // Set standard colors for other panels
            panelRoom1Bed.BackColor = System.Drawing.Color.LightSteelBlue;
            panelRoom2Bed.BackColor = System.Drawing.Color.LightSteelBlue;
            panelTotalCustomers.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        
        // Add a refresh button and handler if needed
        public void RefreshDashboard()
        {
            LoadDashboardData();
        }
    }
}