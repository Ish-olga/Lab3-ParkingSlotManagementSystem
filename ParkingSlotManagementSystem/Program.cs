
using System;
using System.Windows.Forms;
using ParkingSlotManagementSystem.View;

namespace ParkingSlotManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}

