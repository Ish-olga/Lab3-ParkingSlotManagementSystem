
using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using ParkingSlotManagementSystem.Data;

namespace ParkingSlotManagementSystem.View
{
    public partial class VehicleEntryForm : Form
    {
        public VehicleEntryForm()
        {
            InitializeComponent();

            Load += VehicleEntryForm_Load;

            cmbPlateNumber.SelectedIndexChanged +=
                cmbPlateNumber_SelectedIndexChanged;

            btnRegisterEntry.Click += btnRegisterEntry_Click;
            btnClear.Click += btnClear_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnDashboard.Click += btnDashboard_Click;

            // Parking slot must be selected from the list
            cmbParkingSlot.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }

        // LOAD FORM
        private void VehicleEntryForm_Load(object sender, EventArgs e)
        {
            dtpEntryTime.Value = DateTime.Now;

            LoadVehicles();
            LoadAvailableSlots();
            LoadVehicleEntries();
        }

        // LOAD REGISTERED VEHICLES
        private void LoadVehicles()
        {
            try
            {
                using (MySqlConnection conn =
                       DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT vehicle_id, plate_number
                        FROM vehicles
                        ORDER BY plate_number";

                    using (MySqlDataAdapter adapter =
                           new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cmbPlateNumber.DataSource = dt;
                        cmbPlateNumber.DisplayMember = "plate_number";
                        cmbPlateNumber.ValueMember = "vehicle_id";
                        cmbPlateNumber.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading vehicles: " + ex.Message);
            }
        }

        // DISPLAY OWNER AND VEHICLE INFORMATION
        private void cmbPlateNumber_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (cmbPlateNumber.SelectedIndex == -1 ||
                cmbPlateNumber.SelectedValue == null ||
                cmbPlateNumber.SelectedValue is DataRowView)
            {
                txtOwnerName.Clear();
                txtVehicleType.Clear();
                return;
            }

            try
            {
                using (MySqlConnection conn =
                       DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT o.full_name, v.vehicle_type
                        FROM vehicles v
                        INNER JOIN owners o
                            ON v.owner_id = o.owner_id
                        WHERE v.vehicle_id = @vehicle_id";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@vehicle_id",
                            cmbPlateNumber.SelectedValue);

                        using (MySqlDataReader reader =
                               cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtOwnerName.Text =
                                    reader["full_name"].ToString();

                                txtVehicleType.Text =
                                    reader["vehicle_type"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading vehicle details: " + ex.Message);
            }
        }

        // LOAD AVAILABLE PARKING SLOTS INTO DROPDOWN
        private void LoadAvailableSlots()
        {
            try
            {
                using (MySqlConnection conn =
                       DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT slot_id, slot_number
                        FROM parking_slots
                        WHERE status = 'Available'
                        ORDER BY slot_number";

                    using (MySqlDataAdapter adapter =
                           new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cmbParkingSlot.DataSource = null;
                        cmbParkingSlot.Items.Clear();

                        cmbParkingSlot.DisplayMember =
                            "slot_number";

                        cmbParkingSlot.ValueMember =
                            "slot_id";

                        cmbParkingSlot.DataSource = dt;
                        cmbParkingSlot.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading available slots: " + ex.Message);
            }
        }

        // REGISTER VEHICLE ENTRY
        private void btnRegisterEntry_Click(object sender, EventArgs e)
        {
            if (cmbPlateNumber.SelectedIndex == -1 ||
                cmbPlateNumber.SelectedValue == null ||
                cmbPlateNumber.SelectedValue is DataRowView)
            {
                MessageBox.Show(
                    "Please select a vehicle plate number.");
                return;
            }

            if (cmbParkingSlot.SelectedIndex == -1 ||
                cmbParkingSlot.SelectedValue == null ||
                cmbParkingSlot.SelectedValue is DataRowView)
            {
                MessageBox.Show(
                    "Please select an available parking slot.");
                return;
            }

            int vehicleId =
                Convert.ToInt32(cmbPlateNumber.SelectedValue);

            int slotId =
                Convert.ToInt32(cmbParkingSlot.SelectedValue);

            try
            {
                using (MySqlConnection conn =
                       DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    using (MySqlTransaction transaction =
                           conn.BeginTransaction())
                    {
                        try
                        {
                            // CHECK THAT THE SLOT IS AVAILABLE
                            string checkQuery = @"
                                SELECT status
                                FROM parking_slots
                                WHERE slot_id = @slot_id
                                FOR UPDATE";

                            using (MySqlCommand checkCmd =
                                   new MySqlCommand(
                                       checkQuery, conn, transaction))
                            {
                                checkCmd.Parameters.AddWithValue(
                                    "@slot_id", slotId);

                                object result =
                                    checkCmd.ExecuteScalar();

                                if (result == null ||
                                    result.ToString() != "Available")
                                {
                                    throw new Exception(
                                        "This parking slot is no longer available. Please refresh.");
                                }
                            }

                            // INSERT VEHICLE ENTRY
                            string insertQuery = @"
                                INSERT INTO vehicle_entries
                                (vehicle_id, slot_id, entry_time, status)
                                VALUES
                                (@vehicle_id, @slot_id, @entry_time, 'Parked')";

                            using (MySqlCommand cmd =
                                   new MySqlCommand(
                                       insertQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@vehicle_id", vehicleId);

                                cmd.Parameters.AddWithValue(
                                    "@slot_id", slotId);

                                cmd.Parameters.AddWithValue(
                                    "@entry_time", dtpEntryTime.Value);

                                cmd.ExecuteNonQuery();
                            }

                            // CHANGE SLOT STATUS TO PARKED
                            string updateQuery = @"
                                UPDATE parking_slots
                                SET status = 'Parked'
                                WHERE slot_id = @slot_id";

                            using (MySqlCommand updateCmd =
                                   new MySqlCommand(
                                       updateQuery, conn, transaction))
                            {
                                updateCmd.Parameters.AddWithValue(
                                    "@slot_id", slotId);

                                updateCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show(
                                "Vehicle entry registered successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                ClearFields();

                // RELOAD AVAILABLE SLOTS
                LoadAvailableSlots();

                // RELOAD VEHICLE ENTRY GRID
                LoadVehicleEntries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error registering vehicle entry:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // LOAD SAVED ENTRIES INTO DATAGRIDVIEW
        private void LoadVehicleEntries()
        {
            try
            {
                using (MySqlConnection conn =
                       DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            ve.entry_id,
                            v.plate_number,
                            o.full_name AS owner_name,
                            v.vehicle_type,
                            ps.slot_number,
                            ve.entry_time,
                            ve.status
                        FROM vehicle_entries ve
                        INNER JOIN vehicles v
                            ON ve.vehicle_id = v.vehicle_id
                        INNER JOIN owners o
                            ON v.owner_id = o.owner_id
                        INNER JOIN parking_slots ps
                            ON ve.slot_id = ps.slot_id
                        ORDER BY ve.entry_id DESC";

                    using (MySqlDataAdapter adapter =
                           new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvVehicleEntries.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading vehicle entries: " + ex.Message);
            }
        }

        // CLEAR FIELDS
        private void ClearFields()
        {
            cmbPlateNumber.SelectedIndex = -1;
            cmbParkingSlot.SelectedIndex = -1;

            txtOwnerName.Clear();
            txtVehicleType.Clear();

            dtpEntryTime.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadVehicles();
            LoadAvailableSlots();
            LoadVehicleEntries();
        }

        // BACK TO DASHBOARD
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }
    }
}
