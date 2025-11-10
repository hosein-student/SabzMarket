namespace SabzMarkett
{
    partial class frm_Login
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
            this.btn_Login = new SabzMarkett.MyButton();
            this.txt_UserName = new SabzMarkett.MyTextBox();
            this.txt_Password = new SabzMarkett.MyTextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_SignUp = new SabzMarkett.MyButton();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Animated = true;
            this.btn_Login.BorderRadius = 8;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Login.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Login.Location = new System.Drawing.Point(120, 286);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.PressedColor = System.Drawing.Color.DarkGreen;
            this.btn_Login.Size = new System.Drawing.Size(150, 58);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "ورود";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.DefaultText = "";
            this.txt_UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserName.FillColor = System.Drawing.Color.PaleGreen;
            this.txt_UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_UserName.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_UserName.Location = new System.Drawing.Point(65, 113);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PlaceholderText = "";
            this.txt_UserName.SelectedText = "";
            this.txt_UserName.Size = new System.Drawing.Size(178, 44);
            this.txt_UserName.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FillColor = System.Drawing.Color.PaleGreen;
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Password.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Location = new System.Drawing.Point(65, 176);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceholderText = "";
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(178, 44);
            this.txt_Password.TabIndex = 2;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(250, 113);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(75, 25);
            this.lbl_UserName.TabIndex = 3;
            this.lbl_UserName.Text = "نام کابری";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(250, 176);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(79, 25);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "رمز عبور";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Animated = true;
            this.btn_SignUp.BorderRadius = 8;
            this.btn_SignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SignUp.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.btn_SignUp.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_SignUp.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_SignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_SignUp.Location = new System.Drawing.Point(4, 4);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.PressedColor = System.Drawing.Color.DarkGreen;
            this.btn_SignUp.Size = new System.Drawing.Size(88, 39);
            this.btn_SignUp.TabIndex = 4;
            this.btn_SignUp.Text = "ثبت نام ";
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 418);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.btn_Login);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 465);
            this.MinimumSize = new System.Drawing.Size(420, 465);
            this.Name = "frm_Login";
            this.Text = "frm_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton btn_Login;
        private MyTextBox txt_UserName;
        private MyTextBox txt_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_password;
        private MyButton btn_SignUp;
    }
}