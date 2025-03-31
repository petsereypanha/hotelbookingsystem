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
            this.labelBookingId = new System.Windows.Forms.Label();
            this.textBoxBookingId = new System.Windows.Forms.TextBox();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.labelRoomId = new System.Windows.Forms.Label();
            this.textBoxRoomId = new System.Windows.Forms.TextBox();
            this.labelBookingDate = new System.Windows.Forms.Label();
            this.dateTimePickerBookingDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBookingId
            // 
            this.labelBookingId.AutoSize = true;
            this.labelBookingId.Location = new System.Drawing.Point(12, 15);
            this.labelBookingId.Name = "labelBookingId";
            this.labelBookingId.Size = new System.Drawing.Size(66, 13);
            this.labelBookingId.TabIndex = 0;
            this.labelBookingId.Text = "Booking ID:";
            // 
            // textBoxBookingId
            // 
            this.textBoxBookingId.Location = new System.Drawing.Point(84, 12);
            this.textBoxBookingId.Name = "textBoxBookingId";
            this.textBoxBookingId.Size = new System.Drawing.Size(200, 20);
            this.textBoxBookingId.TabIndex = 1;
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(12, 41);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(72, 13);
            this.labelCustomerId.TabIndex = 2;
            this.labelCustomerId.Text = "Customer ID:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(84, 38);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(200, 20);
            this.textBoxCustomerId.TabIndex = 3;
            // 
            // labelRoomId
            // 
            this.labelRoomId.AutoSize = true;
            this.labelRoomId.Location = new System.Drawing.Point(12, 67);
            this.labelRoomId.Name = "labelRoomId";
            this.labelRoomId.Size = new System.Drawing.Size(54, 13);
            this.labelRoomId.TabIndex = 4;
            this.labelRoomId.Text = "Room ID:";
            // 
            // textBoxRoomId
            // 
            this.textBoxRoomId.Location = new System.Drawing.Point(84, 64);
            this.textBoxRoomId.Name = "textBoxRoomId";
            this.textBoxRoomId.Size = new System.Drawing.Size(200, 20);
            this.textBoxRoomId.TabIndex = 5;
            // 
            // labelBookingDate
            // 
            this.labelBookingDate.AutoSize = true;
            this.labelBookingDate.Location = new System.Drawing.Point(12, 93);
            this.labelBookingDate.Name = "labelBookingDate";
            this.labelBookingDate.Size = new System.Drawing.Size(76, 13);
            this.labelBookingDate.TabIndex = 6;
            this.labelBookingDate.Text = "Booking Date:";
            // 
            // dateTimePickerBookingDate
            // 
            this.dateTimePickerBookingDate.Location = new System.Drawing.Point(84, 90);
            this.dateTimePickerBookingDate.Name = "dateTimePickerBookingDate";
            this.dateTimePickerBookingDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBookingDate.TabIndex = 7;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(84, 116);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 151);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.dateTimePickerBookingDate);
            this.Controls.Add(this.labelBookingDate);
            this.Controls.Add(this.textBoxRoomId);
            this.Controls.Add(this.labelRoomId);
            this.Controls.Add(this.textBoxCustomerId);
            this.Controls.Add(this.labelCustomerId);
            this.Controls.Add(this.textBoxBookingId);
            this.Controls.Add(this.labelBookingId);
            this.Name = "BookingForm";
            this.Text = "Booking Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelBookingId;
        private System.Windows.Forms.TextBox textBoxBookingId;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Label labelRoomId;
        private System.Windows.Forms.TextBox textBoxRoomId;
        private System.Windows.Forms.Label labelBookingDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookingDate;
        private System.Windows.Forms.Button buttonSubmit;
    }
}