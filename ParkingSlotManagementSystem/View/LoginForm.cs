
using System;
using System.Windows.Forms;
using MySqlConnector;
using ParkingSlotManagementSystem.Data;

namespace ParkingSlotManagementSystem.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;

            btnRegister.Click += btnRegister_Click;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            RegisterForm register = new RegisterForm();

            register.FormClosed += (s, args) =>
            {
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                this.Show();
            };

            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your username and password.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) FROM users
                                     WHERE username = @username
                                     AND password_hash = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result == 0)
                        {
                            MessageBox.Show(
                                "Incorrect username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtUsername.Focus();

                            return;
                        }
                    }
                }

                txtUsername.Clear();
                txtPassword.Clear();

                DashboardForm dashboard = new DashboardForm();

                dashboard.FormClosed += (s, args) =>
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    this.Show();
                };

                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to connect to the database: " + ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
