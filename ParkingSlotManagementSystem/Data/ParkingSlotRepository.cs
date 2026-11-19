
using MySqlConnector;
using ParkingSlotManagementSystem.Models;
using System.Collections.Generic;

namespace ParkingSlotManagementSystem.Data
{
    public class ParkingSlotRepository
    {
        // Add parking slot
        public void AddSlot(ParkingSlot slot)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO parking_slots
                    (slot_number, category, status)
                    VALUES (@number, @category, @status)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@number", slot.SlotNumber);
                    cmd.Parameters.AddWithValue("@category", slot.Category);
                    cmd.Parameters.AddWithValue("@status", slot.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Display all slots
        public List<ParkingSlot> GetAllSlots()
        {
            List<ParkingSlot> slots = new List<ParkingSlot>();

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM parking_slots";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        slots.Add(new ParkingSlot
                        {
                            SlotId = reader.GetInt32("slot_id"),
                            SlotNumber = reader.GetString("slot_number"),
                            Category = reader.GetString("category"),
                            Status = reader.GetString("status")
                        });
                    }
                }
            }

            return slots;
        }

        // Display available slots
        public List<ParkingSlot> GetAvailableSlots()
        {
            List<ParkingSlot> slots = new List<ParkingSlot>();

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM parking_slots WHERE status='Available'";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        slots.Add(new ParkingSlot
                        {
                            SlotId = reader.GetInt32("slot_id"),
                            SlotNumber = reader.GetString("slot_number"),
                            Category = reader.GetString("category"),
                            Status = reader.GetString("status")
                        });
                    }
                }
            }

            return slots;
        }

        // Update slot
        public void UpdateSlot(ParkingSlot slot)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE parking_slots SET
                    slot_number=@number,
                    category=@category,
                    status=@status
                    WHERE slot_id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@number", slot.SlotNumber);
                    cmd.Parameters.AddWithValue("@category", slot.Category);
                    cmd.Parameters.AddWithValue("@status", slot.Status);
                    cmd.Parameters.AddWithValue("@id", slot.SlotId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete slot
        public void DeleteSlot(int slotId)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM parking_slots WHERE slot_id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", slotId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


