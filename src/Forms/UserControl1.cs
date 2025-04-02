using HotelBookingSystem.Data;
using HotelBookingSystem.Models;

namespace HotelBookingSystem
{
    public partial class UserControl1 : UserControl
    {
        private readonly DatabaseContext _context;
        
        private decimal _totalPrice = 0.00M;

        public UserControl1()
        {
            InitializeComponent();
        }

        
        private void SetupEventHandlers()
        {
            // Load event
            this.Load += UserControl1_Load;

            // Filter controls
            comboBox1.SelectedIndexChanged += Filter_Changed;
            comboBox2.SelectedIndexChanged += Filter_Changed;

            // Date controls
            dateTimePicker1.ValueChanged += DatePicker_ValueChanged;
            dateTimePicker2.ValueChanged += DatePicker_ValueChanged;

            // Buttons
            button1.Click += ConfirmBooking_Click;
            button2.Click += Reset_Click;

            // DataGridView
            dgvHotelList.SelectionChanged += DgvHotelList_SelectionChanged;

            // Additional options
            checkBox1.CheckedChanged += CalculateTotalPrice;
            checkBox2.CheckedChanged += CalculateTotalPrice;
            checkBox3.CheckedChanged += CalculateTotalPrice;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Set minimum dates for date pickers
                dateTimePicker1.MinDate = DateTime.Today;
                dateTimePicker1.Value = DateTime.Today;
                dateTimePicker2.MinDate = DateTime.Today.AddDays(1);
                dateTimePicker2.Value = DateTime.Today.AddDays(1);

                // Load available rooms
                LoadRoomList();
            }
            catch (Exception ex)
            {
                ShowError("Error initializing form: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void LoadRoomList()
        {
            try
            {
                dgvHotelList.Rows.Clear();

                var checkIn = dateTimePicker1.Value;
                var checkOut = dateTimePicker2.Value;
                string roomType = comboBox1.SelectedItem?.ToString() ?? string.Empty;
                string bedCount = comboBox2.SelectedItem?.ToString() ?? string.Empty;

                // Get rooms that are not booked in the selected date range
                var bookedRoomIds = _context.Bookings
                    .Where(b => (checkIn < b.EndDate && checkOut > b.StartDate))
                    .Select(b => b.RoomId)
                    .ToList();

                var availableRoomsQuery = _context.Rooms
                    .Where(r => !bookedRoomIds.Contains(r.RoomId));

                // Apply filters if selected
                if (!string.IsNullOrEmpty(roomType))
                {
                    availableRoomsQuery = availableRoomsQuery.Where(r => r.RoomType == roomType);
                }

                if (!string.IsNullOrEmpty(bedCount))
                {
                    int beds = bedCount.StartsWith("1") ? 1 : 2;
                    availableRoomsQuery = availableRoomsQuery.Where(r => r.BedCount == beds);
                }

                var availableRooms = availableRoomsQuery.ToList();

                foreach (var room in availableRooms)
                {
                    dgvHotelList.Rows.Add(
                        room.RoomId.ToString(),
                        room.RoomType,
                        room.BedCount.ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                ShowError("Error loading rooms: " + ex.Message);
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            LoadRoomList();
        }
        
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            // Ensure checkout date is after checkin date
            if (dateTimePicker2.Value <= dateTimePicker1.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value.AddDays(1);
            }

            // Refresh available rooms
            LoadRoomList();
            
            // Update price calculation
            CalculateTotalPrice(sender, e);
        }

        private void DgvHotelList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHotelList.SelectedRows.Count > 0)
            {
                string roomId = dgvHotelList.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = roomId;
                
                CalculateTotalPrice(sender, e);
            }
        }

        private void CalculateTotalPrice(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox2.Text) && int.TryParse(textBox2.Text, out int roomId))
                {
                    var room = _context.Rooms.FirstOrDefault(r => r.RoomId == roomId);
                    if (room != null)
                    {
                        decimal price = room.Price;
                        int days = (int)(dateTimePicker2.Value - dateTimePicker1.Value).TotalDays;
                        
                        _totalPrice = price * days;
                        
                        // Add costs for additional options
                        if (checkBox1.Checked) _totalPrice += 15.00M; // Breakfast
                        if (checkBox2.Checked) _totalPrice += 10.00M; // Bar access
                        if (checkBox3.Checked) _totalPrice += 20.00M; // Gym and spa
                        
                        label7.Text = $"${_totalPrice:F2}";
                    }
                }
                else
                {
                    label7.Text = "$0.00";
                }
            }
            catch
            {
                label7.Text = "$0.00";
            }
        }

        private void ConfirmBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;
                
                Cursor.Current = Cursors.WaitCursor;
                
                // Create the booking object
                var booking = new Booking
                {
                    CustomerId = GetOrCreateCustomer(),
                    RoomId = int.Parse(textBox2.Text),
                    StartDate = dateTimePicker1.Value.Date,
                    EndDate = dateTimePicker2.Value.Date,
                    PaymentStatus = "Pending",
                    // Add other fields as needed
                };
                
                // Save the booking
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                
                MessageBox.Show("Booking created successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ResetForm();
            }
            catch (Exception ex)
            {
                ShowError("Error creating booking: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        
        private int GetOrCreateCustomer()
        {
            string guestName = textBox1.Text.Trim();
            
            // Check if customer already exists
            var customer = _context.Customers.FirstOrDefault(c => 
                c.Name == guestName);
                
            if (customer != null)
                return customer.CustomerId;
                
            // Create new customer - simplified for this example
            // In a real app, you'd use a form to collect all customer details
            string[] nameParts = guestName.Split(' ');
            var newCustomer = new Customer
            {
                Name = nameParts.Length > 0 ? nameParts[0] : guestName,
                Email = "", // You might want to add an email field to your form
                Phone = "", // You might want to add a phone field to your form
            };
            
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            
            return newCustomer.CustomerId;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        
        private void ResetForm()
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddDays(1);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            label7.Text = "$0.00";
            dgvHotelList.ClearSelection();
            LoadRoomList();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                ShowWarning("Please enter guest name.");
                textBox1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                ShowWarning("Please select a room.");
                dgvHotelList.Focus();
                return false;
            }

            if (dateTimePicker2.Value <= dateTimePicker1.Value)
            {
                ShowWarning("Check-out date must be after check-in date.");
                dateTimePicker2.Focus();
                return false;
            }

            return true;
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}