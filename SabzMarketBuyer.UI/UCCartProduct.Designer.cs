namespace SabzMarketBuyer.UI
{
    partial class UCCartProduct
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
            lblPrice = new Label();
            lblName = new Label();
            lblNumber = new Label();
            lblTitleNumber = new Label();
            btnDecrease = new Button();
            btnDeleteCart = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Image = Properties.Resources.defultprodect;
            pbImage.Location = new Point(9, 18);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(109, 102);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            pbImage.LoadCompleted += pbImage_LoadCompleted;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.Location = new Point(226, 59);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(51, 23);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "قیمت";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(226, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(30, 23);
            lblName.TabIndex = 2;
            lblName.Text = "نام";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 10F);
            lblNumber.Location = new Point(226, 97);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(48, 23);
            lblNumber.TabIndex = 3;
            lblNumber.Text = "تعداد";
            // 
            // lblTitleNumber
            // 
            lblTitleNumber.AutoSize = true;
            lblTitleNumber.Font = new Font("Segoe UI", 10F);
            lblTitleNumber.Location = new Point(155, 97);
            lblTitleNumber.Name = "lblTitleNumber";
            lblTitleNumber.Size = new Size(38, 23);
            lblTitleNumber.TabIndex = 4;
            lblTitleNumber.Text = "عدد";
            // 
            // btnDecrease
            // 
            btnDecrease.BackColor = SystemColors.Control;
            btnDecrease.ForeColor = Color.Red;
            btnDecrease.Location = new Point(21, 136);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(130, 39);
            btnDecrease.TabIndex = 7;
            btnDecrease.Text = "حذف یکی";
            btnDecrease.UseVisualStyleBackColor = false;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnDeleteCart
            // 
            btnDeleteCart.BackColor = SystemColors.Control;
            btnDeleteCart.ForeColor = Color.Red;
            btnDeleteCart.Location = new Point(172, 136);
            btnDeleteCart.Name = "btnDeleteCart";
            btnDeleteCart.Size = new Size(130, 39);
            btnDeleteCart.TabIndex = 8;
            btnDeleteCart.Text = "حذف از سبد خرید";
            btnDeleteCart.UseVisualStyleBackColor = false;
            btnDeleteCart.Click += btnDeleteCart_Click;
            // 
            // UCCartProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(btnDeleteCart);
            Controls.Add(btnDecrease);
            Controls.Add(lblTitleNumber);
            Controls.Add(lblNumber);
            Controls.Add(lblName);
            Controls.Add(lblPrice);
            Controls.Add(pbImage);
            Name = "UCCartProduct";
            Size = new Size(491, 189);
            Load += UCCartProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Label lblPrice;
        private Label lblName;
        private Label lblNumber;
        private Label lblTitleNumber;
        private Button btnDecrease;
        private Button btnDeleteCart;
    }
}
