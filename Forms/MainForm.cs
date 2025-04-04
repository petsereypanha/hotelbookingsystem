using System;
using System.Drawing;
using System.Windows.Forms;
using HotelManagementSystem.Data.Repositories;
using HotelManagementSystem.Patterns.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace HotelManagementSystem.Forms
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        
        public MainForm()
        {
            InitializeComponent();
            
            // Add button click events
            btnDashboard.Click += btnDashboard_Click;
            btnRoomBook.Click += btnRoomBook_Click;
            btnHistory.Click += btnHistory_Click;
            btnCustomers.Click += btnCustomers_Click;
            btnRoomDetail.Click += btnRoomDetail_Click;
            
            // Show dashboard by default on startup
            OpenChildForm(new DashboardForm());
        }
        
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm());
        }
        
        private void btnRoomBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookingForm());
        }
        
        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookingHistoryForm());
        }
        
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerForm());
        }
        
        private void btnRoomDetail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoomDetailForm());
        }
    }
}