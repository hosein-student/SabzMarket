namespace SabzMarket
{
    partial class frm_BuyerDetails
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pb_ProfileBuyer = new PictureBox();
            lbl_Address = new Label();
            txt_address = new MyTextBox();
            lbl_Phone = new Label();
            txt_Phone = new MyTextBox();
            txt_CodePosti = new MyTextBox();
            lbl_CodePosti = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_ProfileBuyer).BeginInit();
            SuspendLayout();
            // 
            // pb_ProfileBuyer
            // 
            pb_ProfileBuyer.Location = new Point(210, 12);
            pb_ProfileBuyer.Name = "pb_ProfileBuyer";
            pb_ProfileBuyer.Size = new Size(134, 138);
            pb_ProfileBuyer.SizeMode = PictureBoxSizeMode.Zoom;
            pb_ProfileBuyer.TabIndex = 0;
            pb_ProfileBuyer.TabStop = false;
            pb_ProfileBuyer.LoadCompleted += pictureBox1_LoadCompleted;
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new Font("Segoe UI", 12F);
            lbl_Address.Location = new Point(470, 183);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(60, 28);
            lbl_Address.TabIndex = 1;
            lbl_Address.Text = ":آدرس";
            // 
            // txt_address
            // 
            txt_address.AutoSize = true;
            txt_address.CustomizableEdges = customizableEdges7;
            txt_address.DefaultText = "";
            txt_address.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_address.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_address.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_address.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_address.FillColor = Color.PaleGreen;
            txt_address.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_address.Font = new Font("Segoe UI", 11F);
            txt_address.ForeColor = Color.DarkGreen;
            txt_address.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_address.Location = new Point(12, 183);
            txt_address.Margin = new Padding(3, 4, 3, 4);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.PlaceholderText = "";
            txt_address.ReadOnly = true;
            txt_address.SelectedText = "";
            txt_address.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txt_address.Size = new Size(442, 154);
            txt_address.TabIndex = 2;
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Font = new Font("Segoe UI", 12F);
            lbl_Phone.Location = new Point(470, 354);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(53, 28);
            lbl_Phone.TabIndex = 3;
            lbl_Phone.Text = ":تلفن";
            // 
            // txt_Phone
            // 
            txt_Phone.CustomizableEdges = customizableEdges9;
            txt_Phone.DefaultText = "";
            txt_Phone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Phone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Phone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Phone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Phone.FillColor = Color.PaleGreen;
            txt_Phone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Phone.Font = new Font("Segoe UI", 11F);
            txt_Phone.ForeColor = Color.DarkGreen;
            txt_Phone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Phone.Location = new Point(12, 354);
            txt_Phone.Margin = new Padding(3, 4, 3, 4);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.PlaceholderText = "";
            txt_Phone.ReadOnly = true;
            txt_Phone.SelectedText = "";
            txt_Phone.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txt_Phone.Size = new Size(263, 41);
            txt_Phone.TabIndex = 4;
            // 
            // txt_CodePosti
            // 
            txt_CodePosti.CustomizableEdges = customizableEdges11;
            txt_CodePosti.DefaultText = "";
            txt_CodePosti.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_CodePosti.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_CodePosti.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_CodePosti.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_CodePosti.FillColor = Color.PaleGreen;
            txt_CodePosti.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_CodePosti.Font = new Font("Segoe UI", 11F);
            txt_CodePosti.ForeColor = Color.DarkGreen;
            txt_CodePosti.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_CodePosti.Location = new Point(13, 415);
            txt_CodePosti.Margin = new Padding(3, 4, 3, 4);
            txt_CodePosti.Name = "txt_CodePosti";
            txt_CodePosti.PlaceholderText = "";
            txt_CodePosti.ReadOnly = true;
            txt_CodePosti.SelectedText = "";
            txt_CodePosti.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txt_CodePosti.Size = new Size(262, 47);
            txt_CodePosti.TabIndex = 5;
            // 
            // lbl_CodePosti
            // 
            lbl_CodePosti.AutoSize = true;
            lbl_CodePosti.Font = new Font("Segoe UI", 12F);
            lbl_CodePosti.Location = new Point(441, 415);
            lbl_CodePosti.Name = "lbl_CodePosti";
            lbl_CodePosti.Size = new Size(89, 28);
            lbl_CodePosti.TabIndex = 6;
            lbl_CodePosti.Text = ":کد پستی";
            // 
            // frm_BuyerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 475);
            Controls.Add(lbl_CodePosti);
            Controls.Add(txt_CodePosti);
            Controls.Add(txt_Phone);
            Controls.Add(lbl_Phone);
            Controls.Add(txt_address);
            Controls.Add(lbl_Address);
            Controls.Add(pb_ProfileBuyer);
            Name = "frm_BuyerDetails";
            Text = "frm_BuyerDetails";
            Load += frm_BuyerDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pb_ProfileBuyer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_ProfileBuyer;
        private Label lbl_Address;
        private MyTextBox txt_address;
        private Label lbl_Phone;
        private MyTextBox txt_Phone;
        private MyTextBox txt_CodePosti;
        private Label lbl_CodePosti;
    }
}