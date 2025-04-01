using System;
using System.Windows.Forms;
using HotelBookingSystem.Forms;

namespace HotelBookingSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
        }
    }
}