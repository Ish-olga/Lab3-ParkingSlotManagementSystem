namespace ParkingSlotManagementSystem.View
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlLogin = new Panel();
            lblRegister = new Label();
            btnRegister = new Button();
            btnExit = new Button();
            lblSubtitle = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            Welcome = new Label();
            pnlBrand = new Panel();
            lblTitle2 = new Label();
            lblTitle1 = new Label();
            picParking = new PictureBox();
            pnlLogin.SuspendLayout();
            pnlBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picParking).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = SystemColors.ButtonHighlight;
            pnlLogin.Controls.Add(lblRegister);
            pnlLogin.Controls.Add(btnRegister);
            pnlLogin.Controls.Add(btnExit);
            pnlLogin.Controls.Add(lblSubtitle);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Controls.Add(Welcome);
            pnlLogin.Font = new Font("Segoe UI", 11F);
            pnlLogin.Location = new Point(317, 0);
            pnlLogin.Margin = new Padding(2);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(481, 494);
            pnlLogin.TabIndex = 0;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Location = new Point(82, 350);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(268, 20);
            lblRegister.TabIndex = 9;
            lblRegister.Text = "Don't have an account? Create Account";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(25, 43, 68);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(91, 392);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(230, 45);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "CREATE ACCOUNT";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += this.btnRegister_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(25, 43, 68);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(239, 282);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(191, 45);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(0, 7, 119, 119);
            lblSubtitle.Location = new Point(91, 83);
            lblSubtitle.Margin = new Padding(2, 0, 2, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(259, 19);
            lblSubtitle.TabIndex = 6;
            lblSubtitle.Text = "Enter your email and password to sign in";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(25, 43, 68);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(25, 282);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(177, 203);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(265, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(25, 43, 68);
            lblPassword.Location = new Point(54, 208);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 19);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(177, 138);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(265, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(25, 43, 68);
            lblUsername.Location = new Point(54, 143);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 19);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Welcome.ForeColor = Color.FromArgb(25, 43, 68);
            Welcome.Location = new Point(119, 29);
            Welcome.Margin = new Padding(2, 0, 2, 0);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(221, 41);
            Welcome.TabIndex = 0;
            Welcome.Text = "Welcome Back";
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(25, 43, 68);
            pnlBrand.Controls.Add(lblTitle2);
            pnlBrand.Controls.Add(lblTitle1);
            pnlBrand.Controls.Add(picParking);
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Margin = new Padding(2);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(331, 483);
            pnlBrand.TabIndex = 1;
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle2.ForeColor = Color.White;
            lblTitle2.Location = new Point(20, 361);
            lblTitle2.Margin = new Padding(2, 0, 2, 0);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(252, 32);
            lblTitle2.TabIndex = 2;
            lblTitle2.Text = "Management System";
            lblTitle2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle1
            // 
            lblTitle1.AutoSize = true;
            lblTitle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle1.ForeColor = Color.White;
            lblTitle1.Location = new Point(76, 329);
            lblTitle1.Margin = new Padding(2, 0, 2, 0);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Size = new Size(152, 32);
            lblTitle1.TabIndex = 1;
            lblTitle1.Text = "Parking Slot";
            lblTitle1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picParking
            // 
            picParking.BackColor = Color.FromArgb(25, 43, 68);
            picParking.Image = (Image)resources.GetObject("picParking.Image");
            picParking.Location = new Point(-20, 0);
            picParking.Margin = new Padding(2);
            picParking.Name = "picParking";
            picParking.Size = new Size(358, 327);
            picParking.SizeMode = PictureBoxSizeMode.Zoom;
            picParking.TabIndex = 0;
            picParking.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 483);
            Controls.Add(pnlBrand);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parking Slot Management System";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picParking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Panel pnlBrand;
        private Label Welcome;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblSubtitle;
        private PictureBox picParking;
        private Label lblTitle1;
        private Label lblTitle2;
        private Button btnExit;
        private Button btnRegister;
        private Label lblRegister;
    }
}