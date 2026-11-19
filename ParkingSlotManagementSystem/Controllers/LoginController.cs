
using ParkingSlotManagementSystem.Data;
using ParkingSlotManagementSystem.Models;

namespace ParkingSlotManagementSystem.Controllers
{
    public class LoginController
    {
        private readonly UserRepository userRepository;

        public LoginController()
        {
            userRepository = new UserRepository();
        }

        public User? Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            User? user = userRepository.GetUserByUsername(username);

            if (user == null)
            {
                return null;
            }

            if (user.PasswordHash == password)
            {
                return user;
            }

            return null;
        }
    }
}

