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
    public partial class RoomDetailForm : Form
    {
        private readonly RoomService _roomService;
        private List<Room> _rooms;

        public RoomDetailForm()
        {
            InitializeComponent();
            
            // Initialize services
            var dbSingleton = DatabaseSingleton.Instance;
            var roomRepository = new RoomRepository(dbSingleton);
            _roomService = new RoomService(roomRepository);
            
            // Set form load event
            this.Load += RoomDetailForm_Load;
            
            // Wire up button events
            btnAddRoom.Click += btnAddRoom_Click;
            btnUpdateRoom.Click += btnUpdateRoom_Click;
            
            // Wire up grid selection change event
            dgvHotelList.SelectionChanged += dgvHotelList_SelectionChanged;
            
            // Setup comboboxes
            cbRoomType.SelectedIndex = 0;
            cbIsAvailable.SelectedIndex = 0;
        }
        
        private void RoomDetailForm_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void LoadRooms()
        {
            try
            {
                // Get all rooms from service
                _rooms = _roomService.GetAllRooms().ToList();
                
                // Clear grid
                dgvHotelList.SuspendLayout();
                dgvHotelList.Rows.Clear();
                
                if (_rooms == null || _rooms.Count == 0)
                {
                    label1.Text = "Room Detail (No Records Found)";
                    dgvHotelList.ResumeLayout();
                    return;
                }
                
                // Update label with count
                label1.Text = $"Room Detail ({_rooms.Count} records)";
                
                // Add rooms to grid
                foreach (var room in _rooms)
                {
                    try
                    {
                        dgvHotelList.Rows.Add(
                            room.Room_ID,
                            room.Room_Type ?? "Standard",
                            room.Price.ToString("C"),
                            room.AvailabilityStatus ? "Available" : "Not Available"
                        );
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error adding room {room.Room_ID} to grid: {ex.Message}");
                    }
                }
                
                // Auto-size columns and select first row if available
                dgvHotelList.AutoResizeColumns();
                if (dgvHotelList.Rows.Count > 0)
                {
                    dgvHotelList.CurrentCell = dgvHotelList.Rows[0].Cells[0];
                    UpdateSelectedRoom();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Exception in LoadRooms: {ex}");
            }
            finally
            {
                dgvHotelList.ResumeLayout();
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (cbRoomType.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a room type", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (!decimal.TryParse(txtRoomPrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Please enter a valid price", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (cbIsAvailable.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select availability status", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Create new room
                var room = new Room
                {
                    Room_Type = cbRoomType.Text,
                    Price = price,
                    AvailabilityStatus = cbIsAvailable.Text == "Yes"
                };
                
                // Add to database
                _roomService.AddRoom(room);
                
                // Clear fields
                ClearFields();
                
                // Refresh grid
                LoadRooms();
                
                MessageBox.Show("Room added successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding room: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a room is selected
                if (dgvHotelList.CurrentRow == null)
                {
                    MessageBox.Show("Please select a room to update", "Selection Required", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Validate inputs
                if (!int.TryParse(txtRoomId.Text, out int roomId) || roomId <= 0)
                {
                    MessageBox.Show("Invalid room ID", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (cbRoomType.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a room type", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (!decimal.TryParse(txtRoomPrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Please enter a valid price", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (cbIsAvailable.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select availability status", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Create updated room
                var room = new Room
                {
                    Room_ID = roomId,
                    Room_Type = cbRoomType.Text,
                    Price = price,
                    AvailabilityStatus = cbIsAvailable.Text == "Yes"
                };
                
                // Update in database
                _roomService.UpdateRoom(room);
                
                // Refresh grid
                LoadRooms();
                
                MessageBox.Show("Room updated successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating room: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHotelList_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedRoom();
        }
        
        private void UpdateSelectedRoom()
        {
            // Check if a row is selected
            if (dgvHotelList.CurrentRow != null)
            {
                try
                {
                    // Get data from selected row
                    txtRoomId.Text = dgvHotelList.CurrentRow.Cells[0].Value?.ToString() ?? "";
                    
                    string roomType = dgvHotelList.CurrentRow.Cells[1].Value?.ToString() ?? "";
                    for (int i = 0; i < cbRoomType.Items.Count; i++)
                    {
                        if (cbRoomType.Items[i].ToString() == roomType)
                        {
                            cbRoomType.SelectedIndex = i;
                            break;
                        }
                    }
                    
                    // Remove currency symbol for price
                    string priceText = dgvHotelList.CurrentRow.Cells[2].Value?.ToString() ?? "";
                    decimal price;
                    if (decimal.TryParse(priceText.Replace("$", "").Replace(",", ""), out price))
                    {
                        txtRoomPrice.Text = price.ToString();
                    }
                    
                    string availabilityStatus = dgvHotelList.CurrentRow.Cells[3].Value?.ToString() ?? "";
                    cbIsAvailable.SelectedIndex = availabilityStatus == "Available" ? 0 : 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating fields from selection: {ex.Message}");
                }
            }
        }
        
        private void ClearFields()
        {
            txtRoomId.Text = string.Empty;
            cbRoomType.SelectedIndex = 0;
            txtRoomPrice.Text = string.Empty;
            cbIsAvailable.SelectedIndex = 0;
        }
    }
}