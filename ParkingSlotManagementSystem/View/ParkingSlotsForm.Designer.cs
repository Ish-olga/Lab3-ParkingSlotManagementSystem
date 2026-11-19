
using System.Drawing;
using System.Windows.Forms;

namespace ParkingSlotManagementSystem.View
{
    partial class ParkingSlotsForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grpSlotInformation = new GroupBox();
            txtLocation = new TextBox();
            cmbStatus = new ComboBox();
            cmbVehicleType = new ComboBox();
            cmbSlotType = new ComboBox();
            textBox1 = new TextBox();
            label5 = new Label();
            lblStatus = new Label();
            lblVehicleType = new Label();
            lblSlotType = new Label();
            lblSlotNumber = new Label();
            pnlHeader = new Panel();
            label6 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvParkingSlots = new DataGridView();
            btnBackDashboard = new Button();
            grpSlotInformation.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParkingSlots).BeginInit();
            SuspendLayout();
            // 
            // grpSlotInformation
            // 
            grpSlotInformation.Controls.Add(txtLocation);
            grpSlotInformation.Controls.Add(cmbStatus);
            grpSlotInformation.Controls.Add(cmbVehicleType);
            grpSlotInformation.Controls.Add(cmbSlotType);
            grpSlotInformation.Controls.Add(textBox1);
            grpSlotInformation.Controls.Add(label5);
            grpSlotInformation.Controls.Add(lblStatus);
            grpSlotInformation.Controls.Add(lblVehicleType);
            grpSlotInformation.Controls.Add(lblSlotType);
            grpSlotInformation.Controls.Add(lblSlotNumber);
            grpSlotInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpSlotInformation.ForeColor = Color.FromArgb(25, 43, 68);
            grpSlotInformation.Location = new Point(3, 92);
            grpSlotInformation.Name = "grpSlotInformation";
            grpSlotInformation.Size = new Size(790, 162);
            grpSlotInformation.TabIndex = 0;
            grpSlotInformation.TabStop = false;
            grpSlotInformation.Text = "Slot Information";
             
           
            txtLocation.Font = new Font("Segoe UI", 9F);
            txtLocation.Location = new Point(471, 76);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(221, 23);
            txtLocation.TabIndex = 9;
          
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Parked" });
            cmbStatus.Location = new Point(471, 36);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(221, 23);
            cmbStatus.TabIndex = 8;
           
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.Font = new Font("Segoe UI", 9F);
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Items.AddRange(new object[] { "Car", "Motorcycle", "Truck", "Van", "Bus" });
            cmbVehicleType.Location = new Point(109, 118);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(198, 23);
            cmbVehicleType.TabIndex = 7;
            
            cmbSlotType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSlotType.Font = new Font("Segoe UI", 9F);
            cmbSlotType.FormattingEnabled = true;
            cmbSlotType.Items.AddRange(new object[] { "Standard", "VIP", "Disabled", "Reserved" });
            cmbSlotType.Location = new Point(109, 79);
            cmbSlotType.Name = "cmbSlotType";
            cmbSlotType.Size = new Size(198, 23);
            cmbSlotType.TabIndex = 6;
           
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(109, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 5;
           
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(372, 79);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Location:";
           
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.Location = new Point(372, 39);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status:";
            
            lblVehicleType.AutoSize = true;
            lblVehicleType.Font = new Font("Segoe UI", 9F);
            lblVehicleType.Location = new Point(6, 118);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(75, 15);
            lblVehicleType.TabIndex = 2;
            lblVehicleType.Text = "Vehicle Type:";
            
            lblSlotType.AutoSize = true;
            lblSlotType.Font = new Font("Segoe UI", 9F);
            lblSlotType.Location = new Point(9, 79);
            lblSlotType.Name = "lblSlotType";
            lblSlotType.Size = new Size(58, 15);
            lblSlotType.TabIndex = 1;
            lblSlotType.Text = "Slot Type:";
           
            lblSlotNumber.AutoSize = true;
            lblSlotNumber.Font = new Font("Segoe UI", 9F);
            lblSlotNumber.Location = new Point(9, 39);
            lblSlotNumber.Name = "lblSlotNumber";
            lblSlotNumber.Size = new Size(77, 15);
            lblSlotNumber.TabIndex = 0;
            lblSlotNumber.Text = "Slot Number:";
           
            pnlHeader.BackColor = Color.FromArgb(25, 43, 68);
            pnlHeader.Controls.Add(label6);
            pnlHeader.Location = new Point(3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(790, 91);
            pnlHeader.TabIndex = 1;
            
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 22);
            label6.Name = "label6";
            label6.Size = new Size(343, 30);
            label6.TabIndex = 0;
            label6.Text = "PARKING SLOTS MANAGEMENT";
            
            btnAdd.BackColor = Color.FromArgb(107, 114, 128);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(14, 272);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD SLOT";
            btnAdd.UseVisualStyleBackColor = false;
            
            btnUpdate.BackColor = Color.FromArgb(107, 114, 128);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(153, 272);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 38);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
           
            btnDelete.BackColor = Color.FromArgb(107, 114, 128);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(306, 272);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 38);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            
            btnClear.BackColor = Color.FromArgb(107, 114, 128);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(448, 272);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 38);
            btnClear.TabIndex = 5;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            
            dgvParkingSlots.AllowUserToAddRows = false;
            dgvParkingSlots.AllowUserToDeleteRows = false;
            dgvParkingSlots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParkingSlots.BackgroundColor = Color.White;
            dgvParkingSlots.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 43, 68);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvParkingSlots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvParkingSlots.ColumnHeadersHeight = 38;
            dgvParkingSlots.EnableHeadersVisualStyles = false;
            dgvParkingSlots.Font = new Font("Segoe UI", 9F);
            dgvParkingSlots.Location = new Point(3, 317);
            dgvParkingSlots.MultiSelect = false;
            dgvParkingSlots.Name = "dgvParkingSlots";
            dgvParkingSlots.ReadOnly = true;
            dgvParkingSlots.RowHeadersVisible = false;
            dgvParkingSlots.RowTemplate.Height = 32;
            dgvParkingSlots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParkingSlots.Size = new Size(790, 194);
            dgvParkingSlots.TabIndex = 6;
          
            btnBackDashboard.BackColor = Color.FromArgb(107, 114, 128);
            btnBackDashboard.FlatStyle = FlatStyle.Flat;
            btnBackDashboard.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnBackDashboard.ForeColor = Color.White;
            btnBackDashboard.Location = new Point(581, 272);
            btnBackDashboard.Name = "btnBackDashboard";
            btnBackDashboard.Size = new Size(123, 39);
            btnBackDashboard.TabIndex = 7;
            btnBackDashboard.Text = "Back to Dashboard";
            btnBackDashboard.UseVisualStyleBackColor = false;
            btnBackDashboard.Click += btnBackDashboard_Click;
           
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 248, 247);
            ClientSize = new Size(800, 560);
            Controls.Add(btnBackDashboard);
            Controls.Add(dgvParkingSlots);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(pnlHeader);
            Controls.Add(grpSlotInformation);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ParkingSlotsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parking Slots Management";
            grpSlotInformation.ResumeLayout(false);
            grpSlotInformation.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParkingSlots).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSlotInformation;
        private ComboBox cmbVehicleType;
        private ComboBox cmbSlotType;
        private TextBox textBox1;
        private Label label5;
        private Label lblStatus;
        private Label lblVehicleType;
        private Label lblSlotType;
        private Label lblSlotNumber;
        private Panel pnlHeader;
        private Label label6;
        private ComboBox cmbStatus;
        private TextBox txtLocation;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvParkingSlots;
        private Button btnBackDashboard;
    }
}
