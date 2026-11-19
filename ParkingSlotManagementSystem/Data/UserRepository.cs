
using MySqlConnector;
using ParkingSlotManagementSystem.Models;

namespace ParkingSlotManagementSystem.Data
{
    public class UserRepository
    {
        public User GetUserByUsername(string username)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"SELECT user_id, username, password_hash, full_name
                                 FROM users
                                 WHERE username = @username";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserId = reader.GetInt32("user_id"),
                                Username = reader.GetString("username"),
                                PasswordHash = reader.GetString("password_hash"),
                                FullName = reader.GetString("full_name")
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}

