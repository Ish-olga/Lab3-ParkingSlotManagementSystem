
using System.Drawing;
using System.Windows.Forms;

namespace ParkingSlotManagementSystem.View
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnExitPayment = new Button();
            btnVehicleEntry = new Button();
            btnParkingSlots = new Button();
            btnOwnerVehicle = new Button();
            btnDashboard = new Button();
            lblMenuTitle = new Label();
            lblSystemSubtitle = new Label();
            lblSystemName = new Label();
            pnlHeader = new Panel();
            dgvRecentActivity = new DataGridView();
            pnlTotalSlots = new Panel();
            pnlCardTotal = new Panel();
            lblTotalSlotsTitle = new Label();
            lblTotalSlotsValue = new Label();
            pnlAvailableSlots = new Panel();
            lblAvailableSlotsTitle = new Label();
            lblAvailableSlotsValue = new Label();
            pnlOccupiedSlots = new Panel();
            lblOccupiedSlotsTitle = new Label();
            lblOccupiedSlotsValue = new Label();
            pnlRegisteredOwners = new Panel();
            lblRegisteredOwnersTitle = new Label();
            lblRegisteredOwnersValue = new Label();
            pnlTodayEntries = new Panel();
            lblTodayEntriesTitle = new Label();
            lblTodayEntriesValue = new Label();
            pnlTodayRevenue = new Panel();
            lblTodayRevenueTitle = new Label();
            lblTodayRevenueValue = new Label();
            lblUserRole = new Label();
            lblDate = new Label();
            lblWelcome = new Label();
            lblDashboardTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivity).BeginInit();
            pnlTotalSlots.SuspendLayout();
            pnlCardTotal.SuspendLayout();
            pnlAvailableSlots.SuspendLayout();
            pnlOccupiedSlots.SuspendLayout();
            pnlRegisteredOwners.SuspendLayout();
            pnlTodayEntries.SuspendLayout();
            pnlTodayRevenue.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSidebar.BackColor = Color.FromArgb(25, 43, 68);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnExitPayment);
            pnlSidebar.Controls.Add(btnVehicleEntry);
            pnlSidebar.Controls.Add(btnParkingSlots);
            pnlSidebar.Controls.Add(btnOwnerVehicle);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblMenuTitle);
            pnlSidebar.Controls.Add(lblSystemSubtitle);
            pnlSidebar.Controls.Add(lblSystemName);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(242, 650);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(25, 43, 68);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 394);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(210, 45);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExitPayment
            // 
            btnExitPayment.BackColor = Color.FromArgb(25, 43, 68);
            btnExitPayment.FlatAppearance.BorderSize = 0;
            btnExitPayment.FlatStyle = FlatStyle.Flat;
            btnExitPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExitPayment.ForeColor = Color.White;
            btnExitPayment.Location = new Point(12, 289);
            btnExitPayment.Name = "btnExitPayment";
            btnExitPayment.Size = new Size(210, 45);
            btnExitPayment.TabIndex = 11;
            btnExitPayment.Text = "Exit & Payment";
            btnExitPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnExitPayment.UseVisualStyleBackColor = false;
            btnExitPayment.Click += btnExitPayment_Click;
            // 
            // btnVehicleEntry
            // 
            btnVehicleEntry.BackColor = Color.FromArgb(25, 43, 68);
            btnVehicleEntry.FlatAppearance.BorderSize = 0;
            btnVehicleEntry.FlatStyle = FlatStyle.Flat;
            btnVehicleEntry.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVehicleEntry.ForeColor = Color.White;
            btnVehicleEntry.Location = new Point(12, 238);
            btnVehicleEntry.Name = "btnVehicleEntry";
            btnVehicleEntry.Size = new Size(210, 45);
            btnVehicleEntry.TabIndex = 10;
            btnVehicleEntry.Text = "Vehicle Entry";
            btnVehicleEntry.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicleEntry.UseVisualStyleBackColor = false;
            btnVehicleEntry.Click += btnVehicleEntry_Click;
            // 
            // btnParkingSlots
            // 
            btnParkingSlots.BackColor = Color.FromArgb(25, 43, 68);
            btnParkingSlots.FlatAppearance.BorderSize = 0;
            btnParkingSlots.FlatStyle = FlatStyle.Flat;
            btnParkingSlots.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnParkingSlots.ForeColor = Color.White;
            btnParkingSlots.Location = new Point(12, 187);
            btnParkingSlots.Name = "btnParkingSlots";
            btnParkingSlots.Size = new Size(210, 45);
            btnParkingSlots.TabIndex = 9;
            btnParkingSlots.Text = "Parking Slots";
            btnParkingSlots.TextAlign = ContentAlignment.MiddleLeft;
            btnParkingSlots.UseVisualStyleBackColor = false;
            btnParkingSlots.Click += btnParkingSlots_Click;
            // 
            // btnOwnerVehicle
            // 
            btnOwnerVehicle.BackColor = Color.FromArgb(25, 43, 68);
            btnOwnerVehicle.FlatAppearance.BorderSize = 0;
            btnOwnerVehicle.FlatStyle = FlatStyle.Flat;
            btnOwnerVehicle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOwnerVehicle.ForeColor = Color.White;
            btnOwnerVehicle.Location = new Point(12, 136);
            btnOwnerVehicle.Name = "btnOwnerVehicle";
            btnOwnerVehicle.Size = new Size(210, 45);
            btnOwnerVehicle.TabIndex = 8;
            btnOwnerVehicle.Text = "Owners & Vehicles";
            btnOwnerVehicle.TextAlign = ContentAlignment.MiddleLeft;
            btnOwnerVehicle.UseVisualStyleBackColor = false;
            btnOwnerVehicle.Click += btnOwnerVehicle_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(46, 139, 104);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(12, 85);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(210, 45);
            btnDashboard.TabIndex = 7;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMenuTitle.ForeColor = Color.FromArgb(203, 213, 225);
            lblMenuTitle.Location = new Point(12, 60);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(77, 15);
            lblMenuTitle.TabIndex = 13;
            lblMenuTitle.Text = "MAIN MENU";
            // 
            // lblSystemSubtitle
            // 
            lblSystemSubtitle.AutoSize = true;
            lblSystemSubtitle.BackColor = Color.Transparent;
            lblSystemSubtitle.Font = new Font("Segoe UI", 9F);
            lblSystemSubtitle.ForeColor = Color.LightGray;
            lblSystemSubtitle.Location = new Point(12, 37);
            lblSystemSubtitle.Name = "lblSystemSubtitle";
            lblSystemSubtitle.Size = new Size(120, 15);
            lblSystemSubtitle.TabIndex = 14;
            lblSystemSubtitle.Text = "SLOT MANAGEMENT";
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.BackColor = Color.Transparent;
            lblSystemName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSystemName.ForeColor = Color.White;
            lblSystemName.Location = new Point(3, 0);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(181, 28);
            lblSystemName.TabIndex = 15;
            lblSystemName.Text = "PARKING SYSTEM";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(dgvRecentActivity);
            pnlHeader.Controls.Add(pnlTotalSlots);
            pnlHeader.Controls.Add(lblUserRole);
            pnlHeader.Controls.Add(lblDate);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblDashboardTitle);
            pnlHeader.Location = new Point(242, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(742, 650);
            pnlHeader.TabIndex = 1;
            // 
            // dgvRecentActivity
            // 
            dgvRecentActivity.BackgroundColor = Color.White;
            dgvRecentActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentActivity.Location = new Point(6, 373);
            dgvRecentActivity.Name = "dgvRecentActivity";
            dgvRecentActivity.Size = new Size(736, 248);
            dgvRecentActivity.TabIndex = 5;
            // 
            // pnlTotalSlots
            // 
            pnlTotalSlots.Controls.Add(pnlCardTotal);
            pnlTotalSlots.Controls.Add(pnlAvailableSlots);
            pnlTotalSlots.Controls.Add(pnlOccupiedSlots);
            pnlTotalSlots.Controls.Add(pnlRegisteredOwners);
            pnlTotalSlots.Controls.Add(pnlTodayEntries);
            pnlTotalSlots.Controls.Add(pnlTodayRevenue);
            pnlTotalSlots.Location = new Point(10, 121);
            pnlTotalSlots.Name = "pnlTotalSlots";
            pnlTotalSlots.Size = new Size(720, 233);
            pnlTotalSlots.TabIndex = 4;
            // 
            // pnlCardTotal
            // 
            pnlCardTotal.BackColor = Color.White;
            pnlCardTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlCardTotal.Controls.Add(lblTotalSlotsTitle);
            pnlCardTotal.Controls.Add(lblTotalSlotsValue);
            pnlCardTotal.Location = new Point(5, 5);
            pnlCardTotal.Name = "pnlCardTotal";
            pnlCardTotal.Size = new Size(220, 105);
            pnlCardTotal.TabIndex = 0;
            // 
            // lblTotalSlotsTitle
            // 
            lblTotalSlotsTitle.AutoSize = true;
            lblTotalSlotsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalSlotsTitle.ForeColor = Color.FromArgb(25, 43, 68);
            lblTotalSlotsTitle.Location = new Point(12, 15);
            lblTotalSlotsTitle.Name = "lblTotalSlotsTitle";
            lblTotalSlotsTitle.Size = new Size(137, 15);
            lblTotalSlotsTitle.TabIndex = 0;
            lblTotalSlotsTitle.Text = "TOTAL PARKING SLOTS";
            // 
            // lblTotalSlotsValue
            // 
            lblTotalSlotsValue.AutoSize = true;
            lblTotalSlotsValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalSlotsValue.ForeColor = Color.FromArgb(46, 139, 104);
            lblTotalSlotsValue.Location = new Point(12, 43);
            lblTotalSlotsValue.Name = "lblTotalSlotsValue";
            lblTotalSlotsValue.Size = new Size(35, 41);
            lblTotalSlotsValue.TabIndex = 1;
            lblTotalSlotsValue.Text = "0";
            // 
            // pnlAvailableSlots
            // 
            pnlAvailableSlots.BackColor = Color.White;
            pnlAvailableSlots.BorderStyle = BorderStyle.FixedSingle;
            pnlAvailableSlots.Controls.Add(lblAvailableSlotsTitle);
            pnlAvailableSlots.Controls.Add(lblAvailableSlotsValue);
            pnlAvailableSlots.Location = new Point(245, 5);
            pnlAvailableSlots.Name = "pnlAvailableSlots";
            pnlAvailableSlots.Size = new Size(220, 105);
            pnlAvailableSlots.TabIndex = 1;
            // 
            // lblAvailableSlotsTitle
            // 
            lblAvailableSlotsTitle.AutoSize = true;
            lblAvailableSlotsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAvailableSlotsTitle.ForeColor = Color.FromArgb(25, 43, 68);
            lblAvailableSlotsTitle.Location = new Point(12, 15);
            lblAvailableSlotsTitle.Name = "lblAvailableSlotsTitle";
            lblAvailableSlotsTitle.Size = new Size(106, 15);
            lblAvailableSlotsTitle.TabIndex = 0;
            lblAvailableSlotsTitle.Text = "AVAILABLE SLOTS";
            // 
            // lblAvailableSlotsValue
            // 
            lblAvailableSlotsValue.AutoSize = true;
            lblAvailableSlotsValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblAvailableSlotsValue.ForeColor = Color.FromArgb(46, 139, 104);
            lblAvailableSlotsValue.Location = new Point(12, 43);
            lblAvailableSlotsValue.Name = "lblAvailableSlotsValue";
            lblAvailableSlotsValue.Size = new Size(35, 41);
            lblAvailableSlotsValue.TabIndex = 1;
            lblAvailableSlotsValue.Text = "0";
            // 
            // pnlOccupiedSlots
            // 
            pnlOccupiedSlots.BackColor = Color.White;
            pnlOccupiedSlots.BorderStyle = BorderStyle.FixedSingle;
            pnlOccupiedSlots.Controls.Add(lblOccupiedSlotsTitle);
            pnlOccupiedSlots.Controls.Add(lblOccupiedSlotsValue);
            pnlOccupiedSlots.Location = new Point(485, 5);
            pnlOccupiedSlots.Name = "pnlOccupiedSlots";
            pnlOccupiedSlots.Size = new Size(220, 105);
            pnlOccupiedSlots.TabIndex = 2;
            // 
            // lblOccupiedSlotsTitle
            // 
            lblOccupiedSlotsTitle.AutoSize = true;
            lblOccupiedSlotsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOccupiedSlotsTitle.ForeColor = Color.FromArgb(25, 43, 68);
            lblOccupiedSlotsTitle.Location = new Point(12, 15);
            lblOccupiedSlotsTitle.Name = "lblOccupiedSlotsTitle";
            lblOccupiedSlotsTitle.Size = new Size(104, 15);
            lblOccupiedSlotsTitle.TabIndex = 0;
            lblOccupiedSlotsTitle.Text = "OCCUPIED SLOTS";
            // 
            // lblOccupiedSlotsValue
            // 
            lblOccupiedSlotsValue.AutoSize = true;
            lblOccupiedSlotsValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblOccupiedSlotsValue.ForeColor = Color.FromArgb(46, 139, 104);
            lblOccupiedSlotsValue.Location = new Point(12, 43);
            lblOccupiedSlotsValue.Name = "lblOccupiedSlotsValue";
            lblOccupiedSlotsValue.Size = new Size(35, 41);
            lblOccupiedSlotsValue.TabIndex = 1;
            lblOccupiedSlotsValue.Text = "0";
            // 
            // pnlRegisteredOwners
            // 
            pnlRegisteredOwners.BackColor = Color.White;
            pnlRegisteredOwners.BorderStyle = BorderStyle.FixedSingle;
            pnlRegisteredOwners.Controls.Add(lblRegisteredOwnersTitle);
            pnlRegisteredOwners.Controls.Add(lblRegisteredOwnersValue);
            pnlRegisteredOwners.Location = new Point(5, 130);
            pnlRegisteredOwners.Name = "pnlRegisteredOwners";
            pnlRegisteredOwners.Size = new Size(220, 105);
            pnlRegisteredOwners.TabIndex = 3;
            // 
            // lblRegisteredOwnersTitle
            // 
            lblRegisteredOwnersTitle.AutoSize = true;
            lblRegisteredOwnersTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRegisteredOwnersTitle.ForeColor = Color.FromArgb(25, 43, 68);
            lblRegisteredOwnersTitle.Location = new Point(12, 15);
            lblRegisteredOwnersTitle.Name = "lblRegisteredOwnersTitle";
            lblRegisteredOwnersTitle.Size = new Size(131, 15);
            lblRegisteredOwnersTitle.TabIndex = 0;
            lblRegisteredOwnersTitle.Text = "REGISTERED OWNERS";
            // 
            // lblRegisteredOwnersValue
            // 
            lblRegisteredOwnersValue.AutoSize = true;
            lblRegisteredOwnersValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblRegisteredOwnersValue.ForeColor = Color.FromArgb(46, 139, 104);
            lblRegisteredOwnersValue.Location = new Point(12, 43);
            lblRegisteredOwnersValue.Name = "lblRegisteredOwnersValue";
            lblRegisteredOwnersValue.Size = new Size(35, 41);
            lblRegisteredOwnersValue.TabIndex = 1;
            lblRegisteredOwnersValue.Text = "0";
            // 
            // pnlTodayEntries
            // 
            pnlTodayEntries.BackColor = Color.White;
            pnlTodayEntries.BorderStyle = BorderStyle.FixedSingle;
            pnlTodayEntries.Controls.Add(lblTodayEntriesTitle);
            pnlTodayEntries.Controls.Add(lblTodayEntriesValue);
            pnlTodayEntries.Location = new Point(245, 130);
            pnlTodayEntries.Name = "pnlTodayEntries";
            pnlTodayEntries.Size = new Size(220, 105);
            pnlTodayEntries.TabIndex = 4;
            // 
            // lblTodayEntriesTitle
            // 
            lblTodayEntriesTitle.AutoSize = true;
            lblTodayEntriesTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTodayEntriesTitle.ForeColor = Color.FromArgb(25, 43, 68);
            lblTodayEntriesTitle.Location = new Point(12, 15);
            lblTodayEntriesTitle.Name = "lblTodayEntriesTitle";
            lblTodayEntriesTitle.Size = new Size(107, 15);
            lblTodayEntriesTitle.TabIndex = 0;
            lblTodayEntriesTitle.Text = "TODAY'S ENTRIES";
            // 
            // lblTodayEntriesValue
            // 
            lblTodayEntriesValue.AutoSize = true;
            lblTodayEntriesValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTodayEntriesValue.ForeColor = Color.FromArgb(46, 139, 104);
            lblTodayEntriesValue.Location = new Point(12, 43);
            lblTodayEntriesValue.Name = "lblTodayEntriesValue";
            lblTodayEntriesValue.Size = new Size(35, 41);
            lblTodayEntriesValue.TabIndex = 1;
            lblTodayEntriesValue.Text = "0";
            // 
            // pnlTodayRevenue
            // 
            pnlTodayRevenue.BackColor = Color.White;
            pnlTodayRevenue.BorderStyle = BorderStyle.FixedSingle;
            pnlTodayRevenue.Controls.Add(lblTodayRevenueTitle);
            pnlTodayRevenue.Controls.Add(lblTodayRevenueValue);
            pnlTodayRevenue.Location = new Point(485, 130);
            pnlTodayRevenue.Name = "pnlTodayRevenue";
            pnlTodayRevenue.Size = new Size(220, 105);
            pnlTodayRevenue.TabIndex = 5;
            // 
            // lblTodayRevenueTitle
            // 
            lblTodayRevenueTitle.AutoSize = true;
            lblTodayRevenueTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTodayRevenueTitle.ForeColor = Color.FromArgb(25, 43, 68);
            lblTodayRevenueTitle.Location = new Point(12, 15);
            lblTodayRevenueTitle.Name = "lblTodayRevenueTitle";
            lblTodayRevenueTitle.Size = new Size(112, 15);
            lblTodayRevenueTitle.TabIndex = 0;
            lblTodayRevenueTitle.Text = "TODAY'S REVENUE";
            // 
            // lblTodayRevenueValue
            // 
            lblTodayRevenueValue.AutoSize = true;
            lblTodayRevenueValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTodayRevenueValue.ForeColor = Color.FromArgb(46, 139, 104);
            lblTodayRevenueValue.Location = new Point(12, 43);
            lblTodayRevenueValue.Name = "lblTodayRevenueValue";
            lblTodayRevenueValue.Size = new Size(109, 41);
            lblTodayRevenueValue.TabIndex = 1;
            lblTodayRevenueValue.Text = "0 RWF";
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.ForeColor = Color.FromArgb(46, 139, 104);
            lblUserRole.Location = new Point(16, 90);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(80, 15);
            lblUserRole.TabIndex = 0;
            lblUserRole.Text = "Administrator";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(16, 65);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(105, 15);
            lblDate.TabIndex = 1;
            lblDate.Text = "17 November 2026";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11F);
            lblWelcome.ForeColor = Color.FromArgb(23, 33, 43);
            lblWelcome.Location = new Point(10, 37);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(110, 20);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome back!";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblDashboardTitle.ForeColor = Color.FromArgb(23, 33, 43);
            lblDashboardTitle.Location = new Point(0, 0);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(286, 37);
            lblDashboardTitle.TabIndex = 3;
            lblDashboardTitle.Text = "Dashboard Overview";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(984, 650);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1000, 650);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parking Slot Management System";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivity).EndInit();
            pnlTotalSlots.ResumeLayout(false);
            pnlCardTotal.ResumeLayout(false);
            pnlCardTotal.PerformLayout();
            pnlAvailableSlots.ResumeLayout(false);
            pnlAvailableSlots.PerformLayout();
            pnlOccupiedSlots.ResumeLayout(false);
            pnlOccupiedSlots.PerformLayout();
            pnlRegisteredOwners.ResumeLayout(false);
            pnlRegisteredOwners.PerformLayout();
            pnlTodayEntries.ResumeLayout(false);
            pnlTodayEntries.PerformLayout();
            pnlTodayRevenue.ResumeLayout(false);
            pnlTodayRevenue.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlTotalSlots;

        private Panel pnlCardTotal;
        private Panel pnlAvailableSlots;
        private Panel pnlOccupiedSlots;
        private Panel pnlRegisteredOwners;
        private Panel pnlTodayEntries;
        private Panel pnlTodayRevenue;

        private Label lblSystemName;
        private Label lblSystemSubtitle;
        private Label lblMenuTitle;
        private Label lblDashboardTitle;
        private Label lblWelcome;
        private Label lblDate;
        private Label lblUserRole;

        private Label lblTotalSlotsTitle;
        private Label lblTotalSlotsValue;
        private Label lblAvailableSlotsTitle;
        private Label lblAvailableSlotsValue;
        private Label lblOccupiedSlotsTitle;
        private Label lblOccupiedSlotsValue;
        private Label lblRegisteredOwnersTitle;
        private Label lblRegisteredOwnersValue;
        private Label lblTodayEntriesTitle;
        private Label lblTodayEntriesValue;
        private Label lblTodayRevenueTitle;
        private Label lblTodayRevenueValue;

        private Button btnDashboard;
        private Button btnOwnerVehicle;
        private Button btnParkingSlots;
        private Button btnVehicleEntry;
        private Button btnExitPayment;
        private Button btnLogout;
        private DataGridView dgvRecentActivity;
    }
}
