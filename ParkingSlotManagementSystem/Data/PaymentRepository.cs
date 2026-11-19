

using MySqlConnector;
using ParkingSlotManagementSystem.Models;

namespace ParkingSlotManagementSystem.Data
{
    public class PaymentRepository
    {
       
        public void AddPayment(Payment payment)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO payments
                    (record_id, amount, payment_method, payment_date,
                     payment_status, receipt_number)
                    VALUES
                    (@recordId, @amount, @method, @date, @status, @receipt)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@recordId", payment.RecordId);
                    cmd.Parameters.AddWithValue("@amount", payment.Amount);
                    cmd.Parameters.AddWithValue("@method", payment.PaymentMethod);
                    cmd.Parameters.AddWithValue("@date", payment.PaymentDate);
                    cmd.Parameters.AddWithValue("@status", payment.PaymentStatus);
                    cmd.Parameters.AddWithValue("@receipt", payment.ReceiptNumber);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Payment? GetPaymentByReceiptNumber(string receiptNumber)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"SELECT * FROM payments
                                 WHERE receipt_number = @receipt";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receipt", receiptNumber);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Payment
                            {
                                PaymentId = reader.GetInt32("payment_id"),
                                RecordId = reader.GetInt32("record_id"),
                                Amount = reader.GetDecimal("amount"),
                                PaymentMethod = reader.GetString("payment_method"),
                                PaymentDate = reader.GetDateTime("payment_date"),
                                PaymentStatus = reader.GetString("payment_status"),
                                ReceiptNumber = reader.GetString("receipt_number")
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}

