using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelManagementSystem.Data.Repositories;
using HotelManagementSystem.Models;
using HotelManagementSystem.Patterns.Singleton;
using HotelManagementSystem.Services;

namespace HotelManagementSystem.Forms;

public partial class BookingHistoryForm : Form
{
    private readonly BookingService _bookingService;
    private List<BookingHistory> _bookingHistory;
    private readonly BookingHistoryService _bookingHistoryService;

    public BookingHistoryForm()
    {
        InitializeComponent();
        
        var dbSingleton = DatabaseSingleton.Instance;
        var bookingRepository = new BookingRepository(dbSingleton);
        var customerRepository = new CustomerRepository(dbSingleton);
        var roomRepository = new RoomRepository(dbSingleton);
        var bookingHistoryRepository = new BookingHistoryRepository(dbSingleton);
        
        // Initialize the _bookingService that was missing
        _bookingService = new BookingService(bookingRepository, customerRepository, roomRepository);
        _bookingHistoryService = new BookingHistoryService(bookingHistoryRepository, customerRepository, roomRepository);
        
        Load += UserControlHistory_Load;
        btnSortByDate.Click += btnSortByDate_Click;
        btnSortByPaymentStatus.Click += btnSortByPaymentStatus_Click;
        btnReset.Click += btnReset_Click;
        
    }
    private bool _sortDateAscending = true;
    private bool _sortPaymentStatusAscending = true;
    private void UserControlHistory_Load(object sender, EventArgs e)
    {
        LoadBookingData();
    }
    
    private void LoadBookingData()
    {
        try
        {
            _bookingHistory = (List<BookingHistory>)_bookingHistoryService.GetAllBookingHistory();
            DisplayBookingHistory(_bookingHistory);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading booking history: {ex.Message}", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
       private void DisplayBookingHistory(List<BookingHistory> bookings)
    {
        dgvBookingHistory.Rows.Clear();
        
        if (bookings == null || !bookings.Any())
        {
            label1.Text = "Booking History (No Records)";
            return;
        }
        
        label1.Text = $"Booking History ({bookings.Count} Records)";
        
        foreach (var booking in bookings)
        {
            dgvBookingHistory.Rows.Add(
                booking.Booking_ID,
                booking.Customer,
                booking.Room_ID,
                booking.Start_Date.ToShortDateString(),
                booking.End_Date.ToShortDateString(),
                booking.Payment_Status
            );
        }
        
        dgvBookingHistory.AutoResizeColumns();
    }
    
    private void btnSortByDate_Click(object sender, EventArgs e)
    {
        if (_bookingHistory == null || !_bookingHistory.Any())
            return;
            
        if (_sortDateAscending)
            _bookingHistory = _bookingHistory.OrderBy(b => b.Start_Date).ToList();
        else
            _bookingHistory = _bookingHistory.OrderByDescending(b => b.Start_Date).ToList();
            
        _sortDateAscending = !_sortDateAscending;
        DisplayBookingHistory(_bookingHistory);
    }
    
    private void btnSortByPaymentStatus_Click(object sender, EventArgs e)
    {
        if (_bookingHistory == null || !_bookingHistory.Any())
            return;
            
        if (_sortPaymentStatusAscending)
            _bookingHistory = _bookingHistory.OrderBy(b => b.Payment_Status).ToList();
        else
            _bookingHistory = _bookingHistory.OrderByDescending(b => b.Payment_Status).ToList();
            
        _sortPaymentStatusAscending = !_sortPaymentStatusAscending;
        DisplayBookingHistory(_bookingHistory);
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        LoadBookingData();
    }


}