using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Data;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBookingSystem.Forms
{
    public partial class HomeForm : Form
    {
        private readonly DatabaseContext _context;
        private UserControl1 userControl1;
        public HomeForm()
        {
            InitializeComponent();
            _context = new DatabaseContext();
            this.Load += HomeForm_Load;
            userControlDashboard1.BringToFront();
        }
        
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            userControlCustomer1.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            userControlDashboard1.BringToFront();
        }

        private void btnRoomBook_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            userControlHistory1.BringToFront();
        }
        
       private void HomeForm_Load(object sender, EventArgs e)
        {
            // Get database context from your service provider
            var context = Program.ServiceProvider.GetRequiredService<DatabaseContext>();
            
            // Remove the designer-created control
            Controls.Remove(userControl11);
            userControl11.Dispose();
            
            // Create a new one with proper context
            userControl11 = new UserControl1();
            userControl11.Location = new Point(254, 0);
            userControl11.Size = new Size(1197, 682);
            userControl11.TabIndex = 2;
            Controls.Add(userControl11);
            
            // Set initial view
            userControlDashboard1.BringToFront();
        }
    }
}
