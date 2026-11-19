
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
using ParkingSlotManagementSystem.Data;

namespace ParkingSlotManagementSystem.View
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            SetActiveButton(FindControl<Button>("btnDashboard"));

            Load += DashboardForm_Load;
        }

        private T FindControl<T>(string controlName) where T : Control
        {
            Control[] controls = Controls.Find(controlName, true);

            if (controls.Length == 0)
                throw new Exception("Control not found: " + controlName);

            return (T)controls[0];
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            FindControl<Label>("lblDate").Text =
                DateTime.Now.ToString("dd MMMM yyyy");

            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            LoadDashboardData();
            LoadRecentActivity();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            (SELECT COUNT(*) FROM parking_slots) AS total_slots,
                            (SELECT COUNT(*) FROM parking_slots WHERE status = 'Available') AS available_slots,
                            (SELECT COUNT(*) FROM parking_slots WHERE status = 'Parked') AS occupied_slots,
                            (SELECT COUNT(*) FROM owners) AS total_owners,
                            (SELECT COUNT(*) FROM vehicle_entries WHERE DATE(entry_time) = CURDATE()) AS today_entries,
                            (SELECT COALESCE(SUM(amount), 0)
                             FROM payments
                             WHERE payment_status = 'Paid'
                             AND DATE(payment_date) = CURDATE()) AS today_revenue";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            FindControl<Label>("lblTotalSlotsValue").Text =
                                reader["total_slots"].ToString();

                            FindControl<Label>("lblAvailableSlotsValue").Text =
                                reader["available_slots"].ToString();

                            FindControl<Label>("lblOccupiedSlotsValue").Text =
                                reader["occupied_slots"].ToString();

                            FindControl<Label>("lblRegisteredOwnersValue").Text =
                                reader["total_owners"].ToString();

                            FindControl<Label>("lblTodayEntriesValue").Text =
                                reader["today_entries"].ToString();

                            decimal revenue =
                                Convert.ToDecimal(reader["today_revenue"]);

                            FindControl<Label>("lblTodayRevenueValue").Text =
                                revenue.ToString("N0") + " RWF";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard information.\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadRecentActivity()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            ve.entry_id AS 'Entry ID',
                            v.plate_number AS 'Plate Number',
                            o.full_name AS 'Owner Name',
                            ps.slot_number AS 'Parking Slot',
                            ve.entry_time AS 'Entry Time',
                            ve.exit_time AS 'Exit Time',
                            ve.status AS 'Status'
                        FROM vehicle_entries ve
                        INNER JOIN vehicles v
                            ON ve.vehicle_id = v.vehicle_id
                        INNER JOIN owners o
                            ON v.owner_id = o.owner_id
                        INNER JOIN parking_slots ps
                            ON ve.slot_id = ps.slot_id
                        ORDER BY ve.entry_id DESC
                        LIMIT 10";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        FindControl<DataGridView>("dgvRecentActivity").DataSource = table;
                    }

                    DataGridView grid =
                        FindControl<DataGridView>("dgvRecentActivity");

                    grid.ReadOnly = true;
                    grid.AllowUserToAddRows = false;
                    grid.AllowUserToDeleteRows = false;
                    grid.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                    grid.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                    grid.BackgroundColor = Color.White;
                    grid.RowHeadersVisible = false;

                    grid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);

                    grid.ColumnHeadersDefaultCellStyle.Font =
                        new Font("Segoe UI", 9F, FontStyle.Bold);

                    grid.ColumnHeadersDefaultCellStyle.BackColor =
                        Color.FromArgb(25, 43, 68);

                    grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    grid.EnableHeadersVisualStyles = false;

                    if (grid.Columns.Contains("Entry Time"))
                        grid.Columns["Entry Time"].DefaultCellStyle.Format =
                            "dd MMM yyyy HH:mm";

                    if (grid.Columns.Contains("Exit Time"))
                        grid.Columns["Exit Time"].DefaultCellStyle.Format =
                            "dd MMM yyyy HH:mm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load recent vehicle activity.\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SetActiveButton(Button activeButton)
        {
            Color navy = Color.FromArgb(25, 43, 68);
            Color green = Color.FromArgb(46, 139, 104);

            FindControl<Button>("btnDashboard").BackColor = navy;
            FindControl<Button>("btnOwnerVehicle").BackColor = navy;
            FindControl<Button>("btnParkingSlots").BackColor = navy;
            FindControl<Button>("btnVehicleEntry").BackColor = navy;
            FindControl<Button>("btnExitPayment").BackColor = navy;

            activeButton.BackColor = green;
        }

        private void OpenChildForm(Form childForm, string buttonName)
        {
            SetActiveButton(FindControl<Button>(buttonName));

            childForm.FormClosed += (s, e) =>
            {
                this.Show();

                SetActiveButton(
                    FindControl<Button>("btnDashboard"));

                RefreshDashboard();
            };

            childForm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(FindControl<Button>("btnDashboard"));
            RefreshDashboard();
        }

        private void btnOwnerVehicle_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OwnerVehicleForm(), "btnOwnerVehicle");
        }

        private void btnParkingSlots_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ParkingSlotsForm(), "btnParkingSlots");
        }

        private void btnVehicleEntry_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VehicleEntryForm(), "btnVehicleEntry");
        }

        private void btnExitPayment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ExitPaymentForm(), "btnExitPayment");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
