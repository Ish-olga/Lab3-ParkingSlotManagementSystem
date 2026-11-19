
namespace ParkingSlotManagementSystem.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int OwnerId { get; set; }

        public string PlateNumber { get; set; } = string.Empty;
        public string VehicleType { get; set; } = string.Empty;

        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
    }
}

