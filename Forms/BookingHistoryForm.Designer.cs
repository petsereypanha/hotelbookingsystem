using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using HotelManagementSystem.Data.Repositories;
using HotelManagementSystem.Patterns.Singleton;
using HotelManagementSystem.Services;

namespace HotelManagementSystem.Forms;

partial class BookingHistoryForm
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
        label1 = new Label();
        dgvBookingHistory = new DataGridView();
        dgvBookingHistory.ReadOnly = true;
        Column2 = new DataGridViewTextBoxColumn();
        Column3 = new DataGridViewTextBoxColumn();
        Column4 = new DataGridViewTextBoxColumn();
        Column5 = new DataGridViewTextBoxColumn();
        Column6 = new DataGridViewTextBoxColumn();
        Column8 = new DataGridViewTextBoxColumn();
        label2 = new Label();
        btnSortByDate = new Button();
        btnSortByPaymentStatus = new Button();
        btnReset = new Button();
    
        ((System.ComponentModel.ISupportInitialize)dgvBookingHistory).BeginInit();
        SuspendLayout();
        
        // label1
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Historic", 20F, FontStyle.Bold);
        label1.ForeColor = Color.DarkRed;
        label1.Location = new Point(33, 30);
        label1.Name = "label1";
        label1.Size = new Size(221, 37);
        label1.TabIndex = 22;
        label1.Text = "Booking History";
        
        // dgvBookingHistory
        // In InitializeComponent() or constructor
        dgvBookingHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvBookingHistory.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column8 });
        dgvBookingHistory.Location = new Point(16, 143);
        dgvBookingHistory.Name = "dgvBookingHistory";
        dgvBookingHistory.Size = new Size(1165, 509);
        dgvBookingHistory.TabIndex = 21;
        
        // Column2
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Column2.HeaderText = "Booking ID";
        Column2.Name = "Column2";
        
        // Column3
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Column3.HeaderText = "Customer";
        Column3.Name = "Column3";
        
        // Column4
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Column4.HeaderText = "Room ID";
        Column4.Name = "Column4";
        
        // Column5
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Column5.HeaderText = "Start Date";
        Column5.Name = "Column5";
        
        // Column6
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Column6.HeaderText = "End Date";
        Column6.Name = "Column6";
        
        // Column8
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Column8.HeaderText = "Payment Status";
        Column8.Name = "Column8";
        
        // label2
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 13F);
        label2.Location = new Point(660, 83);
        label2.Name = "label2";
        label2.Size = new Size(69, 25);
        label2.TabIndex = 23;
        label2.Text = "Sort By";
        
        // btnSortByDate
        btnSortByDate.Font = new Font("Segoe UI", 11F);
        btnSortByDate.Location = new Point(757, 74);
        btnSortByDate.Name = "btnSortByDate";
        btnSortByDate.Size = new Size(131, 43);
        btnSortByDate.TabIndex = 24;
        btnSortByDate.Text = "Date";
        btnSortByDate.UseVisualStyleBackColor = true;
        
        // btnSortByPaymentStatus
        btnSortByPaymentStatus.Font = new Font("Segoe UI", 11F);
        btnSortByPaymentStatus.Location = new Point(894, 74);
        btnSortByPaymentStatus.Name = "btnSortByPaymentStatus";
        btnSortByPaymentStatus.Size = new Size(171, 43);
        btnSortByPaymentStatus.TabIndex = 25;
        btnSortByPaymentStatus.Text = "Payment Status";
        btnSortByPaymentStatus.UseVisualStyleBackColor = true;
        
        // btnReset
        btnReset.Font = new Font("Segoe UI", 11F);
        btnReset.Location = new Point(1071, 74);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(108, 43);
        btnReset.TabIndex = 26;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = true;
        
        // BookingHistoryForm
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1197, 682);
        Controls.Add(btnReset);
        Controls.Add(btnSortByPaymentStatus);
        Controls.Add(btnSortByDate);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(dgvBookingHistory);
        Name = "BookingHistoryForm";
        Size = new Size(1197, 682);
        this.Load += UserControlHistory_Load;
        ((System.ComponentModel.ISupportInitialize)dgvBookingHistory).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private DataGridView dgvBookingHistory;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column6;
    private DataGridViewTextBoxColumn Column8;
    private Label label2;
    private Button btnSortByDate;
    private Button btnSortByPaymentStatus;
    private Button btnReset;
    
}