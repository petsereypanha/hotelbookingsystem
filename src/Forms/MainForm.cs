using System;
        using System.Windows.Forms;
        using HotelBookingSystem.Data;

        namespace HotelBookingSystem.Forms
        {
            public partial class MainForm : Form
            {
                private readonly DatabaseContext _context;
        
                public MainForm()
                {
                    InitializeComponent();
                    _context = new DatabaseContext();
                }
        
                private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    var bookingForm = new BookingForm(_context);
                    bookingForm.ShowDialog();
                }
        
                private void customerToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    var customerForm = new CustomerForm(_context);
                    customerForm.ShowDialog();
                }
        
                private void roomManagementToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    var roomManagementForm = new RoomManagementForm(_context);
                    roomManagementForm.ShowDialog();
                }
        
                private void reportToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    var reportForm = new ReportForm(_context);
                    reportForm.ShowDialog();
                }
        
                private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
                {
                    // Clean up resources
                    _context.Dispose();
                }
            }
        }