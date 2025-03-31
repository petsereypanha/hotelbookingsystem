using System;
using System.Windows.Forms;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly DatabaseContext _context;

        public CustomerForm(DatabaseContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            // Logic to add a new customer
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            // Logic to edit an existing customer
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            // Logic to delete a customer
        }

        private void LoadCustomers()
        {
            // Logic to load customer records into the form
        }
    }
}