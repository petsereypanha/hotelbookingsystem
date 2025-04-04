using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelManagementSystem.Data.Repositories;
using HotelManagementSystem.Models;
using HotelManagementSystem.Patterns.Singleton;
using HotelManagementSystem.Services;

namespace HotelManagementSystem.Forms
{
    public partial class BookingForm : Form
    {
        private readonly BookingService _bookingService;
        private readonly RoomService _roomService;
        private readonly CustomerService _customerService;
        private List<Room> _availableRooms;
        private List<Customer> _customers;
        private Room _selectedRoom;
        private decimal _totalPrice;

        public BookingForm()
        {
            InitializeComponent();
            
            var dbSingleton = DatabaseSingleton.Instance;
            var bookingRepository = new BookingRepository(dbSingleton);
            var customerRepository = new CustomerRepository(dbSingleton);
            var roomRepository = new RoomRepository(dbSingleton);

            this.Load += BookingForm_Load;
            
            _bookingService = new BookingService(bookingRepository, customerRepository, roomRepository);
            _roomService = new RoomService(roomRepository);
            _customerService = new CustomerService(customerRepository);
            _availableRooms = new List<Room>();
            _customers = new List<Customer>();
            

            btnBook.Click += BtnBook_Click;
            btnCancel.Click += BtnCancel_Click; 
            cmbRoomType.SelectedIndexChanged += FilterControls_Changed;
            cmbBedCount.SelectedIndexChanged += FilterControls_Changed;
            dgvHotelList.SelectionChanged += DgvHotelList_SelectionChanged; // Changed from dgvRoomList to dgvHotelList
            
            chkBreakfast.CheckedChanged += AdditionalServices_CheckedChanged;
            chkGymSpa.CheckedChanged += AdditionalServices_CheckedChanged;
            chkBarAccess.CheckedChanged += AdditionalServices_CheckedChanged;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            // Setup comboboxes
            cmbRoomType.Items.AddRange(new[] { "All", "Standard", "Deluxe", "Suite" });
            cmbBedCount.Items.AddRange(new[] { "All", "1", "2" });
            cmbRoomType.SelectedIndex = 0;
            cmbBedCount.SelectedIndex = 0;
            
            // Set date pickers to reasonable defaults
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(1);
            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = DateTime.Today.AddDays(1);
            foreach (DataGridViewColumn column in dgvHotelList.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            
            // After all columns are configured, set the auto-size mode
            dgvHotelList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    
            
            // Initialize data
            LoadAvailableRooms();
            LoadCustomers();
            UpdateTotalPrice();
        }
        
        private void LoadAvailableRooms()
        {
            var rooms = _roomService.GetAllRooms();
            _availableRooms = rooms != null ? rooms.ToList() : new List<Room>();
            
            FilterRooms();
        }
        private void LoadCustomers()
        {
            _customers = new List<Customer>(_customerService.GetAllCustomers());
            cmbCustomer.DataSource = null;
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "ID";
            cmbCustomer.DataSource = _customers;
        }
        
        private void FilterRooms()
        {
            // Temporarily suspend layout and auto-resize during updates
            dgvHotelList.SuspendLayout();
            dgvHotelList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            
            dgvHotelList.Rows.Clear();
            
            // Add null check before using _availableRooms
            if (_availableRooms == null)
            {
                _availableRooms = new List<Room>();
                dgvHotelList.ResumeLayout();
                return;
            }
            
            var filteredRooms = _availableRooms;
        
            foreach (var room in filteredRooms)
            {
                dgvHotelList.Rows.Add(
                    room.Room_ID,
                    room.Room_Type,
                    "1", // Placeholder for bed count
                    room.Price
                );
            }
            
            // Restore auto-sizing behavior after updates are complete
            dgvHotelList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHotelList.ResumeLayout();
        }
        
        private void FilterControls_Changed(object sender, EventArgs e)
        {
            FilterRooms();
        }
        
        private void DgvHotelList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHotelList.SelectedRows.Count > 0)
            {
                int roomId = Convert.ToInt32(dgvHotelList.SelectedRows[0].Cells[0].Value);
                _selectedRoom = _roomService.GetRoomById(roomId);
                
                // Add null check
                if (_selectedRoom != null)
                {
                    txtSelectedRoom.Text = _selectedRoom.Room_Type;
                    UpdateTotalPrice();
                }
                else
                {
                    txtSelectedRoom.Text = "Room not found";
                    // Handle the null case appropriately
                }
            }
        }
        
        private void AdditionalServices_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
        
        private void UpdateTotalPrice()
        {
            // Check if selected room is null before using it
            if (_selectedRoom == null)
            {
                lblTotalAmount.Text = "$0.00";
                _totalPrice = 0;
                return;
            }
            
            // Continue with existing logic
            decimal price = _selectedRoom.Price;
            int days = (int)(dtpEndDate.Value - dtpStartDate.Value).TotalDays;
            
            // Additional options
            if (chkBreakfast.Checked) price += 15;
            if (chkGymSpa.Checked) price += 25;
            if (chkBarAccess.Checked) price += 20;
            
            _totalPrice = price * days;
            lblTotalAmount.Text = $"${_totalPrice:F2}";
        }
        
        private void BtnBook_Click(object sender, EventArgs e)
        {
            if (_selectedRoom == null)
            {
                MessageBox.Show("Please select a room first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (cmbCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                MessageBox.Show("End date must be after start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                var booking = new Booking
                {
                    Customer_ID = GetSelectedCustomerId(),
                    Room_ID = GetSelectedRoomId(),
                    Start_Date = dtpStartDate.Value,
                    End_Date = dtpEndDate.Value,
                    Total = _totalPrice, // Use Total instead of TotalAmount
                    Payment_Status = "Pending"
                };
                
                _bookingService.CreateBooking(booking);
                MessageBox.Show("Booking successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnCancel_Click(sender, e); // Changed from BtnReset_Click to BtnCancel_Click
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnCancel_Click(object sender, EventArgs e) // Changed from BtnReset_Click to BtnCancel_Click
        {
            cmbRoomType.SelectedIndex = 0;
            cmbBedCount.SelectedIndex = 0;
            cmbCustomer.SelectedIndex = -1;
            txtGuestName.Text = string.Empty;
            txtSelectedRoom.Text = string.Empty;
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(1);
            chkBreakfast.Checked = false;
            chkGymSpa.Checked = false;
            chkBarAccess.Checked = false;
            _selectedRoom = null;
            UpdateTotalPrice();
            LoadAvailableRooms();
        }

        private int GetSelectedCustomerId()
        {
            if (cmbCustomer.SelectedValue != null)
            {
                return (int)cmbCustomer.SelectedValue;
            }
            return 0;
        }

        private int GetSelectedRoomId()
        {
            return _selectedRoom?.Room_ID ?? 0;
        }

        private decimal CalculateTotal()
        {
            return _totalPrice;
        }
    }
}