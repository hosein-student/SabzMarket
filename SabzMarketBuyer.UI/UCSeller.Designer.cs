namespace SabzMarketBuyer.UI
{
    partial class UCSeller
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbProfileImage = new PictureBox();
            lblNameTitle = new Label();
            lblAddressTitle = new Label();
            lblName = new Label();
            lblAddress = new Label();
            btnShowSellerPage = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProfileImage).BeginInit();
            SuspendLayout();
            // 
            // pbProfileImage
            // 
            pbProfileImage.Image = Properties.Resources.profile;
            pbProfileImage.Location = new Point(12, 14);
            pbProfileImage.Name = "pbProfileImage";
            pbProfileImage.Size = new Size(139, 138);
            pbProfileImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfileImage.TabIndex = 0;
            pbProfileImage.TabStop = false;
            pbProfileImage.LoadCompleted += pbProfileImage_LoadCompleted;
            // 
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.Location = new Point(545, 14);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(34, 25);
            lblNameTitle.TabIndex = 1;
            lblNameTitle.Text = "نام";
            // 
            // lblAddressTitle
            // 
            lblAddressTitle.AutoSize = true;
            lblAddressTitle.Location = new Point(524, 69);
            lblAddressTitle.Name = "lblAddressTitle";
            lblAddressTitle.Size = new Size(55, 25);
            lblAddressTitle.TabIndex = 2;
            lblAddressTitle.Text = "آدرس";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(379, 14);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 25);
            lblName.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.BackColor = Color.Honeydew;
            lblAddress.Location = new Point(170, 69);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(348, 167);
            lblAddress.TabIndex = 4;
            // 
            // btnShowSellerPage
            // 
            btnShowSellerPage.BackColor = Color.FloralWhite;
            btnShowSellerPage.Font = new Font("Segoe UI", 10F);
            btnShowSellerPage.Location = new Point(12, 158);
            btnShowSellerPage.Name = "btnShowSellerPage";
            btnShowSellerPage.Size = new Size(139, 87);
            btnShowSellerPage.TabIndex = 5;
            btnShowSellerPage.Text = "دیدن صفحه ی فروشنده";
            btnShowSellerPage.UseVisualStyleBackColor = false;
            btnShowSellerPage.Click += btnShowSellerPage_Click;
            // 
            // UCSeller
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(btnShowSellerPage);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblAddressTitle);
            Controls.Add(lblNameTitle);
            Controls.Add(pbProfileImage);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "UCSeller";
            Size = new Size(598, 248);
            Load += UCSeller_Load;
            ((System.ComponentModel.ISupportInitialize)pbProfileImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProfileImage;
        private Label lblNameTitle;
        private Label lblAddressTitle;
        private Label lblName;
        private Label lblAddress;
        private Button btnShowSellerPage;
    }
}
