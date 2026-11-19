using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSlotManagementSystem.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}

