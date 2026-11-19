using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSlotManagementSystem.Models
{
    public class User 
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
    }
}
    

