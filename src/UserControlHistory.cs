using HotelBookingSystem.Data.Repository;
using HotelBookingSystem.Models;
using HotelBookingSystem.Services.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class UserControlHistory : UserControl
    {
        BookingFacade bookingFacade;
        BookingRepository bookingRepository;
        CustomerRepository customerRepository;
        RoomRepository roomRepository;

        public UserControlHistory()
        {
            InitializeComponent();
            /*            bookingFacade = new BookingFacade(new BookingRepository(), customerRepository, roomRepository);*/


        }
        /*public void LoadBookingData()
        {
            List<Booking> booking = bookingFacade.GetAllBookings();

            
            dgvBookingHistory.DataSource = booking;



        }*/

        private void UserControlHistory_Load(object sender, EventArgs e)
        {
            /*LoadBookingData();*/

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
