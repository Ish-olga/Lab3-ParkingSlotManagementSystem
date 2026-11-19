
namespace ParkingSlotManagementSystem.Models
{
    public class ParkingSlot
    {
        public int SlotId { get; set; }
        public string SlotNumber { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Status { get; set; } = "Available";
    }
}

