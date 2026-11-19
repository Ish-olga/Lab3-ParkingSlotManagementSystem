
using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using ParkingSlotManagementSystem.Data;

namespace ParkingSlotManagementSystem.View
{
    public partial class ExitPaymentForm : Form
    {
        private int selectedEntryId = 0;
        private int selectedSlotId = 0;

        private decimal calculatedFee = 0;
        private bool feeCalculated = false;
        private bool paymentProcessed = false;

        private DateTime vehicleEntryTime;
        private DateTime calculatedExitTime;

        private System.Windows.Forms.Timer durationTimer;

        private const decimal HOURLY_RATE = 500m;

        public ExitPaymentForm()
        {
            InitializeComponent();

            btnCalculateFee.Click += btnCalculateFee_Click;
            btnProcessPayment.Click += btnProcessPayment_Click;
            btnRegisterExit.Click += btnRegisterExit_Click;
            btnClear.Click += btnClear_Click;
            btnDashboard.Click += btnDashboard_Click;

            cmbPlateNumber.SelectedIndexChanged +=
                cmbPlateNumber_SelectedIndexChanged;

            durationTimer = new System.Windows.Forms.Timer();
            durationTimer.Interval = 1000;
            durationTimer.Tick += DurationTimer_Tick;

            Load += ExitPaymentForm_Load;
        }

        // FORM LOAD
        private void ExitPaymentForm_Load(object sender, EventArgs e)
        {
            dtpExitTime.Value = DateTime.Now;

            cmbPaymentStatus.Items.Clear();
            cmbPaymentStatus.Items.AddRange(new object[]
            {
                "Pending",
                "Paid",
                "Failed",
                "Cancelled"
            });

            cmbPaymentStatus.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbPaymentStatus.Enabled = false;
            cmbPaymentStatus.SelectedItem = "Pending";

            txtOwnerName.ReadOnly = true;
            txtVehicleType.ReadOnly = true;
            txtSlotNumber.ReadOnly = true;
            txtEntryTime.ReadOnly = true;
            txtDuration.ReadOnly = true;
            txtTotalAmount.ReadOnly = true;

            dgvPaymentHistory.ReadOnly = true;
            dgvPaymentHistory.AllowUserToAddRows = false;
            dgvPaymentHistory.AllowUserToDeleteRows = false;
            dgvPaymentHistory.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaymentHistory.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            LoadParkedVehicles();
            LoadPaymentHistory();
        }

        // LOAD PARKED VEHICLES
        private void LoadParkedVehicles()
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
                            v.plate_number
                        FROM vehicle_entries ve
                        INNER JOIN vehicles v
                            ON ve.vehicle_id = v.vehicle_id
                        WHERE ve.status = 'Parked'
                          AND ve.exit_time IS NULL
                        ORDER BY ve.entry_id DESC";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        DataTable table = new DataTable();

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }

                        cmbPlateNumber.DataSource = null;
                        cmbPlateNumber.Items.Clear();

                        cmbPlateNumber.DisplayMember =
                            "plate_number";

                        cmbPlateNumber.ValueMember =
                            "entry_id";

                        cmbPlateNumber.DataSource = table;
                        cmbPlateNumber.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading parked vehicles: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // VEHICLE SELECTION
        private void cmbPlateNumber_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (cmbPlateNumber.SelectedIndex == -1 ||
                cmbPlateNumber.SelectedValue == null)
            {
                return;
            }

            if (!int.TryParse(
                cmbPlateNumber.SelectedValue.ToString(),
                out selectedEntryId))
            {
                return;
            }

            LoadSelectedVehicle();
        }

        // LOAD SELECTED VEHICLE DETAILS
        private void LoadSelectedVehicle()
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
                            ve.slot_id,
                            v.plate_number,
                            v.vehicle_type,
                            o.full_name,
                            ps.slot_number,
                            ve.entry_time,
                            p.payment_id,
                            p.amount,
                            p.payment_method,
                            p.payment_status,
                            p.receipt_number
                        FROM vehicle_entries ve
                        INNER JOIN vehicles v
                            ON ve.vehicle_id = v.vehicle_id
                        INNER JOIN owners o
                            ON v.owner_id = o.owner_id
                        INNER JOIN parking_slots ps
                            ON ve.slot_id = ps.slot_id
                        LEFT JOIN payments p
                            ON p.record_id = ve.entry_id
                        WHERE ve.entry_id = @entry_id
                          AND ve.status = 'Parked'
                          AND ve.exit_time IS NULL";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@entry_id", selectedEntryId);

                        using (MySqlDataReader reader =
                               cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                selectedSlotId =
                                    Convert.ToInt32(reader["slot_id"]);

                                vehicleEntryTime =
                                    Convert.ToDateTime(reader["entry_time"]);

                                txtOwnerName.Text =
                                    reader["full_name"].ToString();

                                txtVehicleType.Text =
                                    reader["vehicle_type"].ToString();

                                txtSlotNumber.Text =
                                    reader["slot_number"].ToString();

                                txtEntryTime.Text =
                                    vehicleEntryTime.ToString(
                                        "yyyy-MM-dd HH:mm");

                                dtpExitTime.Value = DateTime.Now;

                                txtDuration.Clear();
                                txtTotalAmount.Clear();

                                calculatedFee = 0;
                                feeCalculated = false;
                                paymentProcessed = false;

                                cmbPaymentMethod.SelectedIndex = -1;
                                cmbPaymentStatus.SelectedItem = "Pending";

                                if (reader["payment_id"] != DBNull.Value &&
                                    reader["payment_status"].ToString() == "Paid")
                                {
                                    paymentProcessed = true;
                                    feeCalculated = true;

                                    calculatedFee =
                                        Convert.ToDecimal(reader["amount"]);

                                    txtTotalAmount.Text =
                                        calculatedFee.ToString("N0") + " RWF";

                                    cmbPaymentStatus.SelectedItem = "Paid";

                                    string method =
                                        reader["payment_method"].ToString();

                                    if (cmbPaymentMethod.Items.Contains(method))
                                    {
                                        cmbPaymentMethod.SelectedItem = method;
                                    }

                                    calculatedExitTime = dtpExitTime.Value;
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "This vehicle is no longer parked.",
                                    "Vehicle Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                ClearFields();
                                LoadParkedVehicles();
                                return;
                            }
                        }
                    }
                }

                if (!paymentProcessed)
                {
                    durationTimer.Stop();
                    UpdateDuration();
                    durationTimer.Start();
                }
                else
                {
                    durationTimer.Stop();
                }
            }
            catch (Exception ex)
            {
                durationTimer.Stop();

                MessageBox.Show(
                    "Error loading vehicle details: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // AUTOMATIC DURATION TIMER
        private void DurationTimer_Tick(object sender, EventArgs e)
        {
            UpdateDuration();
        }

        private void UpdateDuration()
        {
            if (selectedEntryId == 0)
                return;

            TimeSpan duration = DateTime.Now - vehicleEntryTime;

            if (duration.TotalSeconds < 0)
                duration = TimeSpan.Zero;

            txtDuration.Text =
                $"{(int)duration.TotalDays} day(s), " +
                $"{duration.Hours} hour(s), " +
                $"{duration.Minutes} minute(s), " +
                $"{duration.Seconds} second(s)";
        }

        // CALCULATE PARKING FEE
        private void btnCalculateFee_Click(object sender, EventArgs e)
        {
            if (selectedEntryId == 0)
            {
                MessageBox.Show(
                    "Please select a parked vehicle first.",
                    "Missing Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (paymentProcessed)
            {
                MessageBox.Show(
                    "Payment has already been made for this vehicle.");
                return;
            }

            try
            {
                DateTime entryTime = vehicleEntryTime;
                DateTime exitTime = dtpExitTime.Value;

                if (exitTime <= entryTime)
                {
                    MessageBox.Show(
                        "Exit time must be later than entry time.",
                        "Invalid Exit Time",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                TimeSpan duration = exitTime - entryTime;

                int hours = Math.Max(
                    1,
                    (int)Math.Ceiling(
                        duration.TotalMinutes / 60.0));

                calculatedFee = hours * HOURLY_RATE;

                txtDuration.Text =
                    $"{(int)duration.TotalDays} day(s), " +
                    $"{duration.Hours} hour(s), " +
                    $"{duration.Minutes} minute(s), " +
                    $"{duration.Seconds} second(s)";

                txtTotalAmount.Text =
                    calculatedFee.ToString("N0") + " RWF";

                calculatedExitTime = exitTime;

                feeCalculated = true;
                paymentProcessed = false;

                durationTimer.Stop();

                cmbPaymentStatus.SelectedItem = "Pending";

                MessageBox.Show(
                    "Parking fee calculated successfully!\n\n" +
                    "Duration: " + txtDuration.Text +
                    "\nCharged Hours: " + hours +
                    "\nHourly Rate: 500 RWF" +
                    "\nTotal Amount: " +
                    calculatedFee.ToString("N0") + " RWF",
                    "Fee Calculation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error calculating fee: " + ex.Message,
                    "Calculation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // PROCESS PAYMENT
        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            if (selectedEntryId == 0)
            {
                MessageBox.Show("Please select a vehicle first.");
                return;
            }

            if (!feeCalculated)
            {
                MessageBox.Show(
                    "Please calculate the parking fee first.",
                    "Fee Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (dtpExitTime.Value != calculatedExitTime)
            {
                MessageBox.Show(
                    "The exit time has changed. Please calculate the fee again.");
                return;
            }

            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a payment method.",
                    "Payment Method Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (paymentProcessed)
            {
                MessageBox.Show(
                    "Payment has already been processed.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Confirm payment of " +
                calculatedFee.ToString("N0") +
                " RWF using " +
                cmbPaymentMethod.Text + "?",
                "Confirm Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn =
                       DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    using (MySqlTransaction transaction =
                           conn.BeginTransaction())
                    {
                        string checkQuery = @"
                            SELECT COUNT(*)
                            FROM vehicle_entries
                            WHERE entry_id = @entry_id
                              AND status = 'Parked'
                              AND exit_time IS NULL";

                        using (MySqlCommand checkCmd =
                               new MySqlCommand(
                                   checkQuery, conn, transaction))
                        {
                            checkCmd.Parameters.AddWithValue(
                                "@entry_id", selectedEntryId);

                            int count = Convert.ToInt32(
                                checkCmd.ExecuteScalar());

                            if (count == 0)
                            {
                                transaction.Rollback();

                                MessageBox.Show(
                                    "This vehicle is no longer parked.");
                                return;
                            }
                        }

                        string duplicateQuery = @"
                            SELECT COUNT(*)
                            FROM payments
                            WHERE record_id = @record_id";

                        using (MySqlCommand duplicateCmd =
                               new MySqlCommand(
                                   duplicateQuery, conn, transaction))
                        {
                            duplicateCmd.Parameters.AddWithValue(
                                "@record_id", selectedEntryId);

                            int exists = Convert.ToInt32(
                                duplicateCmd.ExecuteScalar());

                            if (exists > 0)
                            {
                                transaction.Rollback();

                                MessageBox.Show(
                                    "A payment already exists for this vehicle entry.");
                                return;
                            }
                        }

                        string receiptNumber =
                            "REC-" + Guid.NewGuid().ToString("N")
                            .Substring(0, 12).ToUpper();

                        string insertQuery = @"
                            INSERT INTO payments
                            (
                                record_id,
                                amount,
                                payment_method,
                                payment_status,
                                receipt_number
                            )
                            VALUES
                            (
                                @record_id,
                                @amount,
                                @method,
                                'Paid',
                                @receipt
                            )";

                        using (MySqlCommand cmd =
                               new MySqlCommand(
                                   insertQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue(
                                "@record_id", selectedEntryId);

                            cmd.Parameters.AddWithValue(
                                "@amount", calculatedFee);

                            cmd.Parameters.AddWithValue(
                                "@method", cmbPaymentMethod.Text);

                            cmd.Parameters.AddWithValue(
                                "@receipt", receiptNumber);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        paymentProcessed = true;
                        cmbPaymentStatus.SelectedItem = "Paid";

                        MessageBox.Show(
                            "PAYMENT SUCCESSFUL!\n\n" +
                            "Receipt Number: " + receiptNumber +
                            "\nAmount: " + calculatedFee.ToString("N0") +
                            " RWF\nPayment Method: " + cmbPaymentMethod.Text +
                            "\nPayment Status: PAID",
                            "Payment Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

                LoadPaymentHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error processing payment:\n" + ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // REGISTER VEHICLE EXIT
        private void btnRegisterExit_Click(object sender, EventArgs e)
        {
            if (selectedEntryId == 0)
            {
                MessageBox.Show("Please select a vehicle first.");
                return;
            }

            if (!paymentProcessed)
            {
                MessageBox.Show(
                    "Please process payment before registering vehicle exit.",
                    "Payment Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (dtpExitTime.Value != calculatedExitTime)
            {
                MessageBox.Show(
                    "The exit time has changed. Please calculate the fee again.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to register this vehicle's exit?",
                "Confirm Vehicle Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn =
                       DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    using (MySqlTransaction transaction =
                           conn.BeginTransaction())
                    {
                        string paymentQuery = @"
                            SELECT COUNT(*)
                            FROM payments
                            WHERE record_id = @record_id
                              AND payment_status = 'Paid'";

                        using (MySqlCommand paymentCmd =
                               new MySqlCommand(
                                   paymentQuery, conn, transaction))
                        {
                            paymentCmd.Parameters.AddWithValue(
                                "@record_id", selectedEntryId);

                            int paid = Convert.ToInt32(
                                paymentCmd.ExecuteScalar());

                            if (paid == 0)
                            {
                                transaction.Rollback();

                                MessageBox.Show(
                                    "A successful payment was not found.");
                                return;
                            }
                        }

                        string exitQuery = @"
                            UPDATE vehicle_entries
                            SET exit_time = @exit_time,
                                status = 'Exited'
                            WHERE entry_id = @entry_id
                              AND status = 'Parked'
                              AND exit_time IS NULL";

                        using (MySqlCommand exitCmd =
                               new MySqlCommand(
                                   exitQuery, conn, transaction))
                        {
                            exitCmd.Parameters.AddWithValue(
                                "@exit_time", calculatedExitTime);

                            exitCmd.Parameters.AddWithValue(
                                "@entry_id", selectedEntryId);

                            int affected = exitCmd.ExecuteNonQuery();

                            if (affected == 0)
                            {
                                transaction.Rollback();

                                MessageBox.Show(
                                    "Vehicle exit could not be registered. " +
                                    "The vehicle may already have exited.");
                                return;
                            }
                        }

                        string slotQuery = @"
                            UPDATE parking_slots
                            SET status = 'Available'
                            WHERE slot_id = @slot_id";

                        using (MySqlCommand slotCmd =
                               new MySqlCommand(
                                   slotQuery, conn, transaction))
                        {
                            slotCmd.Parameters.AddWithValue(
                                "@slot_id", selectedSlotId);

                            slotCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                }

                durationTimer.Stop();

                MessageBox.Show(
                    "Vehicle exit registered successfully!\n" +
                    "The parking slot is now available.",
                    "Exit Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadPaymentHistory();
                LoadParkedVehicles();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error registering vehicle exit: " + ex.Message,
                    "Exit Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // LOAD PAYMENT HISTORY
        private void LoadPaymentHistory()
        {
            try
            {
                using (MySqlConnection conn =
                       DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            p.payment_id,
                            v.plate_number,
                            o.full_name AS owner_name,
                            ps.slot_number,
                            CONCAT(
                                FLOOR(
                                    TIMESTAMPDIFF(
                                        MINUTE,
                                        ve.entry_time,
                                        COALESCE(ve.exit_time, p.payment_date)
                                    ) / 60
                                ),
                                ' hour(s), ',
                                MOD(
                                    TIMESTAMPDIFF(
                                        MINUTE,
                                        ve.entry_time,
                                        COALESCE(ve.exit_time, p.payment_date)
                                    ),
                                    60
                                ),
                                ' minute(s)'
                            ) AS duration,
                            p.amount AS amount_paid,
                            p.payment_method,
                            p.payment_date,
                            p.payment_status AS status
                        FROM payments p
                        INNER JOIN vehicle_entries ve
                            ON p.record_id = ve.entry_id
                        INNER JOIN vehicles v
                            ON ve.vehicle_id = v.vehicle_id
                        INNER JOIN owners o
                            ON v.owner_id = o.owner_id
                        INNER JOIN parking_slots ps
                            ON ve.slot_id = ps.slot_id
                        ORDER BY p.payment_id DESC";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        DataTable table = new DataTable();

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }

                        dgvPaymentHistory.DataSource = table;

                        SetColumnHeader("payment_id", "Payment ID");
                        SetColumnHeader("plate_number", "Plate Number");
                        SetColumnHeader("owner_name", "Owner Name");
                        SetColumnHeader("slot_number", "Slot Number");
                        SetColumnHeader("duration", "Duration");
                        SetColumnHeader("amount_paid", "Amount Paid");
                        SetColumnHeader("payment_method", "Payment Method");
                        SetColumnHeader("payment_date", "Payment Date");
                        SetColumnHeader("status", "Payment Status");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading payment history: " + ex.Message,
                    "History Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // SET GRID COLUMN HEADERS
        private void SetColumnHeader(
            string columnName, string headerText)
        {
            if (dgvPaymentHistory.Columns.Contains(columnName))
            {
                dgvPaymentHistory.Columns[columnName].HeaderText =
                    headerText;
            }
        }

        // CLEAR FORM
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            durationTimer.Stop();

            selectedEntryId = 0;
            selectedSlotId = 0;

            calculatedFee = 0;
            feeCalculated = false;
            paymentProcessed = false;

            cmbPlateNumber.SelectedIndex = -1;
            cmbPaymentMethod.SelectedIndex = -1;

            txtOwnerName.Clear();
            txtVehicleType.Clear();
            txtSlotNumber.Clear();
            txtEntryTime.Clear();
            txtDuration.Clear();
            txtTotalAmount.Clear();

            dtpExitTime.Value = DateTime.Now;

            cmbPaymentStatus.SelectedItem = "Pending";
        }

        // BACK TO DASHBOARD
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            durationTimer.Stop();
            Close();
        }

        // STOP TIMER WHEN FORM CLOSES
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            durationTimer.Stop();
            durationTimer.Dispose();

            base.OnFormClosed(e);
        }
    }
}
