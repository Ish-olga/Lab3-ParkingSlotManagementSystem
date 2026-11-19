using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSlotManagementSystem.Models
{
    public class ParkingRecord
    {
        public int RecordId { get; set; }
        public int VehicleId { get; set; }
        public int SlotId { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public decimal ParkingFee { get; set; }
        public string RecordStatus { get; set; }   
    }
}
