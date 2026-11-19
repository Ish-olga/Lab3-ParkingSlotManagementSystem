
using MySqlConnector;

namespace ParkingSlotManagementSystem.Data
{
    public class DatabaseConnection
    {
        private static string connectionString =
            "Server=localhost;" +
            "Port=3306;" +
            "Database=parking_slot_management;" +
            "User ID=root;" +
            "Password=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

