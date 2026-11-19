
using MySqlConnector;
using ParkingSlotManagementSystem.Models;
using System;
using System.Collections.Generic;

namespace ParkingSlotManagementSystem.Data
{
    public class OwnerRepository
    {
        public void AddOwner(Owner owner)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO owners
                    (full_name, phone, email, address)
                    VALUES (@name, @phone, @email, @address)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", owner.FullName);
                    cmd.Parameters.AddWithValue("@phone", owner.Phone);
                    cmd.Parameters.AddWithValue("@email",
                        (object?)owner.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@address",
                        (object?)owner.Address ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Owner> GetAllOwners()
        {
            List<Owner> owners = new List<Owner>();

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM owners";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        owners.Add(new Owner
                        {
                            OwnerId = reader.GetInt32("owner_id"),
                            FullName = reader.GetString("full_name"),
                            Phone = reader.GetString("phone"),

                            Email = reader.IsDBNull(reader.GetOrdinal("email"))
                                ? string.Empty
                                : reader.GetString("email"),

                            Address = reader.IsDBNull(reader.GetOrdinal("address"))
                                ? string.Empty
                                : reader.GetString("address")
                        });
                    }
                }
            }

            return owners;
        }

        public void UpdateOwner(Owner owner)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE owners SET
                    full_name=@name, phone=@phone,
                    email=@email, address=@address
                    WHERE owner_id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", owner.FullName);
                    cmd.Parameters.AddWithValue("@phone", owner.Phone);
                    cmd.Parameters.AddWithValue("@email",
                        (object?)owner.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@address",
                        (object?)owner.Address ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", owner.OwnerId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteOwner(int ownerId)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM owners WHERE owner_id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", ownerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}



