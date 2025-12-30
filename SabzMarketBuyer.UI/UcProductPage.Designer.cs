namespace SabzMarketBuyer.UI
{
    partial class UcProductPage
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
            btnAddToCart = new Button();
            lblNumber = new Label();
            lblNumberTitle = new Label();
            lblDescription = new Label();
            lblName = new Label();
            pbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FloralWhite;
            btnAddToCart.Font = new Font("Segoe UI", 10F);
            btnAddToCart.Location = new Point(3, 138);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(115, 105);
            btnAddToCart.TabIndex = 12;
            btnAddToCart.Text = "افزودن به سبد خرید";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 12F);
            lblNumber.Location = new Point(262, 243);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(23, 28);
            lblNumber.TabIndex = 11;
            lblNumber.Text = "0";
            // 
            // lblNumberTitle
            // 
            lblNumberTitle.AutoSize = true;
            lblNumberTitle.Font = new Font("Segoe UI", 11F);
            lblNumberTitle.Location = new Point(141, 244);
            lblNumberTitle.Name = "lblNumberTitle";
            lblNumberTitle.Size = new Size(100, 25);
            lblNumberTitle.TabIndex = 10;
            lblNumberTitle.Text = "عدد موجود";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 11F);
            lblDescription.Location = new Point(141, 55);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(454, 177);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "توضیحات";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(141, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(34, 25);
            lblName.TabIndex = 8;
            lblName.Text = "نام";
            // 
            // pbImage
            // 
            pbImage.Image = Properties.Resources.defultprodect;
            pbImage.Location = new Point(3, 9);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(115, 108);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 7;
            pbImage.TabStop = false;
            pbImage.LoadCompleted += pbImage_LoadCompleted;
            // 
            // UcProductPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(btnAddToCart);
            Controls.Add(lblNumber);
            Controls.Add(lblNumberTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(pbImage);
            Name = "UcProductPage";
            Size = new Size(598, 281);
            Load += UcProductPage_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddToCart;
        private Label lblNumber;
        private Label lblNumberTitle;
        private Label lblDescription;
        private Label lblName;
        private PictureBox pbImage;
    }
}
