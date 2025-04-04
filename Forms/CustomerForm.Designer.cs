using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace HotelManagementSystem.Forms
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
            private void InitializeComponent()
        {
            lblCustomers = new Label();
            dgvCustomers = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            
            btnAddCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnDeleteCustomer = new Button();
            
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            //        
        
            // lblCustomers
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCustomers.ForeColor = Color.DarkBlue;
            lblCustomers.Location = new Point(44, 33);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(154, 37);
            lblCustomers.Text = "Customers";
            
            // dgvCustomers - Positioned on left side
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvCustomers.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvCustomers.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colEmail, colPhone, colAddress });
            dgvCustomers.Location = new Point(44, 95);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(592, 436);
            dgvCustomers.TabIndex = 0;
            
            // colID
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            
            // colName
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            
            // colEmail
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            
            // colPhone
            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            
            // colAddress
            colAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAddress.HeaderText = "Address";
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            
            // Input fields placed on right side
            // Customer ID label and input
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(736, 149);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.ForeColor = Color.DarkBlue;
        
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.Location = new Point(876, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 32);
            txtName.TabIndex = 1;
            
            // Customer Email label and input
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(736, 195);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(876, 195);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 32);
            txtEmail.TabIndex = 3;
            
            // Customer Phone label and input
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(736, 249);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 4;
            label3.Text = "Phone:";
            
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(876, 246);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(166, 32);
            txtPhone.TabIndex = 5;
            
            // Customer Address label and input
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(736, 300);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 6;
            label4.Text = "Address:";
            
            txtAddress.Font = new Font("Segoe UI", 14F);
            txtAddress.Location = new Point(876, 300);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(266, 32);
            txtAddress.TabIndex = 7;
            txtAddress.Multiline = true;
            txtAddress.Height = 60;
            
            // Action buttons at bottom right
            // Style the Add button with green theme
            btnAddCustomer.BackColor = Color.MediumSeaGreen;
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.Font = new Font("Segoe UI", 12F);
            btnAddCustomer.Location = new Point(673, 494);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(140, 37);
            btnAddCustomer.TabIndex = 8;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            
            // Style the Update button with blue theme
            btnUpdateCustomer.BackColor = Color.RoyalBlue;
            btnUpdateCustomer.ForeColor = Color.White;
            btnUpdateCustomer.FlatStyle = FlatStyle.Flat;
            btnUpdateCustomer.FlatAppearance.BorderSize = 0;
            btnUpdateCustomer.Font = new Font("Segoe UI", 12F);
            btnUpdateCustomer.Location = new Point(858, 494);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(140, 37);
            btnUpdateCustomer.TabIndex = 9;
            btnUpdateCustomer.Text = "Update Customer";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            
            // Style the Delete button with red theme
            btnDeleteCustomer.BackColor = Color.IndianRed;
            btnDeleteCustomer.ForeColor = Color.White;
            btnDeleteCustomer.FlatStyle = FlatStyle.Flat;
            btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            btnDeleteCustomer.Font = new Font("Segoe UI", 12F);
            btnDeleteCustomer.Location = new Point(1043, 494);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(140, 37);
            btnDeleteCustomer.TabIndex = 10;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            
            // CustomerForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 582);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(dgvCustomers);
            Controls.Add(lblCustomers);
            Name = "CustomerForm";
            Text = "Customer Management";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomers;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAddress;
        private GroupBox groupBox1;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Button btnAddCustomer;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
    }
}