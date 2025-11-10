namespace SabzMarkett
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.btn_Setting = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pln_Menu1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pb_Profile = new System.Windows.Forms.PictureBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Settings = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pln_Menu2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_Orders = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Chat = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_AddProduct = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flp_ShowProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Menu = new Guna.UI2.WinForms.Guna2Button();
            this.pln_Menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Profile)).BeginInit();
            this.pln_Menu2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Setting
            // 
            this.btn_Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Setting.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_Setting.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_Setting.Image")));
            this.btn_Setting.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Setting.ImageRotate = 0F;
            this.btn_Setting.Location = new System.Drawing.Point(2, 520);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btn_Setting.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Setting.Size = new System.Drawing.Size(77, 76);
            this.btn_Setting.TabIndex = 0;
            this.btn_Setting.UseTransparentBackground = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // pln_Menu1
            // 
            this.pln_Menu1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pln_Menu1.Controls.Add(this.pb_Profile);
            this.pln_Menu1.Controls.Add(this.lbl_UserName);
            this.pln_Menu1.Controls.Add(this.lbl_Settings);
            this.pln_Menu1.Controls.Add(this.lbl_Name);
            this.pln_Menu1.Controls.Add(this.btn_Setting);
            this.pln_Menu1.FillColor = System.Drawing.Color.MintCream;
            this.pln_Menu1.FillColor2 = System.Drawing.Color.MediumSeaGreen;
            this.pln_Menu1.FillColor3 = System.Drawing.Color.PaleTurquoise;
            this.pln_Menu1.FillColor4 = System.Drawing.Color.LightCyan;
            this.pln_Menu1.Location = new System.Drawing.Point(12, 12);
            this.pln_Menu1.Name = "pln_Menu1";
            this.pln_Menu1.Size = new System.Drawing.Size(263, 610);
            this.pln_Menu1.TabIndex = 1;
            // 
            // pb_Profile
            // 
            this.pb_Profile.Image = global::SabzMarkett.Properties.Resources.profile;
            this.pb_Profile.Location = new System.Drawing.Point(8, 13);
            this.pb_Profile.Name = "pb_Profile";
            this.pb_Profile.Size = new System.Drawing.Size(84, 75);
            this.pb_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Profile.TabIndex = 5;
            this.pb_Profile.TabStop = false;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(105, 76);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(154, 38);
            this.lbl_UserName.TabIndex = 4;
            this.lbl_UserName.Text = "...........";
            // 
            // lbl_Settings
            // 
            this.lbl_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Settings.AutoSize = true;
            this.lbl_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings.Location = new System.Drawing.Point(105, 541);
            this.lbl_Settings.Name = "lbl_Settings";
            this.lbl_Settings.Size = new System.Drawing.Size(100, 29);
            this.lbl_Settings.TabIndex = 3;
            this.lbl_Settings.Text = "Settings";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(106, 19);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(154, 38);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "...........";
            // 
            // pln_Menu2
            // 
            this.pln_Menu2.BackColor = System.Drawing.Color.Transparent;
            this.pln_Menu2.Controls.Add(this.pln_Menu1);
            this.pln_Menu2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pln_Menu2.FillColor = System.Drawing.Color.White;
            this.pln_Menu2.Location = new System.Drawing.Point(0, 0);
            this.pln_Menu2.Name = "pln_Menu2";
            this.pln_Menu2.ShadowColor = System.Drawing.Color.Black;
            this.pln_Menu2.Size = new System.Drawing.Size(286, 634);
            this.pln_Menu2.TabIndex = 4;
            this.pln_Menu2.Visible = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_Orders);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_Chat);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_AddProduct);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Honeydew;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Beige;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.LightGreen;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(908, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(109, 634);
            this.guna2CustomGradientPanel1.TabIndex = 7;
            // 
            // btn_Orders
            // 
            this.btn_Orders.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Orders.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Orders.Image = ((System.Drawing.Image)(resources.GetObject("btn_Orders.Image")));
            this.btn_Orders.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Orders.ImageRotate = 0F;
            this.btn_Orders.Location = new System.Drawing.Point(14, 88);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btn_Orders.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Orders.Size = new System.Drawing.Size(83, 75);
            this.btn_Orders.TabIndex = 10;
            this.btn_Orders.Click += new System.EventHandler(this.btn_Orders_Click);
            // 
            // btn_Chat
            // 
            this.btn_Chat.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Chat.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btn_Chat.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Chat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Chat.Image")));
            this.btn_Chat.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Chat.ImageRotate = 0F;
            this.btn_Chat.Location = new System.Drawing.Point(14, 12);
            this.btn_Chat.Name = "btn_Chat";
            this.btn_Chat.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btn_Chat.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Chat.Size = new System.Drawing.Size(83, 70);
            this.btn_Chat.TabIndex = 9;
            this.btn_Chat.Click += new System.EventHandler(this.btn_Chat_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddProduct.BackColor = System.Drawing.Color.Honeydew;
            this.btn_AddProduct.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_AddProduct.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btn_AddProduct.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_AddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddProduct.Image")));
            this.btn_AddProduct.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_AddProduct.ImageRotate = 0F;
            this.btn_AddProduct.Location = new System.Drawing.Point(14, 543);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btn_AddProduct.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_AddProduct.Size = new System.Drawing.Size(83, 79);
            this.btn_AddProduct.TabIndex = 8;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // flp_ShowProduct
            // 
            this.flp_ShowProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_ShowProduct.BackColor = System.Drawing.Color.MintCream;
            this.flp_ShowProduct.Location = new System.Drawing.Point(286, 0);
            this.flp_ShowProduct.Name = "flp_ShowProduct";
            this.flp_ShowProduct.Size = new System.Drawing.Size(622, 634);
            this.flp_ShowProduct.TabIndex = 8;
            // 
            // btn_Menu
            // 
            this.btn_Menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.Location = new System.Drawing.Point(-2, 0);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(41, 29);
            this.btn_Menu.TabIndex = 5;
            this.btn_Menu.Text = "☰";
            this.btn_Menu.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1017, 634);
            this.Controls.Add(this.flp_ShowProduct);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.pln_Menu2);
            this.Controls.Add(this.btn_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1035, 681);
            this.Name = "frm_Home";
            this.Text = "frm_Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Home_FormClosed);
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.pln_Menu1.ResumeLayout(false);
            this.pln_Menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Profile)).EndInit();
            this.pln_Menu2.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btn_Setting;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pln_Menu1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pln_Menu2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_AddProduct;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Chat;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Orders;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Settings;
        private System.Windows.Forms.FlowLayoutPanel flp_ShowProduct;
        private Guna.UI2.WinForms.Guna2Button btn_Menu;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.PictureBox pb_Profile;
    }
}