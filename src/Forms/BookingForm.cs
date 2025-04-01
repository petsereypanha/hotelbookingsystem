using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HotelBookingSystem.Data;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Forms
{
    public partial class BookingForm : Form
    {
        private readonly DatabaseContext _context;
        private readonly Color _focusColor = Color.FromArgb(240, 248, 255);
        private readonly Color _accentColor = Color.FromArgb(0, 114, 188);
        private Label labelTotalPrice;
        private Label labelPriceValue;

        public BookingForm(DatabaseContext context)
        {
            InitializeComponent();
            _context = context;

            // Set up form
            ConfigureUIEnhancements();
            SetupEventHandlers();
        }

        private void ConfigureUIEnhancements()
        {
            // Create price calculation panel
            var pricePanel = new Panel
            {
                BackColor = Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(12, 261),
                Size = new Size(200, 30),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };

            labelTotalPrice = new Label
            {
                AutoSize = true,
                Location = new Point(10, 7),
                Text = "Total Price:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };

            labelPriceValue = new Label
            {
                AutoSize = true,
                Location = new Point(90, 7),
                Text = "$0.00",
                ForeColor = _accentColor,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };

            pricePanel.Controls.Add(labelTotalPrice);
            pricePanel.Controls.Add(labelPriceValue);
            this.Controls.Add(pricePanel);

            // Set DropDownStyle for combo boxes
            comboBoxCustomerId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomId.DropDownStyle = ComboBoxStyle.DropDownList;

            // Add tooltips
            var toolTip = new ToolTip();
            toolTip.SetToolTip(dateTimePickerBookingDate, "Check-in date must be today or later");
            toolTip.SetToolTip(dateTimePickerCheckOut, "Check-out date must be after check-in date");
            toolTip.SetToolTip(buttonSubmit, "Create a new booking with the entered details");
        }

        private void SetupEventHandlers()
        {
            // Form events
            this.Load += BookingForm_Load;

            // Button events
            buttonSubmit.Click += ButtonSubmit_Click;
            buttonCancel.Click += ButtonCancel_Click;

            // Date picker events
            dateTimePickerBookingDate.ValueChanged += DateTimePicker_ValueChanged;
            dateTimePickerCheckOut.ValueChanged += DateTimePicker_ValueChanged;

            // ComboBox events
            comboBoxRoomId.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            // Focus events for input controls
            foreach (Control control in bookingGroupBox.Controls)
            {
                if (control is TextBox || control is ComboBox || control is DateTimePicker)
                {
                    control.Enter += Control_Enter;
                    control.Leave += Control_Leave;
                }
            }
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Set minimum dates for date pickers
                dateTimePickerBookingDate.MinDate = DateTime.Today;
                dateTimePickerBookingDate.Value = DateTime.Today;
                dateTimePickerCheckOut.MinDate = DateTime.Today.AddDays(1);
                dateTimePickerCheckOut.Value = DateTime.Today.AddDays(1);
                
                int bookingNumber = _context.Bookings.Any() 
                    ? _context.Bookings.Max(b => b.BookingId) + 1 
                    : 1;

                textBoxBookingId.Text = $"{bookingNumber}";

                // Load customers and rooms
                LoadCustomers();
                LoadAvailableRooms();

                headerLabel.Text = "New Reservation";
                this.Text = "Hotel Booking System";
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

        private void LoadCustomers()
        {
            try
            {
                var customers = _context.Customers.ToList();
                comboBoxCustomerId.DataSource = customers;
                comboBoxCustomerId.DisplayMember = "FullName";
                comboBoxCustomerId.ValueMember = "CustomerId";
            }
            catch (Exception ex)
            {
                ShowError("Error loading customers: " + ex.Message);
            }
        }

        private void LoadAvailableRooms()
        {
            try
            {
                var checkIn = dateTimePickerBookingDate.Value;
                var checkOut = dateTimePickerCheckOut.Value;

                // Get rooms that are not booked in the selected date range
              var bookedRoomIds = _context.Bookings
                  .Where(b => (checkIn < b.EndDate && checkOut > b.StartDate))
                  .Select(b => b.RoomId)
                  .ToList();

                var availableRooms = _context.Rooms
                    .Where(r => !bookedRoomIds.Contains(r.RoomId))
                    .ToList();

                comboBoxRoomId.DataSource = null;
                comboBoxRoomId.DataSource = availableRooms;
                comboBoxRoomId.DisplayMember = "RoomNumber";
                comboBoxRoomId.ValueMember = "RoomId";

                CalculateTotalPrice();
            }
            catch (Exception ex)
            {
                ShowError("Error loading rooms: " + ex.Message);
            }
        }

        private void CalculateTotalPrice()
        {
            try
            {
                if (comboBoxRoomId.SelectedItem != null && comboBoxRoomId.SelectedItem is Room room)
                {
                    // Use Price instead of PricePerNight
                    decimal price = room.Price;
                    
                    int days = (int)(dateTimePickerCheckOut.Value - dateTimePickerBookingDate.Value).TotalDays;
                    decimal totalPrice = price * days;
                    labelPriceValue.Text = $"${totalPrice:F2}";
                }
                else
                {
                    labelPriceValue.Text = "$0.00";
                }
            }
            catch (Exception)
            {
                labelPriceValue.Text = "$0.00";
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Ensure checkout date is after checkin date
            if (dateTimePickerCheckOut.Value <= dateTimePickerBookingDate.Value)
            {
                dateTimePickerCheckOut.Value = dateTimePickerBookingDate.Value.AddDays(1);
            }

            // Refresh available rooms based on new date range
            LoadAvailableRooms();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

      private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;
        
                Cursor.Current = Cursors.WaitCursor;
        
                // Create the booking object with correct property names
                var booking = new Booking
                {
                    // Don't set BookingId - it's auto-generated by SQL Server
                    CustomerId = (int)comboBoxCustomerId.SelectedValue,
                    RoomId = (int)comboBoxRoomId.SelectedValue,
                    StartDate = dateTimePickerBookingDate.Value.Date,
                    EndDate = dateTimePickerCheckOut.Value.Date,
                    PaymentStatus = "Pending" // Required field in your schema
                };
        
                // Save the booking
                _context.Bookings.Add(booking);
                _context.SaveChanges();
        
                MessageBox.Show("Booking created successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        
                DialogResult = DialogResult.OK;
                Close();
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInput()
        {
            if (comboBoxCustomerId.SelectedItem == null)
            {
                ShowWarning("Please select a customer.");
                comboBoxCustomerId.Focus();
                return false;
            }

            if (comboBoxRoomId.SelectedItem == null)
            {
                ShowWarning("Please select a room.");
                comboBoxRoomId.Focus();
                return false;
            }

            if (dateTimePickerCheckOut.Value <= dateTimePickerBookingDate.Value)
            {
                ShowWarning("Check-out date must be after check-in date.");
                dateTimePickerCheckOut.Focus();
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

        private void Control_Enter(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                control.BackColor = _focusColor;
            }
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                control.BackColor = SystemColors.Window;
            }
        }
    }
}