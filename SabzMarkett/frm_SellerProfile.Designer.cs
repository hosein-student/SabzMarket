namespace SabzMarkett
{
    partial class frm_SellerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SellerProfile));
            this.txt_Address = new SabzMarkett.MyTextBox();
            this.cmb_WorkHistory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Save = new SabzMarkett.MyButton();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_WorkHistory = new System.Windows.Forms.Label();
            this.pb_Profile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Address
            // 
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.DefaultText = "";
            this.txt_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.FillColor = System.Drawing.Color.PaleGreen;
            this.txt_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Address.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.Location = new System.Drawing.Point(98, 156);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PlaceholderText = "";
            this.txt_Address.SelectedText = "";
            this.txt_Address.Size = new System.Drawing.Size(157, 32);
            this.txt_Address.TabIndex = 0;
            // 
            // cmb_WorkHistory
            // 
            this.cmb_WorkHistory.BackColor = System.Drawing.Color.Transparent;
            this.cmb_WorkHistory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_WorkHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_WorkHistory.FillColor = System.Drawing.Color.PaleGreen;
            this.cmb_WorkHistory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_WorkHistory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_WorkHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_WorkHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_WorkHistory.ItemHeight = 30;
            this.cmb_WorkHistory.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmb_WorkHistory.Location = new System.Drawing.Point(98, 222);
            this.cmb_WorkHistory.Name = "cmb_WorkHistory";
            this.cmb_WorkHistory.Size = new System.Drawing.Size(157, 36);
            this.cmb_WorkHistory.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.BorderRadius = 8;
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Save.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Save.Location = new System.Drawing.Point(120, 373);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.PressedColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Size = new System.Drawing.Size(168, 68);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "ذخیره";
            this.btn_Save.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(262, 156);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(50, 25);
            this.lbl_Address.TabIndex = 4;
            this.lbl_Address.Text = "آدرس";
            // 
            // lbl_WorkHistory
            // 
            this.lbl_WorkHistory.AutoSize = true;
            this.lbl_WorkHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WorkHistory.Location = new System.Drawing.Point(261, 222);
            this.lbl_WorkHistory.Name = "lbl_WorkHistory";
            this.lbl_WorkHistory.Size = new System.Drawing.Size(87, 25);
            this.lbl_WorkHistory.TabIndex = 5;
            this.lbl_WorkHistory.Text = "سابقه کاری";
            // 
            // pb_Profile
            // 
            this.pb_Profile.Image = ((System.Drawing.Image)(resources.GetObject("pb_Profile.Image")));
            this.pb_Profile.Location = new System.Drawing.Point(137, 25);
            this.pb_Profile.Name = "pb_Profile";
            this.pb_Profile.Size = new System.Drawing.Size(95, 90);
            this.pb_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Profile.TabIndex = 6;
            this.pb_Profile.TabStop = false;
            this.pb_Profile.Click += new System.EventHandler(this.phb_Profile_Click);
            this.pb_Profile.MouseHover += new System.EventHandler(this.phb_Profile_MouseHover);
            // 
            // frm_SellerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 507);
            this.Controls.Add(this.pb_Profile);
            this.Controls.Add(this.lbl_WorkHistory);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_WorkHistory);
            this.Controls.Add(this.txt_Address);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 554);
            this.MinimumSize = new System.Drawing.Size(412, 47);
            this.Name = "frm_SellerProfile";
            this.Text = "SellerProfile";
            this.Load += new System.EventHandler(this.Frm_SellerProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBox txt_Address;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_WorkHistory;
        private MyButton btn_Save;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_WorkHistory;
        private System.Windows.Forms.PictureBox pb_Profile;
    }
}