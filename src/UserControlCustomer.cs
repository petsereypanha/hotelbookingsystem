using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Models;
using HotelBookingSystem.Services.Facade;


namespace HotelBookingSystem
{
    public partial class UserControlCustomer : UserControl
    {
        BookingFacade _BookingFacade;
        public UserControlCustomer()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            

            Customer customer1 = new Customer
            {
                CustomerId = 1,
                Name = "John Doe",
                Email = "johndoe@example.com",
                Phone = "123-456-7890",
                Address = "123 Main St, City, Country"
            };

            
                _BookingFacade.AddCustomer(customer1);

            
        }
    }
}
