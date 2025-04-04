using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HotelManagementSystem.Forms;

namespace HotelManagementSystem.Forms
{
    partial class MainForm
    {
        private IContainer components = null;

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
            sidePanel = new Panel();
            contentPanel = new Panel(); // Add a content panel to host the active form
            btnRoomDetail = new Button();
            lblTitle = new Label();
            btnCustomers = new Button();
            btnDashboard = new Button();
            btnHistory = new Button();
            btnRoomBook = new Button();
            sidePanel.SuspendLayout();
            SuspendLayout();
            
            // contentPanel
            contentPanel.Location = new Point(255, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1197, 682);
            contentPanel.TabIndex = 1;
            
            // sidePanel
            sidePanel.BackColor = Color.Silver;
            sidePanel.Controls.Add(btnRoomDetail);
            sidePanel.Controls.Add(lblTitle);
            sidePanel.Controls.Add(btnCustomers);
            sidePanel.Controls.Add(btnDashboard);
            sidePanel.Controls.Add(btnHistory);
            sidePanel.Controls.Add(btnRoomBook);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(255, 682);
            sidePanel.TabIndex = 0;
            
            // btnRoomDetail
            btnRoomDetail.Font = new Font("Segoe UI", 15F);
            btnRoomDetail.Location = new Point(3, 367);
            btnRoomDetail.Name = "btnRoomDetail";
            btnRoomDetail.Size = new Size(249, 62);
            btnRoomDetail.TabIndex = 5;
            btnRoomDetail.Text = "Room Detail";
            btnRoomDetail.UseVisualStyleBackColor = true;
            
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkRed;
            lblTitle.Location = new Point(3, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 20);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Hotel Management System";
            
            // btnDashboard
            btnDashboard.Font = new Font("Segoe UI", 15F);
            btnDashboard.Location = new Point(3, 95);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(249, 62);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            
            // btnRoomBook
            btnRoomBook.Font = new Font("Segoe UI", 15F);
            btnRoomBook.Location = new Point(3, 163);
            btnRoomBook.Name = "btnRoomBook";
            btnRoomBook.Size = new Size(249, 62);
            btnRoomBook.TabIndex = 1;
            btnRoomBook.Text = "Room Booking";
            btnRoomBook.UseVisualStyleBackColor = true;
            
            // btnHistory
            btnHistory.Font = new Font("Segoe UI", 15F);
            btnHistory.Location = new Point(3, 231);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(249, 62);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "Booking History";
            btnHistory.UseVisualStyleBackColor = true;
            
            // btnCustomers
            btnCustomers.Font = new Font("Segoe UI", 15F);
            btnCustomers.Location = new Point(3, 299);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(249, 62);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            
            // MainForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1652, 782);
            Controls.Add(contentPanel);
            Controls.Add(sidePanel);
            Name = "MainForm";
            Text = "Hotel Management System";
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ResumeLayout(false);
        }

        // Update the field declarations at the bottom of the file
        private Panel sidePanel;
        private Panel contentPanel;
        private Button btnRoomBook;
        private Label lblTitle;
        private Button btnCustomers;
        private Button btnDashboard;
        private Button btnHistory;
        private Button btnRoomDetail;
    }
}