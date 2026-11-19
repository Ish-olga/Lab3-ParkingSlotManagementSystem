

using System.Drawing;
using System.Windows.Forms;

namespace ParkingSlotManagementSystem.View
{
    partial class OwnerVehicleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerVehicleForm));
            pnlImage = new Panel();
            picLogo = new PictureBox();
            pnlManagement = new Panel();
            btnBackDashboard = new Button();
            btnVehicleEntry = new Button();
            btnSearch = new Button();
            dgvOwnersVehicles = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbColor = new ComboBox();
            cmbModel = new ComboBox();
            cmbBrand = new ComboBox();
            cmbVehicleType = new ComboBox();
            txtPlateNumber = new TextBox();
            lblColor = new Label();
            lblModel = new Label();
            lblBrand = new Label();
            lblVehicleType = new Label();
            lblPlateNumber = new Label();
            lblVehicleInfo = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            lblAddress = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblFullName = new Label();
            lblOwnerInfo = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOwnersVehicles).BeginInit();
            SuspendLayout();
            // 
            // pnlImage
            // 
            pnlImage.BackColor = Color.FromArgb(25, 43, 68);
            pnlImage.Controls.Add(picLogo);
            pnlImage.Location = new Point(0, 0);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(278, 488);
            pnlImage.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(278, 488);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // pnlManagement
            // 
            pnlManagement.BackColor = Color.White;
            pnlManagement.Controls.Add(btnBackDashboard);
            pnlManagement.Controls.Add(btnVehicleEntry);
            pnlManagement.Controls.Add(btnSearch);
            pnlManagement.Controls.Add(dgvOwnersVehicles);
            pnlManagement.Controls.Add(btnClear);
            pnlManagement.Controls.Add(btnDelete);
            pnlManagement.Controls.Add(btnUpdate);
            pnlManagement.Controls.Add(btnAdd);
            pnlManagement.Controls.Add(cmbColor);
            pnlManagement.Controls.Add(cmbModel);
            pnlManagement.Controls.Add(cmbBrand);
            pnlManagement.Controls.Add(cmbVehicleType);
            pnlManagement.Controls.Add(txtPlateNumber);
            pnlManagement.Controls.Add(lblColor);
            pnlManagement.Controls.Add(lblModel);
            pnlManagement.Controls.Add(lblBrand);
            pnlManagement.Controls.Add(lblVehicleType);
            pnlManagement.Controls.Add(lblPlateNumber);
            pnlManagement.Controls.Add(lblVehicleInfo);
            pnlManagement.Controls.Add(txtAddress);
            pnlManagement.Controls.Add(txtEmail);
            pnlManagement.Controls.Add(txtPhone);
            pnlManagement.Controls.Add(txtFullName);
            pnlManagement.Controls.Add(lblAddress);
            pnlManagement.Controls.Add(lblEmail);
            pnlManagement.Controls.Add(lblPhone);
            pnlManagement.Controls.Add(lblFullName);
            pnlManagement.Controls.Add(lblOwnerInfo);
            pnlManagement.Controls.Add(lblSubtitle);
            pnlManagement.Controls.Add(lblTitle);
            pnlManagement.ForeColor = Color.FromArgb(25, 43, 68);
            pnlManagement.Location = new Point(271, 0);
            pnlManagement.Name = "pnlManagement";
            pnlManagement.Size = new Size(777, 635);
            pnlManagement.TabIndex = 1;
            // 
            // btnBackDashboard
            // 
            btnBackDashboard.Location = new Point(651, 363);
            btnBackDashboard.Name = "btnBackDashboard";
            btnBackDashboard.Size = new Size(119, 23);
            btnBackDashboard.TabIndex = 34;
            btnBackDashboard.Text = "Back to Dashboard";
            btnBackDashboard.UseVisualStyleBackColor = true;
            btnBackDashboard.Click += btnBackDashboard_Click;
            // 
            // btnVehicleEntry
            // 
            btnVehicleEntry.Location = new Point(551, 363);
            btnVehicleEntry.Name = "btnVehicleEntry";
            btnVehicleEntry.Size = new Size(94, 23);
            btnVehicleEntry.TabIndex = 33;
            btnVehicleEntry.Text = "Vehicle Entry";
            btnVehicleEntry.UseVisualStyleBackColor = true;
            btnVehicleEntry.Click += btnVehicleEntry_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(453, 363);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 32;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvOwnersVehicles
            // 
            dgvOwnersVehicles.BackgroundColor = SystemColors.Window;
            dgvOwnersVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwnersVehicles.Location = new Point(11, 396);
            dgvOwnersVehicles.Name = "dgvOwnersVehicles";
            dgvOwnersVehicles.Size = new Size(763, 184);
            dgvOwnersVehicles.TabIndex = 31;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(348, 367);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 30;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(231, 367);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(123, 367);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(7, 367);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbColor
            // 
            cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black", "White", "Silver", "Gray", "Red", "Blue" });
            cmbColor.Location = new Point(370, 272);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(121, 23);
            cmbColor.TabIndex = 25;
            // 
            // cmbModel
            // 
            cmbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModel.FormattingEnabled = true;
            cmbModel.Items.AddRange(new object[] { "Corolla", "", "Camry", "", "RAV4", "", "Land Cruiser", "", "Prado", "", "Hilux", "", "Yaris", "", "Auris", "", "Fortuner", "", "Highlander", "", "X-Trail", "Patro" });
            cmbModel.Location = new Point(114, 319);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(121, 23);
            cmbModel.TabIndex = 24;
            // 
            // cmbBrand
            // 
            cmbBrand.BackColor = Color.FromArgb(241, 243, 245);
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(370, 226);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(121, 23);
            cmbBrand.TabIndex = 23;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.BackColor = Color.FromArgb(241, 243, 245);
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Location = new Point(120, 275);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(124, 23);
            cmbVehicleType.TabIndex = 22;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.BackColor = Color.FromArgb(241, 243, 245);
            txtPlateNumber.Location = new Point(123, 234);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(121, 23);
            txtPlateNumber.TabIndex = 17;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(286, 275);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 16;
            lblColor.Text = "Color";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(21, 322);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 15;
            lblModel.Text = "Model";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(293, 234);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(38, 15);
            lblBrand.TabIndex = 14;
            lblBrand.Text = "Brand";
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Location = new Point(21, 278);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(72, 15);
            lblVehicleType.TabIndex = 13;
            lblVehicleType.Text = "Vehicle Type";
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Location = new Point(18, 237);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(80, 15);
            lblPlateNumber.TabIndex = 12;
            lblPlateNumber.Text = "Plate Number";
            // 
            // lblVehicleInfo
            // 
            lblVehicleInfo.AutoSize = true;
            lblVehicleInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVehicleInfo.Location = new Point(74, 210);
            lblVehicleInfo.Name = "lblVehicleInfo";
            lblVehicleInfo.Size = new Size(190, 21);
            lblVehicleInfo.TabIndex = 11;
            lblVehicleInfo.Text = "VEHICLE INFORMATION";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(241, 243, 245);
            txtAddress.Location = new Point(370, 163);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(164, 23);
            txtAddress.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(241, 243, 245);
            txtEmail.Location = new Point(105, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(241, 243, 245);
            txtPhone.Location = new Point(370, 126);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(164, 23);
            txtPhone.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(241, 243, 245);
            txtFullName.Location = new Point(114, 129);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(175, 23);
            txtFullName.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(315, 171);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(21, 171);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(315, 129);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(21, 129);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full Name";
            // 
            // lblOwnerInfo
            // 
            lblOwnerInfo.AutoSize = true;
            lblOwnerInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOwnerInfo.Location = new Point(21, 89);
            lblOwnerInfo.Name = "lblOwnerInfo";
            lblOwnerInfo.Size = new Size(186, 21);
            lblOwnerInfo.TabIndex = 2;
            lblOwnerInfo.Text = "OWNER INFORMATION";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(102, 102, 102);
            lblSubtitle.Location = new Point(47, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(341, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Register and manage vehicle owners and their vehicles";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(6, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(440, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "OWNER & VEHICLE MANAGEMENT";
            // 
            // OwnerVehicleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 561);
            Controls.Add(pnlManagement);
            Controls.Add(pnlImage);
            Name = "OwnerVehicleForm";
            Text = "Owner & Vehicle Management";
            pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlManagement.ResumeLayout(false);
            pnlManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOwnersVehicles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlImage;
        private Panel pnlManagement;
        private PictureBox picLogo;

        private Label lblSubtitle;
        private Label lblTitle;
        private Label lblOwnerInfo;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblFullName;

        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private TextBox txtPlateNumber;

        private Label lblVehicleType;
        private Label lblPlateNumber;
        private Label lblColor;
        private Label lblModel;
        private Label lblBrand;
        private Label lblVehicleInfo;

        private ComboBox cmbVehicleType;
        private ComboBox cmbBrand;
        private ComboBox cmbModel;
        private ComboBox cmbColor;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvOwnersVehicles;
        private Button btnSearch;
        private Button btnBackDashboard;
        private Button btnVehicleEntry;
    }
}

