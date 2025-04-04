using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace HotelManagementSystem.Forms
{
    partial class DashboardForm
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
            this.panelAvailableRooms = new System.Windows.Forms.Panel();
            this.lblAvailableRoomsCount = new System.Windows.Forms.Label();
            this.lblAvailableRoomsTitle = new System.Windows.Forms.Label();
            this.panelRoom2Bed = new System.Windows.Forms.Panel();
            this.lblRoom2BedCount = new System.Windows.Forms.Label();
            this.lblRoom2BedTitle = new System.Windows.Forms.Label();
            this.panelRoom1Bed = new System.Windows.Forms.Panel();
            this.lblRoom1BedCount = new System.Windows.Forms.Label();
            this.lblRoom1BedTitle = new System.Windows.Forms.Label();
            this.panelTotalCustomers = new System.Windows.Forms.Panel();
            this.lblTotalCustomersCount = new System.Windows.Forms.Label();
            this.lblTotalCustomersTitle = new System.Windows.Forms.Label();
            this.panelBookedRooms = new System.Windows.Forms.Panel();
            this.lblBookedRoomsCount = new System.Windows.Forms.Label();
            this.lblBookedRoomsTitle = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.panelAvailableRooms.SuspendLayout();
            this.panelRoom2Bed.SuspendLayout();
            this.panelRoom1Bed.SuspendLayout();
            this.panelTotalCustomers.SuspendLayout();
            this.panelBookedRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAvailableRooms
            // 
            this.panelAvailableRooms.BackColor = System.Drawing.Color.Silver;
            this.panelAvailableRooms.Controls.Add(this.lblAvailableRoomsCount);
            this.panelAvailableRooms.Controls.Add(this.lblAvailableRoomsTitle);
            this.panelAvailableRooms.Location = new System.Drawing.Point(84, 83);
            this.panelAvailableRooms.Name = "panelAvailableRooms";
            this.panelAvailableRooms.Size = new System.Drawing.Size(269, 139);
            this.panelAvailableRooms.TabIndex = 4;
            // 
            // lblAvailableRoomsCount
            // 
            this.lblAvailableRoomsCount.AutoSize = true;
            this.lblAvailableRoomsCount.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblAvailableRoomsCount.Location = new System.Drawing.Point(211, 68);
            this.lblAvailableRoomsCount.Name = "lblAvailableRoomsCount";
            this.lblAvailableRoomsCount.Size = new System.Drawing.Size(40, 32);
            this.lblAvailableRoomsCount.TabIndex = 1;
            this.lblAvailableRoomsCount.Text = "18";
            // 
            // lblAvailableRoomsTitle
            // 
            this.lblAvailableRoomsTitle.AutoSize = true;
            this.lblAvailableRoomsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            this.lblAvailableRoomsTitle.Location = new System.Drawing.Point(3, 17);
            this.lblAvailableRoomsTitle.Name = "lblAvailableRoomsTitle";
            this.lblAvailableRoomsTitle.Size = new System.Drawing.Size(260, 32);
            this.lblAvailableRoomsTitle.TabIndex = 0;
            this.lblAvailableRoomsTitle.Text = "Total Available Room";
            // 
            // panelRoom2Bed
            // 
            this.panelRoom2Bed.BackColor = System.Drawing.Color.Silver;
            this.panelRoom2Bed.Controls.Add(this.lblRoom2BedCount);
            this.panelRoom2Bed.Controls.Add(this.lblRoom2BedTitle);
            this.panelRoom2Bed.Location = new System.Drawing.Point(769, 83);
            this.panelRoom2Bed.Name = "panelRoom2Bed";
            this.panelRoom2Bed.Size = new System.Drawing.Size(269, 139);
            this.panelRoom2Bed.TabIndex = 6;
            // 
            // lblRoom2BedCount
            // 
            this.lblRoom2BedCount.AutoSize = true;
            this.lblRoom2BedCount.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblRoom2BedCount.Location = new System.Drawing.Point(211, 68);
            this.lblRoom2BedCount.Name = "lblRoom2BedCount";
            this.lblRoom2BedCount.Size = new System.Drawing.Size(27, 32);
            this.lblRoom2BedCount.TabIndex = 1;
            this.lblRoom2BedCount.Text = "9";
            // 
            // lblRoom2BedTitle
            // 
            this.lblRoom2BedTitle.AutoSize = true;
            this.lblRoom2BedTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            this.lblRoom2BedTitle.Location = new System.Drawing.Point(18, 17);
            this.lblRoom2BedTitle.Name = "lblRoom2BedTitle";
            this.lblRoom2BedTitle.Size = new System.Drawing.Size(149, 32);
            this.lblRoom2BedTitle.TabIndex = 0;
            this.lblRoom2BedTitle.Text = "Room 2 Bed";
            // 
            // panelRoom1Bed
            // 
            this.panelRoom1Bed.BackColor = System.Drawing.Color.Silver;
            this.panelRoom1Bed.Controls.Add(this.lblRoom1BedCount);
            this.panelRoom1Bed.Controls.Add(this.lblRoom1BedTitle);
            this.panelRoom1Bed.Location = new System.Drawing.Point(431, 83);
            this.panelRoom1Bed.Name = "panelRoom1Bed";
            this.panelRoom1Bed.Size = new System.Drawing.Size(269, 139);
            this.panelRoom1Bed.TabIndex = 5;
            // 
            // lblRoom1BedCount
            // 
            this.lblRoom1BedCount.AutoSize = true;
            this.lblRoom1BedCount.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblRoom1BedCount.Location = new System.Drawing.Point(211, 68);
            this.lblRoom1BedCount.Name = "lblRoom1BedCount";
            this.lblRoom1BedCount.Size = new System.Drawing.Size(27, 32);
            this.lblRoom1BedCount.TabIndex = 1;
            this.lblRoom1BedCount.Text = "9";
            // 
            // lblRoom1BedTitle
            // 
            this.lblRoom1BedTitle.AutoSize = true;
            this.lblRoom1BedTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            this.lblRoom1BedTitle.Location = new System.Drawing.Point(18, 17);
            this.lblRoom1BedTitle.Name = "lblRoom1BedTitle";
            this.lblRoom1BedTitle.Size = new System.Drawing.Size(149, 32);
            this.lblRoom1BedTitle.TabIndex = 0;
            this.lblRoom1BedTitle.Text = "Room 1 Bed";
            // 
            // panelTotalCustomers
            // 
            this.panelTotalCustomers.BackColor = System.Drawing.Color.Silver;
            this.panelTotalCustomers.Controls.Add(this.lblTotalCustomersCount);
            this.panelTotalCustomers.Controls.Add(this.lblTotalCustomersTitle);
            this.panelTotalCustomers.Location = new System.Drawing.Point(431, 270);
            this.panelTotalCustomers.Name = "panelTotalCustomers";
            this.panelTotalCustomers.Size = new System.Drawing.Size(269, 139);
            this.panelTotalCustomers.TabIndex = 7;
            // 
            // lblTotalCustomersCount
            // 
            this.lblTotalCustomersCount.AutoSize = true;
            this.lblTotalCustomersCount.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTotalCustomersCount.Location = new System.Drawing.Point(187, 68);
            this.lblTotalCustomersCount.Name = "lblTotalCustomersCount";
            this.lblTotalCustomersCount.Size = new System.Drawing.Size(40, 32);
            this.lblTotalCustomersCount.TabIndex = 1;
            this.lblTotalCustomersCount.Text = "32";
            // 
            // lblTotalCustomersTitle
            // 
            this.lblTotalCustomersTitle.AutoSize = true;
            this.lblTotalCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            this.lblTotalCustomersTitle.Location = new System.Drawing.Point(18, 17);
            this.lblTotalCustomersTitle.Name = "lblTotalCustomersTitle";
            this.lblTotalCustomersTitle.Size = new System.Drawing.Size(187, 32);
            this.lblTotalCustomersTitle.TabIndex = 0;
            this.lblTotalCustomersTitle.Text = "Total Customer";
            // 
            // panelBookedRooms
            // 
            this.panelBookedRooms.BackColor = System.Drawing.Color.Silver;
            this.panelBookedRooms.Controls.Add(this.lblBookedRoomsCount);
            this.panelBookedRooms.Controls.Add(this.lblBookedRoomsTitle);
            this.panelBookedRooms.Location = new System.Drawing.Point(84, 270);
            this.panelBookedRooms.Name = "panelBookedRooms";
            this.panelBookedRooms.Size = new System.Drawing.Size(269, 139);
            this.panelBookedRooms.TabIndex = 3;
            // 
            // lblBookedRoomsCount
            // 
            this.lblBookedRoomsCount.AutoSize = true;
            this.lblBookedRoomsCount.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblBookedRoomsCount.Location = new System.Drawing.Point(176, 68);
            this.lblBookedRoomsCount.Name = "lblBookedRoomsCount";
            this.lblBookedRoomsCount.Size = new System.Drawing.Size(75, 32);
            this.lblBookedRoomsCount.TabIndex = 1;
            this.lblBookedRoomsCount.Text = "32/50";
            // 
            // lblBookedRoomsTitle
            // 
            this.lblBookedRoomsTitle.AutoSize = true;
            this.lblBookedRoomsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            this.lblBookedRoomsTitle.Location = new System.Drawing.Point(11, 17);
            this.lblBookedRoomsTitle.Name = "lblBookedRoomsTitle";
            this.lblBookedRoomsTitle.Size = new System.Drawing.Size(235, 32);
            this.lblBookedRoomsTitle.TabIndex = 0;
            this.lblBookedRoomsTitle.Text = "Total Booked Room";
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI Historic", 20F, System.Drawing.FontStyle.Bold);
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDashboardTitle.Location = new System.Drawing.Point(47, 28);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(156, 37);
            this.lblDashboardTitle.TabIndex = 52;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 682);
            this.Controls.Add(this.lblDashboardTitle);
            this.Controls.Add(this.panelBookedRooms);
            this.Controls.Add(this.panelRoom2Bed);
            this.Controls.Add(this.panelRoom1Bed);
            this.Controls.Add(this.panelTotalCustomers);
            this.Controls.Add(this.panelAvailableRooms);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.panelAvailableRooms.ResumeLayout(false);
            this.panelAvailableRooms.PerformLayout();
            this.panelRoom2Bed.ResumeLayout(false);
            this.panelRoom2Bed.PerformLayout();
            this.panelRoom1Bed.ResumeLayout(false);
            this.panelRoom1Bed.PerformLayout();
            this.panelTotalCustomers.ResumeLayout(false);
            this.panelTotalCustomers.PerformLayout();
            this.panelBookedRooms.ResumeLayout(false);
            this.panelBookedRooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelAvailableRooms;
        private System.Windows.Forms.Label lblAvailableRoomsCount;
        private System.Windows.Forms.Label lblAvailableRoomsTitle;
        private System.Windows.Forms.Panel panelRoom2Bed;
        private System.Windows.Forms.Label lblRoom2BedCount;
        private System.Windows.Forms.Label lblRoom2BedTitle;
        private System.Windows.Forms.Panel panelRoom1Bed;
        private System.Windows.Forms.Label lblRoom1BedCount;
        private System.Windows.Forms.Label lblRoom1BedTitle;
        private System.Windows.Forms.Panel panelTotalCustomers;
        private System.Windows.Forms.Label lblTotalCustomersCount;
        private System.Windows.Forms.Label lblTotalCustomersTitle;
        private System.Windows.Forms.Panel panelBookedRooms;
        private System.Windows.Forms.Label lblBookedRoomsCount;
        private System.Windows.Forms.Label lblBookedRoomsTitle;
        private System.Windows.Forms.Label lblDashboardTitle;

        #endregion
    }
}

