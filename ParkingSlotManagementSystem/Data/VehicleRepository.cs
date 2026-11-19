

using MySqlConnector;
using ParkingSlotManagementSystem.Models;
using System;
using System.Collections.Generic;

namespace ParkingSlotManagementSystem.Data
{
    public class VehicleRepository
    {
        // Add vehicle
        public void AddVehicle(Vehicle vehicle)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO vehicles
                    (owner_id, plate_number, vehicle_type, brand, model, color)
                    VALUES
                    (@ownerId, @plate, @type, @brand, @model, @color)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    AddParameters(cmd, vehicle);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Get all vehicles
        public List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM vehicles";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vehicles.Add(ReadVehicle(reader));
                    }
                }
            }

            return vehicles;
        }

        // Search vehicle by plate number
        public Vehicle? SearchByPlate(string plateNumber)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"SELECT * FROM vehicles
                                 WHERE plate_number = @plate";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@plate", plateNumber);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return ReadVehicle(reader);
                        }
                    }
                }
            }

            return null;
        }

        // Update vehicle
        public void UpdateVehicle(Vehicle vehicle)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE vehicles SET
                    owner_id = @ownerId,
                    plate_number = @plate,
                    vehicle_type = @type,
                    brand = @brand,
                    model = @model,
                    color = @color
                    WHERE vehicle_id = @vehicleId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    AddParameters(cmd, vehicle);
                    cmd.Parameters.AddWithValue("@vehicleId", vehicle.VehicleId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete vehicle
        public void DeleteVehicle(int vehicleId)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"DELETE FROM vehicles
                                 WHERE vehicle_id = @vehicleId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@vehicleId", vehicleId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Add parameters
        private void AddParameters(MySqlCommand cmd, Vehicle vehicle)
        {
            cmd.Parameters.AddWithValue("@ownerId", vehicle.OwnerId);
            cmd.Parameters.AddWithValue("@plate", vehicle.PlateNumber);
            cmd.Parameters.AddWithValue("@type", vehicle.VehicleType);
            cmd.Parameters.AddWithValue("@brand",
                (object?)vehicle.Brand ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@model",
                (object?)vehicle.Model ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@color",
                (object?)vehicle.Color ?? DBNull.Value);
        }

        // Read vehicle information
        private Vehicle ReadVehicle(MySqlDataReader reader)
        {
            return new Vehicle
            {
                VehicleId = reader.GetInt32("vehicle_id"),
                OwnerId = reader.GetInt32("owner_id"),
                PlateNumber = reader.GetString("plate_number"),
                VehicleType = reader.GetString("vehicle_type"),
                Brand = reader.IsDBNull(reader.GetOrdinal("brand"))
                    ? null : reader.GetString("brand"),
                Model = reader.IsDBNull(reader.GetOrdinal("model"))
                    ? null : reader.GetString("model"),
                Color = reader.IsDBNull(reader.GetOrdinal("color"))
                    ? null : reader.GetString("color")
            };
        }
    }
}
