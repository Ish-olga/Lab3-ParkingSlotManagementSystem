
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
using ParkingSlotManagementSystem.Data;

namespace ParkingSlotManagementSystem.View
{
    public partial class ParkingSlotsForm : Form
    {
        private int selectedSlotId = 0;

        public ParkingSlotsForm()
        {
            InitializeComponent();

            // Button events
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;

            // Grid event
            dgvParkingSlots.CellClick += dgvParkingSlots_CellClick;

            // Input font sizes
            textBox1.Font = new Font("Segoe UI", 9F);
            txtLocation.Font = new Font("Segoe UI", 9F);
            cmbSlotType.Font = new Font("Segoe UI", 9F);
            cmbVehicleType.Font = new Font("Segoe UI", 9F);
            cmbStatus.Font = new Font("Segoe UI", 9F);

            // Dropdown settings
            cmbSlotType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            // DataGridView appearance
            dgvParkingSlots.Font = new Font("Segoe UI", 9F);

            dgvParkingSlots.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvParkingSlots.RowTemplate.Height = 32;
            dgvParkingSlots.ColumnHeadersHeight = 38;

            dgvParkingSlots.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvParkingSlots.MultiSelect = false;
            dgvParkingSlots.ReadOnly = true;
            dgvParkingSlots.AllowUserToAddRows = false;

            dgvParkingSlots.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            LoadParkingSlots();
        }

        // LOAD PARKING SLOTS
        private void LoadParkingSlots()
        {
            try
            {
                using (MySqlConnection connection =
                       DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            slot_id,
                            slot_number,
                            slot_type,
                            status
                        FROM parking_slots
                        ORDER BY slot_number";

                    using (MySqlDataAdapter adapter =
                           new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvParkingSlots.DataSource = table;

                        dgvParkingSlots.Columns["slot_id"].Visible = false;

                        dgvParkingSlots.Columns["slot_number"].HeaderText =
                            "Slot Number";

                        dgvParkingSlots.Columns["slot_type"].HeaderText =
                            "Slot Type";

                        dgvParkingSlots.Columns["status"].HeaderText =
                            "Status";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load parking slots: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ADD SLOT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string slotNumber = textBox1.Text.Trim();
            string slotType = cmbSlotType.Text;
            string status = cmbStatus.Text;

            if (slotNumber == "" || slotType == "" || status == "")
            {
                MessageBox.Show(
                    "Please enter Slot Number, Slot Type and Status.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (MySqlConnection connection =
                       DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO parking_slots
                        (slot_number, slot_type, status)
                        VALUES
                        (@slot_number, @slot_type, @status)";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@slot_number", slotNumber);

                        command.Parameters.AddWithValue(
                            "@slot_type", slotType);

                        command.Parameters.AddWithValue(
                            "@status", status);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Parking slot added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadParkingSlots();
                ClearFields();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("This slot number already exists.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding slot: " + ex.Message);
            }
        }

        // SELECT SLOT FROM GRID
        private void dgvParkingSlots_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvParkingSlots.Rows[e.RowIndex];

            selectedSlotId = Convert.ToInt32(
                row.Cells["slot_id"].Value);

            textBox1.Text =
                row.Cells["slot_number"].Value.ToString();

            cmbSlotType.Text =
                row.Cells["slot_type"].Value.ToString();

            cmbStatus.Text =
                row.Cells["status"].Value.ToString();
        }

        // UPDATE SLOT
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSlotId == 0)
            {
                MessageBox.Show(
                    "Please select a parking slot from the table.");

                return;
            }

            string slotNumber = textBox1.Text.Trim();
            string slotType = cmbSlotType.Text;
            string status = cmbStatus.Text;

            if (slotNumber == "" || slotType == "" || status == "")
            {
                MessageBox.Show(
                    "Please complete all required fields.");

                return;
            }

            try
            {
                using (MySqlConnection connection =
                       DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        UPDATE parking_slots
                        SET slot_number = @slot_number,
                            slot_type = @slot_type,
                            status = @status
                        WHERE slot_id = @slot_id";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@slot_number", slotNumber);

                        command.Parameters.AddWithValue(
                            "@slot_type", slotType);

                        command.Parameters.AddWithValue(
                            "@status", status);

                        command.Parameters.AddWithValue(
                            "@slot_id", selectedSlotId);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Parking slot updated successfully!");

                LoadParkingSlots();
                ClearFields();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("This slot number already exists.");
                else
                    MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating slot: " + ex.Message);
            }
        }

        // DELETE SLOT
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSlotId == 0)
            {
                MessageBox.Show(
                    "Please select a parking slot to delete.");

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this parking slot?",
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

                    string query = @"
                        DELETE FROM parking_slots
                        WHERE slot_id = @slot_id";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@slot_id", selectedSlotId);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Parking slot deleted successfully!");

                LoadParkingSlots();
                ClearFields();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Unable to delete this slot. It may already be linked " +
                    "to a vehicle entry.\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting slot: " + ex.Message);
            }
        }

        // CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // CLEAR INPUT FIELDS
        private void ClearFields()
        {
            textBox1.Clear();
            txtLocation.Clear();

            cmbSlotType.SelectedIndex = -1;
            cmbVehicleType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            selectedSlotId = 0;

            dgvParkingSlots.ClearSelection();

            textBox1.Focus();
        }

        // BACK TO DASHBOARD
        private void btnBackDashboard_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
