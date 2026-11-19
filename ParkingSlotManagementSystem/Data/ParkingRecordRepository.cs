
using MySqlConnector;
using ParkingSlotManagementSystem.Models;
using System;
using System.Collections.Generic;

namespace ParkingSlotManagementSystem.Data
{
    public class ParkingRecordRepository
    {
        // Save a new parking entry
        public void AddParkingRecord(ParkingRecord record)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO parking_records
                    (vehicle_id, slot_id, entry_time, parking_fee, record_status)
                    VALUES
                    (@vehicleId, @slotId, @entryTime, @fee, @status)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@vehicleId", record.VehicleId);
                    cmd.Parameters.AddWithValue("@slotId", record.SlotId);
                    cmd.Parameters.AddWithValue("@entryTime", record.EntryTime);
                    cmd.Parameters.AddWithValue("@fee", record.ParkingFee);
                    cmd.Parameters.AddWithValue("@status", record.RecordStatus);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Retrieve all active parking records
        public List<ParkingRecord> GetActiveRecords()
        {
            List<ParkingRecord> records = new List<ParkingRecord>();

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"SELECT * FROM parking_records
                                 WHERE record_status = 'Active'";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        records.Add(new ParkingRecord
                        {
                            RecordId = reader.GetInt32("record_id"),
                            VehicleId = reader.GetInt32("vehicle_id"),
                            SlotId = reader.GetInt32("slot_id"),
                            EntryTime = reader.GetDateTime("entry_time"),
                            ExitTime = reader.IsDBNull(reader.GetOrdinal("exit_time"))
                                ? null : reader.GetDateTime("exit_time"),
                            ParkingFee = reader.GetDecimal("parking_fee"),
                            RecordStatus = reader.GetString("record_status")
                        });
                    }
                }
            }

            return records;
        }

        // Record vehicle exit
        public void RecordExit(int recordId, DateTime exitTime, decimal fee)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE parking_records SET
                    exit_time = @exitTime,
                    parking_fee = @fee,
                    record_status = 'Completed'
                    WHERE record_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@exitTime", exitTime);
                    cmd.Parameters.AddWithValue("@fee", fee);
                    cmd.Parameters.AddWithValue("@id", recordId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


