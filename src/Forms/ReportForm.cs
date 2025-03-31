using System;
using System.Windows.Forms;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Forms
{
    public partial class ReportForm : Form
    {
        private readonly DatabaseContext _context;

        public ReportForm(DatabaseContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void GenerateReport()
        {
            // Logic to generate reports
        }

        private void DisplayReport()
        {
            // Logic to display the generated report
        }
    }
}