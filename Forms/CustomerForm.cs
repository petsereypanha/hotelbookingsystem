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
    public partial class CustomerForm : Form
    {
        private readonly CustomerService _customerService;
        private List<Customer> _customers;

        public CustomerForm()
        {
            InitializeComponent();
            
            // Initialize services
            var dbSingleton = DatabaseSingleton.Instance;
            var customerRepository = new CustomerRepository(dbSingleton);
            _customerService = new CustomerService(customerRepository);
            
            // Set form load event
            this.Load += CustomerForm_Load;
            
            // Wire up button events if not already done in designer
            btnAddCustomer.Click += btnAddCustomer_Click;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            
            // Wire up selection change event
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
        }
        
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            btnAddCustomer.Visible = true;
            btnUpdateCustomer.Visible = true;
            btnDeleteCustomer.Visible = true;
            
            btnAddCustomer.Enabled = true;
            btnUpdateCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                // Get all customers from service
                _customers = _customerService.GetAllCustomers().ToList();
                
                // Clear grid
                dgvCustomers.SuspendLayout();
                dgvCustomers.Rows.Clear();
                
                if (_customers == null || _customers.Count == 0)
                {
                    lblCustomers.Text = "Customers (No Records Found)";
                    dgvCustomers.ResumeLayout();
                    return;
                }
                
                // Update label with count
                lblCustomers.Text = $"Customers ({_customers.Count} records)";
                
                // Add rows to grid
                foreach (var customer in _customers)
                {
                    try
                    {
                        dgvCustomers.Rows.Add(
                            customer.ID,
                            customer.Name ?? "Unknown",
                            customer.Email ?? "Unknown",
                            customer.Phone ?? "Unknown",
                            customer.Address ?? "Unknown"
                        );
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error adding customer {customer.ID} to grid: {ex.Message}");
                    }
                }
                
                // Auto-size columns and select first row
                dgvCustomers.AutoResizeColumns();
                if (dgvCustomers.Rows.Count > 0)
                {
                    dgvCustomers.CurrentCell = dgvCustomers.Rows[0].Cells[0];
                    UpdateSelectedCustomer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Exception in LoadCustomers: {ex}");
            }
            finally
            {
                dgvCustomers.ResumeLayout();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter a name", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Create new customer
                var customer = new Customer
                {
                    Name = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };
                
                // Add to database
                _customerService.AddCustomer(customer);
                
                // Clear fields
                ClearFields();
                
                // Refresh grid
                LoadCustomers();
                
                MessageBox.Show("Customer added successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding customer: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a customer is selected
                if (dgvCustomers.CurrentRow == null)
                {
                    MessageBox.Show("Please select a customer to update", "Selection Required", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter a name", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Get selected customer ID
                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);
                
                // Create updated customer
                var customer = new Customer
                {
                    ID = customerId,
                    Name = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };
                
                // Update in database
                _customerService.UpdateCustomer(customer);
                
                // Refresh grid
                LoadCustomers();
                
                MessageBox.Show("Customer updated successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a customer is selected
                if (dgvCustomers.CurrentRow == null)
                {
                    MessageBox.Show("Please select a customer to delete", "Selection Required", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Get selected customer ID
                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);
                string customerName = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                
                // Confirm deletion
                var result = MessageBox.Show($"Are you sure you want to delete customer {customerName}?", 
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                if (result == DialogResult.Yes)
                {
                    // Delete from database
                    _customerService.DeleteCustomer(customerId);
                    
                    // Clear fields
                    ClearFields();
                    
                    // Refresh grid
                    LoadCustomers();
                    
                    MessageBox.Show("Customer deleted successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedCustomer();
        }
        
        private void UpdateSelectedCustomer()
        {
            // Check if a row is selected
            if (dgvCustomers.CurrentRow != null)
            {
                try
                {
                    // Get data from selected row
                    txtName.Text = dgvCustomers.CurrentRow.Cells[1].Value?.ToString() ?? "";
                    txtEmail.Text = dgvCustomers.CurrentRow.Cells[2].Value?.ToString() ?? "";
                    txtPhone.Text = dgvCustomers.CurrentRow.Cells[3].Value?.ToString() ?? "";
                    txtAddress.Text = dgvCustomers.CurrentRow.Cells[4].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating fields from selection: {ex.Message}");
                }
            }
        }
        
        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
    }
}