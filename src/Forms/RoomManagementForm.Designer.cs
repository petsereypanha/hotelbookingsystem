using System.Windows.Forms;

namespace HotelBookingSystem.Forms
{
    partial class RoomManagementForm
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
            this.Text = "Room Management";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Add controls initialization here
        }
    }
}