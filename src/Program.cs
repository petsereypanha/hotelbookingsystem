using System;
using System.Windows.Forms;
using HotelBookingSystem.Forms;

namespace HotelBookingSystem
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            ServiceProvider = Startup.ConfigureServices();
            Application.Run(new HomeForm());
        }
    }
}