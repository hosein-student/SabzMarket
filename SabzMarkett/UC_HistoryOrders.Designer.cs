namespace SabzMarkett
{
    partial class UC_HistoryOrders
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
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Details = new SabzMarkett.MyButton();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_Status.Location = new System.Drawing.Point(381, 166);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(91, 25);
            this.lbl_Status.TabIndex = 1;
            this.lbl_Status.Text = "ارسال  نشده";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.Location = new System.Drawing.Point(427, 114);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(43, 25);
            this.lbl_Number.TabIndex = 2;
            this.lbl_Number.Text = "تعداد";
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(379, 62);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(93, 25);
            this.lbl_Product.TabIndex = 3;
            this.lbl_Product.Text = "اسم محصول";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(441, 18);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(29, 25);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "نام";
            // 
            // btn_Details
            // 
            this.btn_Details.BorderRadius = 8;
            this.btn_Details.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Details.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Details.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.btn_Details.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Details.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_Details.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Details.ForeColor = System.Drawing.Color.White;
            this.btn_Details.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Details.Location = new System.Drawing.Point(12, 9);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.PressedColor = System.Drawing.Color.DarkGreen;
            this.btn_Details.Size = new System.Drawing.Size(161, 42);
            this.btn_Details.TabIndex = 5;
            this.btn_Details.Text = "جزئیات خریدار ";
            // 
            // pb_Image
            // 
            this.pb_Image.Location = new System.Drawing.Point(31, 62);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(123, 108);
            this.pb_Image.TabIndex = 6;
            this.pb_Image.TabStop = false;
            // 
            // UC_HistoryOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.btn_Details);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.lbl_Name);
            this.Name = "UC_HistoryOrders";
            this.Size = new System.Drawing.Size(502, 209);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Label lbl_Name;
        private MyButton btn_Details;
        private System.Windows.Forms.PictureBox pb_Image;
    }
}
