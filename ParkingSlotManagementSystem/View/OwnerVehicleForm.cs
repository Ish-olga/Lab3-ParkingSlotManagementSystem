
using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using ParkingSlotManagementSystem.Data;

namespace ParkingSlotManagementSystem.View
{
    public partial class OwnerVehicleForm : Form
    {
        private int selectedOwnerId = 0;
        private int selectedVehicleId = 0;

        public OwnerVehicleForm()
        {
            InitializeComponent();

            picLogo.Dock = DockStyle.Fill;
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            cmbVehicleType.Items.AddRange(new object[]
            {
                "Car", "Motorcycle", "Truck", "Van", "Bus"
            });

            cmbBrand.Items.AddRange(new object[]
            {
                "Toyota", "Honda", "Nissan", "BMW",
                "Mercedes-Benz", "Hyundai", "Other"
            });

            cmbColor.Items.AddRange(new object[]
            {
                "Black", "White", "Silver", "Gray",
                "Red", "Blue", "Green", "Other"
            });

            dgvOwnersVehicles.CellClick += dgvOwnersVehicles_CellClick;

            dgvOwnersVehicles.ReadOnly = true;
            dgvOwnersVehicles.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvOwnersVehicles.MultiSelect = false;
            dgvOwnersVehicles.AllowUserToAddRows = false;
            dgvOwnersVehicles.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            LoadOwnersVehicles();
        }

        private void LoadOwnersVehicles()
        {
            try
            {
                using (MySqlConnection connection =
                       DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            o.owner_id,
                            o.full_name,
                            o.phone,
                            o.email,
                            o.address,
                            v.vehicle_id,
                            v.plate_number,
                            v.vehicle_type,
                            v.brand,
                            v.model,
                            v.color
                        FROM owners o
                        LEFT JOIN vehicles v
                        ON o.owner_id = v.owner_id";

                    using (MySqlDataAdapter adapter =
                           new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvOwnersVehicles.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load records: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvOwnersVehicles_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvOwnersVehicles.Rows[e.RowIndex];

            selectedOwnerId =
                Convert.ToInt32(row.Cells["owner_id"].Value);

            selectedVehicleId =
                row.Cells["vehicle_id"].Value == DBNull.Value
                ? 0
                : Convert.ToInt32(row.Cells["vehicle_id"].Value);

            txtFullName.Text =
                row.Cells["full_name"].Value?.ToString();

            txtPhone.Text =
                row.Cells["phone"].Value?.ToString();

            txtEmail.Text =
                row.Cells["email"].Value?.ToString();

            txtAddress.Text =
                row.Cells["address"].Value?.ToString();

            txtPlateNumber.Text =
                row.Cells["plate_number"].Value?.ToString();

            cmbVehicleType.Text =
                row.Cells["vehicle_type"].Value?.ToString();

            cmbBrand.Text =
                row.Cells["brand"].Value?.ToString();

            cmbModel.Text =
                row.Cells["model"].Value?.ToString();

            cmbColor.Text =
                row.Cells["color"].Value?.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPlateNumber.Text) ||
                string.IsNullOrWhiteSpace(cmbVehicleType.Text) ||
                string.IsNullOrWhiteSpace(cmbBrand.Text) ||
                string.IsNullOrWhiteSpace(cmbModel.Text) ||
                string.IsNullOrWhiteSpace(cmbColor.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (MySqlConnection connection =
                       DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string ownerQuery = @"
                                INSERT INTO owners
                                (full_name, phone, email, address)
                                VALUES
                                (@name, @phone, @email, @address)";

                            long ownerId;

                            using (MySqlCommand command =
                                   new MySqlCommand(ownerQuery,
                                       connection, transaction))
                            {
                                command.Parameters.AddWithValue(
                                    "@name", txtFullName.Text.Trim());

                                command.Parameters.AddWithValue(
                                    "@phone", txtPhone.Text.Trim());

                                command.Parameters.AddWithValue(
                                    "@email", txtEmail.Text.Trim());

                                command.Parameters.AddWithValue(
                                    "@address", txtAddress.Text.Trim());

                                command.ExecuteNonQuery();
                                ownerId = command.LastInsertedId;
                            }

                            string vehicleQuery = @"
                                INSERT INTO vehicles
                                (owner_id, plate_number, vehicle_type,
                                 brand, model, color)
                                VALUES
                                (@ownerId, @plate, @type,
                                 @brand, @model, @color)";

                            using (MySqlCommand command =
                                   new MySqlCommand(vehicleQuery,
                                       connection, transaction))
                            {
                                command.Parameters.AddWithValue(
                                    "@ownerId", ownerId);

                                command.Parameters.AddWithValue(
                                    "@plate", txtPlateNumber.Text.Trim());

                                command.Parameters.AddWithValue(
                                    "@type", cmbVehicleType.Text);

                                command.Parameters.AddWithValue(
                                    "@brand", cmbBrand.Text);

                                command.Parameters.AddWithValue(
                                    "@model", cmbModel.Text);

                                command.Parameters.AddWithValue(
                                    "@color", cmbColor.Text);

                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show(
                    "Owner and vehicle registered successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadOwnersVehicles();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add record: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedOwnerId == 0)
            {
                MessageBox.Show("Please select a record from the grid.");
                return;
            }

            try
            {
                using (MySqlConnection connection =
                       DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string ownerQuery = @"
                                UPDATE owners
                                SET full_name = @name,
                                    phone = @phone,
                                    email = @email,
                                    address = @address
                                WHERE owner_id = @ownerId";

                            using (MySqlCommand command =
                                   new MySqlCommand(ownerQuery,
                                       connection, transaction))
                            {
                                command.Parameters.AddWithValue(
                                    "@name", txtFullName.Text.Trim());

                                command.Parameters.AddWithValue(
                                    "@phone", txtPhone.Text.Trim());

                                command.Parameters.AddWithValue(
                                    "@email", txtEmail.Text.Trim());

                                command.Parameters.AddWithValue(
                                    "@address", txtAddress.Text.Trim());

                                command.Parameters.AddWithValue(
                                    "@ownerId", selectedOwnerId);

                                command.ExecuteNonQuery();
                            }

                            if (selectedVehicleId > 0)
                            {
                                string vehicleQuery = @"
                                    UPDATE vehicles
                                    SET plate_number = @plate,
                                        vehicle_type = @type,
                                        brand = @brand,
                                        model = @model,
                                        color = @color
                                    WHERE vehicle_id = @vehicleId";

                                using (MySqlCommand command =
                                       new MySqlCommand(vehicleQuery,
                                           connection, transaction))
                                {
                                    command.Parameters.AddWithValue(
                                        "@plate", txtPlateNumber.Text.Trim());

                                    command.Parameters.AddWithValue(
                                        "@type", cmbVehicleType.Text);

                                    command.Parameters.AddWithValue(
                                        "@brand", cmbBrand.Text);

                                    command.Parameters.AddWithValue(
                                        "@model", cmbModel.Text);

                                    command.Parameters.AddWithValue(
                                        "@color", cmbColor.Text);

                                    command.Parameters.AddWithValue(
                                        "@vehicleId", selectedVehicleId);

                                    command.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show("Record updated successfully!");

                LoadOwnersVehicles();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update record: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedOwnerId == 0)
            {
                MessageBox.Show("Please select a record from the grid.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this owner and vehicle?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection connection =
                       DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            if (selectedVehicleId > 0)
                            {
                                string vehicleQuery = @"
                                    DELETE FROM vehicles
                                    WHERE vehicle_id = @vehicleId";

                                using (MySqlCommand command =
                                       new MySqlCommand(vehicleQuery,
                                           connection, transaction))
                                {
                                    command.Parameters.AddWithValue(
                                        "@vehicleId", selectedVehicleId);

                                    command.ExecuteNonQuery();
                                }
                            }

                            string ownerQuery = @"
                                DELETE FROM owners
                                WHERE owner_id = @ownerId";

                            using (MySqlCommand command =
                                   new MySqlCommand(ownerQuery,
                                       connection, transaction))
                            {
                                command.Parameters.AddWithValue(
                                    "@ownerId", selectedOwnerId);

                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show("Record deleted successfully!");

                LoadOwnersVehicles();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete record: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection =
                       DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            o.owner_id,
                            o.full_name,
                            o.phone,
                            o.email,
                            o.address,
                            v.vehicle_id,
                            v.plate_number,
                            v.vehicle_type,
                            v.brand,
                            v.model,
                            v.color
                        FROM owners o
                        LEFT JOIN vehicles v
                        ON o.owner_id = v.owner_id
                        WHERE o.full_name LIKE @search
                           OR o.phone LIKE @search
                           OR v.plate_number LIKE @search";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@search",
                            "%" + txtFullName.Text.Trim() + "%");

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dgvOwnersVehicles.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPlateNumber.Clear();

            cmbVehicleType.SelectedIndex = -1;
            cmbBrand.SelectedIndex = -1;
            cmbModel.SelectedIndex = -1;
            cmbColor.SelectedIndex = -1;

            selectedOwnerId = 0;
            selectedVehicleId = 0;

            dgvOwnersVehicles.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
        }

        private void btnVehicleEntry_Click(object sender, EventArgs e)
        {
            VehicleEntryForm vehicleEntry = new VehicleEntryForm();

            vehicleEntry.FormClosed += (s, args) =>
            {
                this.Show();
            };

            vehicleEntry.Show();
            this.Hide();
        }

        private void btnBackDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
