using System.Drawing;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblHotelList = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbBedCount = new System.Windows.Forms.ComboBox();
            this.txtSelectedRoom = new System.Windows.Forms.TextBox();
            this.lblSelectedRoom = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.chkGymSpa = new System.Windows.Forms.CheckBox();
            this.chkBarAccess = new System.Windows.Forms.CheckBox();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.lblAdditionalOptions = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.dgvHotelList = new System.Windows.Forms.DataGridView();
            this.colRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBookingTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelList)).BeginInit();
            this.SuspendLayout();
            
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(646, 225);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(66, 13);
            this.lblBookingID.TabIndex = 0;
            this.lblBookingID.Text = "Booking ID:";
            this.lblBookingID.Visible = false;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(775, 320);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(153, 20);
            this.txtBookingID.TabIndex = 1;
            this.txtBookingID.Visible = false;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(646, 225);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(96, 13);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "Guest Name";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(775, 320);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(153, 20);
            this.txtCustomerID.TabIndex = 3;
            this.txtCustomerID.Visible = false;
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(646, 272);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(114, 13);
            this.lblRoomID.TabIndex = 4;
            this.lblRoomID.Text = "Selected Room";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(775, 270);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(153, 20);
            this.txtRoomID.TabIndex = 5;
            this.txtRoomID.Enabled = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(644, 169);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(47, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "From";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(697, 169);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(191, 20);
            this.dtpStartDate.TabIndex = 7;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(903, 170);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(25, 13);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "To";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(944, 169);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(191, 20);
            this.dtpEndDate.TabIndex = 9;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(1014, 577);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(140, 37);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Confirm Booking";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(905, 577);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Reset";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFilter.Location = new System.Drawing.Point(272, 116);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(45, 21);
            this.lblFilter.TabIndex = 46;
            this.lblFilter.Text = "Filter";
            // 
            // lblHotelList
            // 
            this.lblHotelList.AutoSize = true;
            this.lblHotelList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHotelList.Location = new System.Drawing.Point(31, 169);
            this.lblHotelList.Name = "lblHotelList";
            this.lblHotelList.Size = new System.Drawing.Size(75, 21);
            this.lblHotelList.TabIndex = 45;
            this.lblHotelList.Text = "Hotel List";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalAmount.Location = new System.Drawing.Point(1077, 426);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(58, 21);
            this.lblTotalAmount.TabIndex = 44;
            this.lblTotalAmount.Text = "$99.99";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotal.Location = new System.Drawing.Point(1029, 426);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 21);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "Total";
            // 
            // cmbBedCount
            // 
            this.cmbBedCount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbBedCount.FormattingEnabled = true;
            this.cmbBedCount.Items.AddRange(new object[] { "1 Bed", "2 Bed" });
            this.cmbBedCount.Location = new System.Drawing.Point(487, 113);
            this.cmbBedCount.Name = "cmbBedCount";
            this.cmbBedCount.Size = new System.Drawing.Size(136, 29);
            this.cmbBedCount.TabIndex = 42;
            // 
            // txtSelectedRoom
            // 
            this.txtSelectedRoom.Enabled = false;
            this.txtSelectedRoom.Location = new System.Drawing.Point(775, 270);
            this.txtSelectedRoom.Name = "txtSelectedRoom";
            this.txtSelectedRoom.Size = new System.Drawing.Size(153, 20);
            this.txtSelectedRoom.TabIndex = 41;
            // 
            // lblSelectedRoom
            // 
            this.lblSelectedRoom.AutoSize = true;
            this.lblSelectedRoom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSelectedRoom.Location = new System.Drawing.Point(646, 272);
            this.lblSelectedRoom.Name = "lblSelectedRoom";
            this.lblSelectedRoom.Size = new System.Drawing.Size(114, 21);
            this.lblSelectedRoom.TabIndex = 40;
            this.lblSelectedRoom.Text = "Selected Room";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(775, 227);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(153, 20);
            this.txtGuestName.TabIndex = 35;
            // 
            // chkGymSpa
            // 
            this.chkGymSpa.AutoSize = true;
            this.chkGymSpa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkGymSpa.Location = new System.Drawing.Point(897, 324);
            this.chkGymSpa.Name = "chkGymSpa";
            this.chkGymSpa.Size = new System.Drawing.Size(122, 25);
            this.chkGymSpa.TabIndex = 34;
            this.chkGymSpa.Text = "Gym and Spa";
            this.chkGymSpa.UseVisualStyleBackColor = true;
            // 
            // chkBarAccess
            // 
            this.chkBarAccess.AutoSize = true;
            this.chkBarAccess.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkBarAccess.Location = new System.Drawing.Point(1033, 324);
            this.chkBarAccess.Name = "chkBarAccess";
            this.chkBarAccess.Size = new System.Drawing.Size(102, 25);
            this.chkBarAccess.TabIndex = 33;
            this.chkBarAccess.Text = "Bar Access";
            this.chkBarAccess.UseVisualStyleBackColor = true;
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkBreakfast.Location = new System.Drawing.Point(798, 324);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(93, 25);
            this.chkBreakfast.TabIndex = 32;
            this.chkBreakfast.Text = "Breakfast";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // lblAdditionalOptions
            // 
            this.lblAdditionalOptions.AutoSize = true;
            this.lblAdditionalOptions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAdditionalOptions.Location = new System.Drawing.Point(646, 320);
            this.lblAdditionalOptions.Name = "lblAdditionalOptions";
            this.lblAdditionalOptions.Size = new System.Drawing.Size(133, 21);
            this.lblAdditionalOptions.TabIndex = 31;
            this.lblAdditionalOptions.Text = "Additional Option";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGuestName.Location = new System.Drawing.Point(646, 225);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(96, 21);
            this.lblGuestName.TabIndex = 27;
            this.lblGuestName.Text = "Guest Name";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] { "Standard", "Deluxe" });
            this.cmbRoomType.Location = new System.Drawing.Point(332, 113);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(136, 29);
            this.cmbRoomType.TabIndex = 25;
            //

            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            // Configure properties similar to other ComboBoxes
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(775, 225);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(153, 29);
            this.cmbCustomer.TabIndex = 51;
            // 
            // dgvHotelList
            // 
            dgvHotelList.BorderStyle = BorderStyle.None;
            dgvHotelList.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvHotelList.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvHotelList.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvHotelList.EnableHeadersVisualStyles = false;
            dgvHotelList.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvHotelList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvHotelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotelList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colRoomId, this.colRoomType, this.colBedCount });
            this.dgvHotelList.Location = new System.Drawing.Point(31, 209);
            this.dgvHotelList.Name = "dgvHotelList";
            this.dgvHotelList.Size = new System.Drawing.Size(592, 436);
            this.dgvHotelList.TabIndex = 49;
            // 
            // colRoomId
            // 
            this.colRoomId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomId.HeaderText = "Room ID";
            this.colRoomId.Name = "colRoomId";
            // 
            // colRoomType
            // 
            this.colRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomType.HeaderText = "Room Type (Standard/Premium)";
            this.colRoomType.Name = "colRoomType";
            // 
            // colBedCount
            // 
            this.colBedCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBedCount.HeaderText = "Bed Count(1/2)";
            this.colBedCount.Name = "colBedCount";
            // 
            // lblBookingTitle
            // 
            this.lblBookingTitle.AutoSize = true;
            this.lblBookingTitle.Font = new System.Drawing.Font("Segoe UI Historic", 20F, System.Drawing.FontStyle.Bold);
            this.lblBookingTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBookingTitle.Location = new System.Drawing.Point(31, 36);
            this.lblBookingTitle.Name = "lblBookingTitle";
            this.lblBookingTitle.Size = new System.Drawing.Size(226, 37);
            this.lblBookingTitle.TabIndex = 50;
            this.lblBookingTitle.Text = "Booking Room...";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.lblBookingTitle);
            this.Controls.Add(this.dgvHotelList);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblHotelList);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbBedCount);
            this.Controls.Add(this.txtSelectedRoom);
            this.Controls.Add(this.lblSelectedRoom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.chkGymSpa);
            this.Controls.Add(this.chkBarAccess);
            this.Controls.Add(this.chkBreakfast);
            this.Controls.Add(this.lblAdditionalOptions);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.cmbCustomer);
            this.Name = "BookingForm";
            this.Text = "Booking Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblHotelList;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbBedCount;
        private System.Windows.Forms.TextBox txtSelectedRoom;
        private System.Windows.Forms.Label lblSelectedRoom;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.CheckBox chkGymSpa;
        private System.Windows.Forms.CheckBox chkBarAccess;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.Label lblAdditionalOptions;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.DataGridView dgvHotelList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBedCount;
        private System.Windows.Forms.Label lblBookingTitle;
        private System.Windows.Forms.ComboBox cmbCustomer;
    }
}