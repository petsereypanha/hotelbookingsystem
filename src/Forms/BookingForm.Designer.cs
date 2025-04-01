using System.Drawing;
using System.Windows.Forms;

namespace HotelBookingSystem.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.bookingGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxRoomId = new System.Windows.Forms.ComboBox();
            this.comboBoxCustomerId = new System.Windows.Forms.ComboBox();
            this.labelBookingId = new System.Windows.Forms.Label();
            this.textBoxBookingId = new System.Windows.Forms.TextBox();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.labelRoomId = new System.Windows.Forms.Label();
            this.labelBookingDate = new System.Windows.Forms.Label();
            this.dateTimePickerBookingDate = new System.Windows.Forms.DateTimePicker();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.labelCheckOut = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.bookingGroupBox.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 15);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(162, 25);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "New Reservation";
            // 
            // bookingGroupBox
            // 
            this.bookingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingGroupBox.Controls.Add(this.comboBoxRoomId);
            this.bookingGroupBox.Controls.Add(this.comboBoxCustomerId);
            this.bookingGroupBox.Controls.Add(this.labelBookingId);
            this.bookingGroupBox.Controls.Add(this.textBoxBookingId);
            this.bookingGroupBox.Controls.Add(this.labelCustomerId);
            this.bookingGroupBox.Controls.Add(this.labelRoomId);
            this.bookingGroupBox.Controls.Add(this.labelBookingDate);
            this.bookingGroupBox.Controls.Add(this.dateTimePickerBookingDate);
            this.bookingGroupBox.Controls.Add(this.dateTimePickerCheckOut);
            this.bookingGroupBox.Controls.Add(this.labelCheckOut);
            this.bookingGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookingGroupBox.Location = new System.Drawing.Point(12, 50);
            this.bookingGroupBox.Name = "bookingGroupBox";
            this.bookingGroupBox.Size = new System.Drawing.Size(360, 205);
            this.bookingGroupBox.TabIndex = 1;
            this.bookingGroupBox.TabStop = false;
            this.bookingGroupBox.Text = "Booking Details";
            // 
            // comboBoxRoomId
            // 
            this.comboBoxRoomId.FormattingEnabled = true;
            this.comboBoxRoomId.Location = new System.Drawing.Point(140, 88);
            this.comboBoxRoomId.Name = "comboBoxRoomId";
            this.comboBoxRoomId.Size = new System.Drawing.Size(200, 23);
            this.comboBoxRoomId.TabIndex = 3;
            // 
            // comboBoxCustomerId
            // 
            this.comboBoxCustomerId.FormattingEnabled = true;
            this.comboBoxCustomerId.Location = new System.Drawing.Point(140, 58);
            this.comboBoxCustomerId.Name = "comboBoxCustomerId";
            this.comboBoxCustomerId.Size = new System.Drawing.Size(200, 23);
            this.comboBoxCustomerId.TabIndex = 2;
            // 
            // labelBookingId
            // 
            this.labelBookingId.AutoSize = true;
            this.labelBookingId.Location = new System.Drawing.Point(20, 30);
            this.labelBookingId.Name = "labelBookingId";
            this.labelBookingId.Size = new System.Drawing.Size(75, 15);
            this.labelBookingId.TabIndex = 0;
            this.labelBookingId.Text = "Booking ID:";
            // 
            // textBoxBookingId
            // 
            this.textBoxBookingId.Location = new System.Drawing.Point(140, 27);
            this.textBoxBookingId.Name = "textBoxBookingId";
            this.textBoxBookingId.Size = new System.Drawing.Size(200, 23);
            this.textBoxBookingId.TabIndex = 1;
            this.textBoxBookingId.ReadOnly = true;
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(20, 61);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(63, 15);
            this.labelCustomerId.TabIndex = 2;
            this.labelCustomerId.Text = "Customer:";
            // 
            // labelRoomId
            // 
            this.labelRoomId.AutoSize = true;
            this.labelRoomId.Location = new System.Drawing.Point(20, 91);
            this.labelRoomId.Name = "labelRoomId";
            this.labelRoomId.Size = new System.Drawing.Size(42, 15);
            this.labelRoomId.TabIndex = 4;
            this.labelRoomId.Text = "Room:";
            // 
            // labelBookingDate
            // 
            this.labelBookingDate.AutoSize = true;
            this.labelBookingDate.Location = new System.Drawing.Point(20, 121);
            this.labelBookingDate.Name = "labelBookingDate";
            this.labelBookingDate.Size = new System.Drawing.Size(60, 15);
            this.labelBookingDate.TabIndex = 6;
            this.labelBookingDate.Text = "Check In:";
            // 
            // dateTimePickerBookingDate
            // 
            this.dateTimePickerBookingDate.Location = new System.Drawing.Point(140, 118);
            this.dateTimePickerBookingDate.Name = "dateTimePickerBookingDate";
            this.dateTimePickerBookingDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerBookingDate.TabIndex = 4;
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(140, 148);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerCheckOut.TabIndex = 5;
            // 
            // labelCheckOut
            // 
            this.labelCheckOut.AutoSize = true;
            this.labelCheckOut.Location = new System.Drawing.Point(20, 151);
            this.labelCheckOut.Name = "labelCheckOut";
            this.labelCheckOut.Size = new System.Drawing.Size(67, 15);
            this.labelCheckOut.TabIndex = 8;
            this.labelCheckOut.Text = "Check Out:";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPanel.Controls.Add(this.buttonCancel);
            this.buttonPanel.Controls.Add(this.buttonSubmit);
            this.buttonPanel.Location = new System.Drawing.Point(0, 267);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(384, 54);
            this.buttonPanel.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(185, 15);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(285, 15);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(86, 28);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Book Now";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.bookingGroupBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hotel Booking";
            this.bookingGroupBox.ResumeLayout(false);
            this.bookingGroupBox.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox bookingGroupBox;
        private System.Windows.Forms.Label labelBookingId;
        private System.Windows.Forms.TextBox textBoxBookingId;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Label labelRoomId;
        private System.Windows.Forms.Label labelBookingDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookingDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.Label labelCheckOut;
        private System.Windows.Forms.ComboBox comboBoxCustomerId;
        private System.Windows.Forms.ComboBox comboBoxRoomId;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
    }
}