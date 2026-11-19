
namespace ParkingSlotManagementSystem.View
{
    partial class ExitPaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblSlotNumber;
        private System.Windows.Forms.Label lblEntryTime;
        private System.Windows.Forms.Label lblExitTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblPaymentStatus;

        private System.Windows.Forms.ComboBox cmbPlateNumber;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;

        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtVehicleType;
        private System.Windows.Forms.TextBox txtSlotNumber;
        private System.Windows.Forms.TextBox txtEntryTime;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtTotalAmount;

        private System.Windows.Forms.DateTimePicker dtpExitTime;

        private System.Windows.Forms.Button btnCalculateFee;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnRegisterExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDashboard;

        private System.Windows.Forms.DataGridView dgvPaymentHistory;
        private System.Windows.Forms.Label lblPaymentHistory;

        private System.Windows.Forms.GroupBox grpVehicleInformation;
        private System.Windows.Forms.GroupBox grpPaymentInformation;

        private ComboBox cmbPaymentStatus;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            grpVehicleInformation = new GroupBox();
            lblPlateNumber = new Label();
            cmbPlateNumber = new ComboBox();
            lblOwnerName = new Label();
            txtOwnerName = new TextBox();
            lblVehicleType = new Label();
            txtVehicleType = new TextBox();
            lblSlotNumber = new Label();
            txtSlotNumber = new TextBox();
            lblEntryTime = new Label();
            txtEntryTime = new TextBox();
            lblExitTime = new Label();
            dtpExitTime = new DateTimePicker();
            grpPaymentInformation = new GroupBox();
            cmbPaymentStatus = new ComboBox();
            lblDuration = new Label();
            txtDuration = new TextBox();
            lblTotalAmount = new Label();
            txtTotalAmount = new TextBox();
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            lblPaymentStatus = new Label();
            btnCalculateFee = new Button();
            btnProcessPayment = new Button();
            btnRegisterExit = new Button();
            btnClear = new Button();
            btnDashboard = new Button();
            dgvPaymentHistory = new DataGridView();
            lblPaymentHistory = new Label();
            grpVehicleInformation.SuspendLayout();
            grpPaymentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentHistory).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 45, 75);
            lblTitle.Location = new Point(26, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = " EXIT & PAYMENT";
            // 
            // grpVehicleInformation
            // 
            grpVehicleInformation.Controls.Add(lblPlateNumber);
            grpVehicleInformation.Controls.Add(cmbPlateNumber);
            grpVehicleInformation.Controls.Add(lblOwnerName);
            grpVehicleInformation.Controls.Add(txtOwnerName);
            grpVehicleInformation.Controls.Add(lblVehicleType);
            grpVehicleInformation.Controls.Add(txtVehicleType);
            grpVehicleInformation.Controls.Add(lblSlotNumber);
            grpVehicleInformation.Controls.Add(txtSlotNumber);
            grpVehicleInformation.Controls.Add(lblEntryTime);
            grpVehicleInformation.Controls.Add(txtEntryTime);
            grpVehicleInformation.Controls.Add(lblExitTime);
            grpVehicleInformation.Controls.Add(dtpExitTime);
            grpVehicleInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpVehicleInformation.Location = new Point(26, 80);
            grpVehicleInformation.Name = "grpVehicleInformation";
            grpVehicleInformation.Size = new Size(901, 207);
            grpVehicleInformation.TabIndex = 1;
            grpVehicleInformation.TabStop = false;
            grpVehicleInformation.Text = "Vehicle Information";
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Location = new Point(22, 38);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(107, 19);
            lblPlateNumber.TabIndex = 0;
            lblPlateNumber.Text = "Plate Number:";
            // 
            // cmbPlateNumber
            // 
            cmbPlateNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlateNumber.Location = new Point(158, 33);
            cmbPlateNumber.Name = "cmbPlateNumber";
            cmbPlateNumber.Size = new Size(263, 25);
            cmbPlateNumber.TabIndex = 1;
            // 
            // lblOwnerName
            // 
            lblOwnerName.AutoSize = true;
            lblOwnerName.Location = new Point(22, 80);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(101, 19);
            lblOwnerName.TabIndex = 2;
            lblOwnerName.Text = "Owner Name:";
            
            txtOwnerName.Location = new Point(158, 75);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.ReadOnly = true;
            txtOwnerName.Size = new Size(263, 25);
            txtOwnerName.TabIndex = 3;
           
            lblVehicleType.AutoSize = true;
            lblVehicleType.Location = new Point(481, 38);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(96, 19);
            lblVehicleType.TabIndex = 4;
            lblVehicleType.Text = "Vehicle Type:";
           
            txtVehicleType.Location = new Point(612, 33);
            txtVehicleType.Name = "txtVehicleType";
            txtVehicleType.ReadOnly = true;
            txtVehicleType.Size = new Size(246, 25);
            txtVehicleType.TabIndex = 5;
           
            lblSlotNumber.AutoSize = true;
            lblSlotNumber.Location = new Point(481, 80);
            lblSlotNumber.Name = "lblSlotNumber";
            lblSlotNumber.Size = new Size(99, 19);
            lblSlotNumber.TabIndex = 6;
            lblSlotNumber.Text = "Slot Number:";
          
            txtSlotNumber.Location = new Point(612, 75);
            txtSlotNumber.Name = "txtSlotNumber";
            txtSlotNumber.ReadOnly = true;
            txtSlotNumber.Size = new Size(246, 25);
            txtSlotNumber.TabIndex = 7;
            // 
            // lblEntryTime
            // 
            lblEntryTime.AutoSize = true;
            lblEntryTime.Location = new Point(22, 127);
            lblEntryTime.Name = "lblEntryTime";
            lblEntryTime.Size = new Size(85, 19);
            lblEntryTime.TabIndex = 8;
            lblEntryTime.Text = "Entry Time:";
            // 
            // txtEntryTime
            // 
            txtEntryTime.Location = new Point(158, 122);
            txtEntryTime.Name = "txtEntryTime";
            txtEntryTime.ReadOnly = true;
            txtEntryTime.Size = new Size(263, 25);
            txtEntryTime.TabIndex = 9;
            // 
            // lblExitTime
            // 
            lblExitTime.AutoSize = true;
            lblExitTime.Location = new Point(481, 127);
            lblExitTime.Name = "lblExitTime";
            lblExitTime.Size = new Size(74, 19);
            lblExitTime.TabIndex = 10;
            lblExitTime.Text = "Exit Time:";
            // 
            // dtpExitTime
            // 
            dtpExitTime.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpExitTime.Format = DateTimePickerFormat.Custom;
            dtpExitTime.Location = new Point(612, 122);
            dtpExitTime.Name = "dtpExitTime";
            dtpExitTime.Size = new Size(246, 25);
            dtpExitTime.TabIndex = 11;
            // 
            // grpPaymentInformation
            // 
            grpPaymentInformation.Controls.Add(cmbPaymentStatus);
            grpPaymentInformation.Controls.Add(lblDuration);
            grpPaymentInformation.Controls.Add(txtDuration);
            grpPaymentInformation.Controls.Add(lblTotalAmount);
            grpPaymentInformation.Controls.Add(txtTotalAmount);
            grpPaymentInformation.Controls.Add(lblPaymentMethod);
            grpPaymentInformation.Controls.Add(cmbPaymentMethod);
            grpPaymentInformation.Controls.Add(lblPaymentStatus);
            grpPaymentInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPaymentInformation.Location = new Point(26, 314);
            grpPaymentInformation.Name = "grpPaymentInformation";
            grpPaymentInformation.Size = new Size(901, 180);
            grpPaymentInformation.TabIndex = 2;
            grpPaymentInformation.TabStop = false;
            grpPaymentInformation.Text = "Payment Information";
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(632, 87);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(212, 25);
            cmbPaymentStatus.TabIndex = 7;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(22, 42);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(71, 19);
            lblDuration.TabIndex = 0;
            lblDuration.Text = "Duration:";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(158, 38);
            txtDuration.Name = "txtDuration";
            txtDuration.ReadOnly = true;
            txtDuration.Size = new Size(263, 25);
            txtDuration.TabIndex = 1;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(481, 42);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(103, 19);
            lblTotalAmount.TabIndex = 2;
            lblTotalAmount.Text = "Total Amount:";
           
            txtTotalAmount.Location = new Point(612, 38);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(246, 25);
            txtTotalAmount.TabIndex = 3;
           
          
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(22, 89);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(128, 19);
            lblPaymentMethod.TabIndex = 4;
            lblPaymentMethod.Text = "Payment Method:";
           
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Mobile Money", "Card" });
            cmbPaymentMethod.Location = new Point(158, 84);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(263, 25);
            cmbPaymentMethod.TabIndex = 5;
           
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Location = new Point(481, 89);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(116, 19);
            lblPaymentStatus.TabIndex = 6;
            lblPaymentStatus.Text = "Payment Status:";
          
            btnCalculateFee.BackColor = Color.FromArgb(25, 45, 75);
            btnCalculateFee.FlatStyle = FlatStyle.Flat;
            btnCalculateFee.ForeColor = Color.White;
            btnCalculateFee.Location = new Point(12, 520);
            btnCalculateFee.Name = "btnCalculateFee";
            btnCalculateFee.Size = new Size(149, 39);
            btnCalculateFee.TabIndex = 3;
            btnCalculateFee.Text = "Calculate Fee";
            btnCalculateFee.UseVisualStyleBackColor = false;
          
            btnProcessPayment.BackColor = Color.FromArgb(25, 45, 75);
            btnProcessPayment.FlatStyle = FlatStyle.Flat;
            btnProcessPayment.ForeColor = Color.White;
            btnProcessPayment.Location = new Point(184, 520);
            btnProcessPayment.Name = "btnProcessPayment";
            btnProcessPayment.Size = new Size(166, 39);
            btnProcessPayment.TabIndex = 4;
            btnProcessPayment.Text = "Process Payment";
            btnProcessPayment.UseVisualStyleBackColor = false;
           
            btnRegisterExit.BackColor = Color.FromArgb(25, 45, 75);
            btnRegisterExit.FlatStyle = FlatStyle.Flat;
            btnRegisterExit.ForeColor = Color.White;
            btnRegisterExit.Location = new Point(376, 520);
            btnRegisterExit.Name = "btnRegisterExit";
            btnRegisterExit.Size = new Size(149, 39);
            btnRegisterExit.TabIndex = 5;
            btnRegisterExit.Text = "Register Exit";
            btnRegisterExit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(25, 45, 75);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.Window;
            btnClear.Location = new Point(544, 520);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(149, 39);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
          
            btnDashboard.BackColor = Color.FromArgb(25, 45, 75);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = SystemColors.Window;
            btnDashboard.Location = new Point(721, 520);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(149, 39);
            btnDashboard.TabIndex = 7;
            btnDashboard.Text = "Back to Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
         
           
            dgvPaymentHistory.AllowUserToAddRows = false;
            dgvPaymentHistory.AllowUserToDeleteRows = false;
            dgvPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaymentHistory.BackgroundColor = Color.White;
            dgvPaymentHistory.BorderStyle = BorderStyle.None;
            dgvPaymentHistory.Location = new Point(26, 605);
            dgvPaymentHistory.Name = "dgvPaymentHistory";
            dgvPaymentHistory.ReadOnly = true;
            dgvPaymentHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaymentHistory.Size = new Size(901, 190);
            dgvPaymentHistory.TabIndex = 9;
           
            lblPaymentHistory.AutoSize = true;
            lblPaymentHistory.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPaymentHistory.ForeColor = Color.FromArgb(25, 45, 75);
            lblPaymentHistory.Location = new Point(26, 572);
            lblPaymentHistory.Name = "lblPaymentHistory";
            lblPaymentHistory.Size = new Size(161, 25);
            lblPaymentHistory.TabIndex = 8;
            lblPaymentHistory.Text = "Payment History";
           
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1034, 620);
            Controls.Add(lblTitle);
            Controls.Add(grpVehicleInformation);
            Controls.Add(grpPaymentInformation);
            Controls.Add(btnCalculateFee);
            Controls.Add(btnProcessPayment);
            Controls.Add(btnRegisterExit);
            Controls.Add(btnClear);
            Controls.Add(btnDashboard);
            Controls.Add(lblPaymentHistory);
            Controls.Add(dgvPaymentHistory);
            MinimumSize = new Size(790, 659);
            Name = "ExitPaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exit and Payment";
            grpVehicleInformation.ResumeLayout(false);
            grpVehicleInformation.PerformLayout();
            grpPaymentInformation.ResumeLayout(false);
            grpPaymentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
