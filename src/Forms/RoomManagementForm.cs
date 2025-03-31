using System;
using System.Windows.Forms;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Forms
{
    public partial class RoomManagementForm : Form
    {
        private readonly DatabaseContext _context;

        public RoomManagementForm(DatabaseContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            // Logic to add a room
        }

        private void EditRoomButton_Click(object sender, EventArgs e)
        {
            // Logic to edit a room
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            // Logic to delete a room
        }

        private void RoomManagementForm_Load(object sender, EventArgs e)
        {
            // Logic to load room data
        }
    }
}