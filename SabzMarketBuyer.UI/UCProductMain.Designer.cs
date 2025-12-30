namespace SabzMarketBuyer.UI
{
    partial class UCProductMain
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
            pbImage = new PictureBox();
            lblName = new Label();
            lblDescription = new Label();
            lblNumberTitle = new Label();
            lblNumber = new Label();
            btnAddToCart = new Button();
            btnShowSellerPage = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Image = Properties.Resources.defultprodect;
            pbImage.Location = new Point(3, 3);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(115, 108);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            pbImage.LoadCompleted += pbImage_LoadCompleted;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(141, 13);
            lblName.Name = "lblName";
            lblName.Size = new Size(34, 25);
            lblName.TabIndex = 1;
            lblName.Text = "نام";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 11F);
            lblDescription.Location = new Point(141, 49);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(454, 177);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "توضیحات";
            // 
            // lblNumberTitle
            // 
            lblNumberTitle.AutoSize = true;
            lblNumberTitle.Font = new Font("Segoe UI", 11F);
            lblNumberTitle.Location = new Point(141, 238);
            lblNumberTitle.Name = "lblNumberTitle";
            lblNumberTitle.Size = new Size(100, 25);
            lblNumberTitle.TabIndex = 3;
            lblNumberTitle.Text = "عدد موجود";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 12F);
            lblNumber.Location = new Point(262, 237);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(23, 28);
            lblNumber.TabIndex = 4;
            lblNumber.Text = "0";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FloralWhite;
            btnAddToCart.Font = new Font("Segoe UI", 10F);
            btnAddToCart.Location = new Point(3, 132);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(115, 59);
            btnAddToCart.TabIndex = 5;
            btnAddToCart.Text = "افزودن به سبد خرید";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnShowSellerPage
            // 
            btnShowSellerPage.BackColor = Color.FloralWhite;
            btnShowSellerPage.Font = new Font("Segoe UI", 9F);
            btnShowSellerPage.Location = new Point(3, 197);
            btnShowSellerPage.Name = "btnShowSellerPage";
            btnShowSellerPage.Size = new Size(115, 66);
            btnShowSellerPage.TabIndex = 6;
            btnShowSellerPage.Text = "دیدن صفحه ی فروشنده";
            btnShowSellerPage.UseVisualStyleBackColor = false;
            btnShowSellerPage.Click += btnShowSellerPage_Click;
            // 
            // UCProductMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(btnShowSellerPage);
            Controls.Add(btnAddToCart);
            Controls.Add(lblNumber);
            Controls.Add(lblNumberTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(pbImage);
            Name = "UCProductMain";
            Size = new Size(598, 281);
            Load += UCProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Label lblName;
        private Label lblDescription;
        private Label lblNumberTitle;
        private Label lblNumber;
        private Button btnAddToCart;
        private Button btnShowSellerPage;
    }
}
