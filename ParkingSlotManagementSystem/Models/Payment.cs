
namespace ParkingSlotManagementSystem.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int RecordId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; set; } = "Paid";
        public string ReceiptNumber { get; set; } = string.Empty;
    }
}

