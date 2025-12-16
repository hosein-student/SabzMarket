namespace SabzMarket
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SellerProfile));
            txt_Address = new MyTextBox();
            cmb_WorkHistory = new Guna.UI2.WinForms.Guna2ComboBox();
            btn_Save = new MyButton();
            lbl_Address = new Label();
            lbl_WorkHistory = new Label();
            pb_Profile = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_Profile).BeginInit();
            SuspendLayout();
            // 
            // txt_Address
            // 
            txt_Address.Cursor = Cursors.IBeam;
            txt_Address.CustomizableEdges = customizableEdges1;
            txt_Address.DefaultText = "";
            txt_Address.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Address.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Address.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Address.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Address.FillColor = Color.PaleGreen;
            txt_Address.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Address.Font = new Font("Segoe UI", 11F);
            txt_Address.ForeColor = Color.DarkGreen;
            txt_Address.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Address.Location = new Point(13, 195);
            txt_Address.Margin = new Padding(4, 6, 4, 6);
            txt_Address.Name = "txt_Address";
            txt_Address.PlaceholderText = "";
            txt_Address.SelectedText = "";
            txt_Address.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_Address.Size = new Size(276, 40);
            txt_Address.TabIndex = 0;
            // 
            // cmb_WorkHistory
            // 
            cmb_WorkHistory.BackColor = Color.Transparent;
            cmb_WorkHistory.CustomizableEdges = customizableEdges3;
            cmb_WorkHistory.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_WorkHistory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_WorkHistory.FillColor = Color.PaleGreen;
            cmb_WorkHistory.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_WorkHistory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_WorkHistory.Font = new Font("Segoe UI", 10F);
            cmb_WorkHistory.ForeColor = Color.FromArgb(68, 88, 112);
            cmb_WorkHistory.ItemHeight = 30;
            cmb_WorkHistory.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cmb_WorkHistory.Location = new Point(13, 278);
            cmb_WorkHistory.Margin = new Padding(3, 4, 3, 4);
            cmb_WorkHistory.Name = "cmb_WorkHistory";
            cmb_WorkHistory.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmb_WorkHistory.Size = new Size(276, 36);
            cmb_WorkHistory.TabIndex = 1;
            // 
            // btn_Save
            // 
            btn_Save.BorderRadius = 8;
            btn_Save.CustomizableEdges = customizableEdges5;
            btn_Save.DisabledState.BorderColor = Color.DarkGray;
            btn_Save.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Save.DisabledState.FillColor = Color.LightGray;
            btn_Save.DisabledState.ForeColor = Color.DarkGray;
            btn_Save.FillColor = Color.SeaGreen;
            btn_Save.Font = new Font("Segoe UI", 11F);
            btn_Save.ForeColor = Color.White;
            btn_Save.HoverState.FillColor = Color.MediumSeaGreen;
            btn_Save.Location = new Point(120, 466);
            btn_Save.Margin = new Padding(3, 4, 3, 4);
            btn_Save.Name = "btn_Save";
            btn_Save.PressedColor = Color.DarkGreen;
            btn_Save.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_Save.Size = new Size(168, 85);
            btn_Save.TabIndex = 2;
            btn_Save.Text = "ذخیره";
            btn_Save.Click += btn_registration_Click;
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Address.Location = new Point(296, 195);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(50, 25);
            lbl_Address.TabIndex = 4;
            lbl_Address.Text = "آدرس";
            // 
            // lbl_WorkHistory
            // 
            lbl_WorkHistory.AutoSize = true;
            lbl_WorkHistory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_WorkHistory.Location = new Point(295, 278);
            lbl_WorkHistory.Name = "lbl_WorkHistory";
            lbl_WorkHistory.Size = new Size(87, 25);
            lbl_WorkHistory.TabIndex = 5;
            lbl_WorkHistory.Text = "سابقه کاری";
            // 
            // pb_Profile
            // 
            pb_Profile.Image = (Image)resources.GetObject("pb_Profile.Image");
            pb_Profile.Location = new Point(137, 31);
            pb_Profile.Margin = new Padding(3, 4, 3, 4);
            pb_Profile.Name = "pb_Profile";
            pb_Profile.Size = new Size(95, 112);
            pb_Profile.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Profile.TabIndex = 6;
            pb_Profile.TabStop = false;
            pb_Profile.Click += phb_Profile_Click;
            pb_Profile.MouseHover += phb_Profile_MouseHover;
            // 
            // frm_SellerProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 634);
            Controls.Add(pb_Profile);
            Controls.Add(lbl_WorkHistory);
            Controls.Add(lbl_Address);
            Controls.Add(btn_Save);
            Controls.Add(cmb_WorkHistory);
            Controls.Add(txt_Address);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(412, 681);
            MinimumSize = new Size(412, 47);
            Name = "frm_SellerProfile";
            Text = "احراز هویت";
            Load += Frm_SellerProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pb_Profile).EndInit();
            ResumeLayout(false);
            PerformLayout();

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