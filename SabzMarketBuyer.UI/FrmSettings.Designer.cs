namespace SabzMarketBuyer.UI
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            txtFirstname = new TextBox();
            pbProfile = new PictureBox();
            txtLastname = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            txtCodePosti = new TextBox();
            lblFirsname = new Label();
            lblLastname = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblAddress = new Label();
            lblCodePosti = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            SuspendLayout();
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(27, 123);
            txtFirstname.Margin = new Padding(2);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(264, 34);
            txtFirstname.TabIndex = 0;
            // 
            // pbProfile
            // 
            pbProfile.Image = Properties.Resources.profile;
            pbProfile.Location = new Point(146, 11);
            pbProfile.Margin = new Padding(2);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(109, 102);
            pbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfile.TabIndex = 1;
            pbProfile.TabStop = false;
            pbProfile.Click += pbProfile_Click;
            pbProfile.MouseHover += pbProfile_MouseHover;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(27, 163);
            txtLastname.Margin = new Padding(2);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(264, 34);
            txtLastname.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(27, 204);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(264, 34);
            txtPhone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(27, 245);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 34);
            txtEmail.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(27, 286);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(264, 34);
            txtUsername.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(27, 368);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(264, 34);
            txtAddress.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(27, 327);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(264, 34);
            txtPassword.TabIndex = 5;
            // 
            // txtCodePosti
            // 
            txtCodePosti.Location = new Point(27, 409);
            txtCodePosti.Margin = new Padding(2);
            txtCodePosti.Name = "txtCodePosti";
            txtCodePosti.Size = new Size(264, 34);
            txtCodePosti.TabIndex = 7;
            // 
            // lblFirsname
            // 
            lblFirsname.AutoSize = true;
            lblFirsname.Location = new Point(295, 126);
            lblFirsname.Margin = new Padding(2, 0, 2, 0);
            lblFirsname.Name = "lblFirsname";
            lblFirsname.Size = new Size(36, 28);
            lblFirsname.TabIndex = 9;
            lblFirsname.Text = "نام";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(295, 166);
            lblLastname.Margin = new Padding(2, 0, 2, 0);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(117, 28);
            lblLastname.TabIndex = 10;
            lblLastname.Text = "نام خانوادگی";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(295, 207);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(49, 28);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "تلفن";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(295, 251);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(56, 28);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "ایمیل";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(291, 289);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(84, 28);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "نام کابری";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(295, 330);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 28);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "رمز عبور";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(306, 371);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(56, 28);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "آدرس";
            // 
            // lblCodePosti
            // 
            lblCodePosti.AutoSize = true;
            lblCodePosti.Location = new Point(295, 412);
            lblCodePosti.Margin = new Padding(2, 0, 2, 0);
            lblCodePosti.Name = "lblCodePosti";
            lblCodePosti.Size = new Size(85, 28);
            lblCodePosti.TabIndex = 16;
            lblCodePosti.Text = "کد پستی";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(148, 455);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 67);
            btnSave.TabIndex = 8;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 533);
            Controls.Add(btnSave);
            Controls.Add(lblCodePosti);
            Controls.Add(lblAddress);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblLastname);
            Controls.Add(lblFirsname);
            Controls.Add(txtCodePosti);
            Controls.Add(txtPassword);
            Controls.Add(txtAddress);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtLastname);
            Controls.Add(pbProfile);
            Controls.Add(txtFirstname);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MaximumSize = new Size(450, 580);
            MinimumSize = new Size(355, 451);
            Name = "FrmSettings";
            Text = "تنظیمات";
            Load += FrmSettings_Load;
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstname;
        private PictureBox pbProfile;
        private TextBox txtLastname;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private TextBox txtCodePosti;
        private Label lblFirsname;
        private Label lblLastname;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblAddress;
        private Label lblCodePosti;
        private Button btnSave;
    }
}