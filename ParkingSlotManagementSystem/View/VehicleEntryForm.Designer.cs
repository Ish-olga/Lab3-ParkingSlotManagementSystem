
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingSlotManagementSystem.View
{
    partial class VehicleEntryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        private GroupBox grpVehicleInformation;
        private Label lblPlateNumber;
        private ComboBox cmbPlateNumber;
        private Label lblOwnerName;
        private TextBox txtOwnerName;
        private Label lblVehicleType;
        private TextBox txtVehicleType;
        private Label lblParkingSlot;
        private Label lblEntryTime;
        private DateTimePicker dtpEntryTime;
        private ComboBox cmbParkingSlot;

        private Button btnRegisterEntry;
        private Button btnClear;
        private Button btnRefresh;
        private Button btnDashboard;

        private Label lblRecentActivity;
        private DataGridView dgvVehicleEntries;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            grpVehicleInformation = new GroupBox();
            cmbParkingSlot = new ComboBox();
            lblPlateNumber = new Label();
            cmbPlateNumber = new ComboBox();
            lblOwnerName = new Label();
            txtOwnerName = new TextBox();
            lblVehicleType = new Label();
            txtVehicleType = new TextBox();
            lblParkingSlot = new Label();
            lblEntryTime = new Label();
            dtpEntryTime = new DateTimePicker();
            btnRegisterEntry = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            btnDashboard = new Button();
            lblRecentActivity = new Label();
            dgvVehicleEntries = new DataGridView();
            pnlHeader.SuspendLayout();
            grpVehicleInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleEntries).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(25, 43, 68);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1100, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(207, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "VEHICLE ENTRY";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.LightGray;
            lblSubtitle.Location = new Point(33, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(277, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Register incoming vehicles and assign parking slots";
            // 
            // grpVehicleInformation
            // 
            grpVehicleInformation.Controls.Add(cmbParkingSlot);
            grpVehicleInformation.Controls.Add(lblPlateNumber);
            grpVehicleInformation.Controls.Add(cmbPlateNumber);
            grpVehicleInformation.Controls.Add(lblOwnerName);
            grpVehicleInformation.Controls.Add(txtOwnerName);
            grpVehicleInformation.Controls.Add(lblVehicleType);
            grpVehicleInformation.Controls.Add(txtVehicleType);
            grpVehicleInformation.Controls.Add(lblParkingSlot);
            grpVehicleInformation.Controls.Add(lblEntryTime);
            grpVehicleInformation.Controls.Add(dtpEntryTime);
            grpVehicleInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpVehicleInformation.ForeColor = Color.FromArgb(25, 43, 68);
            grpVehicleInformation.Location = new Point(30, 105);
            grpVehicleInformation.Name = "grpVehicleInformation";
            grpVehicleInformation.Size = new Size(1040, 254);
            grpVehicleInformation.TabIndex = 1;
            grpVehicleInformation.TabStop = false;
            grpVehicleInformation.Text = "VEHICLE INFORMATION";
            // 
            // cmbParkingSlot
            // 
            cmbParkingSlot.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParkingSlot.FormattingEnabled = true;
            cmbParkingSlot.Location = new Point(569, 148);
            cmbParkingSlot.Name = "cmbParkingSlot";
            cmbParkingSlot.Size = new Size(165, 25);
            cmbParkingSlot.TabIndex = 10;
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Location = new Point(30, 40);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(102, 19);
            lblPlateNumber.TabIndex = 0;
            lblPlateNumber.Text = "Plate Number";
            // 
            // cmbPlateNumber
            // 
            cmbPlateNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlateNumber.Location = new Point(30, 65);
            cmbPlateNumber.Name = "cmbPlateNumber";
            cmbPlateNumber.Size = new Size(430, 25);
            cmbPlateNumber.TabIndex = 1;
            // 
            // lblOwnerName
            // 
            lblOwnerName.AutoSize = true;
            lblOwnerName.Location = new Point(550, 40);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(97, 19);
            lblOwnerName.TabIndex = 2;
            lblOwnerName.Text = "Owner Name";
            // 
            // txtOwnerName
            // 
            txtOwnerName.Location = new Point(550, 65);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.ReadOnly = true;
            txtOwnerName.Size = new Size(430, 25);
            txtOwnerName.TabIndex = 3;
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Location = new Point(30, 115);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(92, 19);
            lblVehicleType.TabIndex = 4;
            lblVehicleType.Text = "Vehicle Type";
            // 
            // txtVehicleType
            // 
            txtVehicleType.Location = new Point(30, 140);
            txtVehicleType.Name = "txtVehicleType";
            txtVehicleType.ReadOnly = true;
            txtVehicleType.Size = new Size(430, 25);
            txtVehicleType.TabIndex = 5;
            // 
            // lblParkingSlot
            // 
            lblParkingSlot.AutoSize = true;
            lblParkingSlot.Location = new Point(550, 115);
            lblParkingSlot.Name = "lblParkingSlot";
            lblParkingSlot.Size = new Size(158, 19);
            lblParkingSlot.TabIndex = 6;
            lblParkingSlot.Text = "Available Parking Slot";
            // 
            // lblEntryTime
            // 
            lblEntryTime.AutoSize = true;
            lblEntryTime.Location = new Point(30, 175);
            lblEntryTime.Name = "lblEntryTime";
            lblEntryTime.Size = new Size(145, 19);
            lblEntryTime.TabIndex = 8;
            lblEntryTime.Text = "Entry Date and Time";
            // 
            // dtpEntryTime
            // 
            dtpEntryTime.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEntryTime.Format = DateTimePickerFormat.Custom;
            dtpEntryTime.Location = new Point(30, 195);
            dtpEntryTime.Name = "dtpEntryTime";
            dtpEntryTime.ShowUpDown = true;
            dtpEntryTime.Size = new Size(430, 25);
            dtpEntryTime.TabIndex = 9;
            // 
            // btnRegisterEntry
            // 
            btnRegisterEntry.BackColor = Color.FromArgb(107, 114, 128);
            btnRegisterEntry.FlatAppearance.BorderSize = 0;
            btnRegisterEntry.FlatStyle = FlatStyle.Flat;
            btnRegisterEntry.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegisterEntry.ForeColor = Color.White;
            btnRegisterEntry.Location = new Point(30, 375);
            btnRegisterEntry.Name = "btnRegisterEntry";
            btnRegisterEntry.Size = new Size(180, 42);
            btnRegisterEntry.TabIndex = 2;
            btnRegisterEntry.Text = "REGISTER ENTRY";
            btnRegisterEntry.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(107, 114, 128);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(225, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 42);
            btnClear.TabIndex = 3;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(107, 114, 128);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(370, 375);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 42);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(107, 114, 128);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(558, 375);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 42);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "BACK TO DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblRecentActivity
            // 
            lblRecentActivity.AutoSize = true;
            lblRecentActivity.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecentActivity.ForeColor = Color.FromArgb(25, 43, 68);
            lblRecentActivity.Location = new Point(30, 435);
            lblRecentActivity.Name = "lblRecentActivity";
            lblRecentActivity.Size = new Size(206, 21);
            lblRecentActivity.TabIndex = 6;
            lblRecentActivity.Text = "RECENT VEHICLE ENTRIES";
            // 
            // dgvVehicleEntries
            // 
            dgvVehicleEntries.AllowUserToAddRows = false;
            dgvVehicleEntries.AllowUserToDeleteRows = false;
            dgvVehicleEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehicleEntries.BackgroundColor = Color.White;
            dgvVehicleEntries.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 43, 68);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVehicleEntries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVehicleEntries.ColumnHeadersHeight = 40;
            dgvVehicleEntries.EnableHeadersVisualStyles = false;
            dgvVehicleEntries.Location = new Point(30, 470);
            dgvVehicleEntries.Name = "dgvVehicleEntries";
            dgvVehicleEntries.ReadOnly = true;
            dgvVehicleEntries.RowHeadersVisible = false;
            dgvVehicleEntries.RowTemplate.Height = 35;
            dgvVehicleEntries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicleEntries.Size = new Size(1040, 210);
            dgvVehicleEntries.TabIndex = 7;
            // 
            // VehicleEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 248, 247);
            ClientSize = new Size(1100, 701);
            Controls.Add(pnlHeader);
            Controls.Add(grpVehicleInformation);
            Controls.Add(btnRegisterEntry);
            Controls.Add(btnClear);
            Controls.Add(btnRefresh);
            Controls.Add(btnDashboard);
            Controls.Add(lblRecentActivity);
            Controls.Add(dgvVehicleEntries);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "VehicleEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehicle Entry";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpVehicleInformation.ResumeLayout(false);
            grpVehicleInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleEntries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
