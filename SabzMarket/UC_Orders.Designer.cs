namespace SabzMarket
{
    partial class UC_Orders
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_ChangeStatus = new SabzMarket.MyButton();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.btn_Details = new SabzMarket.MyButton();
            this.btn_Reject = new SabzMarket.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(570, 17);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(29, 25);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "نام";
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(506, 81);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(93, 25);
            this.lbl_Product.TabIndex = 0;
            this.lbl_Product.Text = "اسم محصول";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.Location = new System.Drawing.Point(556, 148);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(43, 25);
            this.lbl_Number.TabIndex = 0;
            this.lbl_Number.Text = "تعداد";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_Status.Location = new System.Drawing.Point(508, 200);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(91, 25);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "ارسال  نشده";
            // 
            // btn_ChangeStatus
            // 
            this.btn_ChangeStatus.BorderRadius = 8;
            this.btn_ChangeStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChangeStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChangeStatus.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.btn_ChangeStatus.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_ChangeStatus.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_ChangeStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_ChangeStatus.ForeColor = System.Drawing.Color.White;
            this.btn_ChangeStatus.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ChangeStatus.Location = new System.Drawing.Point(12, 184);
            this.btn_ChangeStatus.Name = "btn_ChangeStatus";
            this.btn_ChangeStatus.PressedColor = System.Drawing.Color.DarkGreen;
            this.btn_ChangeStatus.Size = new System.Drawing.Size(161, 41);
            this.btn_ChangeStatus.TabIndex = 1;
            this.btn_ChangeStatus.Text = "ارسال شده";
            // 
            // pb_Image
            // 
            this.pb_Image.Location = new System.Drawing.Point(29, 65);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(123, 108);
            this.pb_Image.TabIndex = 2;
            this.pb_Image.TabStop = false;
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
            this.btn_Details.Location = new System.Drawing.Point(12, 10);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.PressedColor = System.Drawing.Color.DarkGreen;
            this.btn_Details.Size = new System.Drawing.Size(161, 42);
            this.btn_Details.TabIndex = 3;
            this.btn_Details.Text = "جزئیات خریدار ";
            // 
            // btn_Reject
            // 
            this.btn_Reject.BorderRadius = 8;
            this.btn_Reject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reject.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.btn_Reject.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Reject.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_Reject.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Reject.ForeColor = System.Drawing.Color.Red;
            this.btn_Reject.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Reject.Location = new System.Drawing.Point(193, 184);
            this.btn_Reject.Name = "btn_Reject";
            this.btn_Reject.PressedColor = System.Drawing.Color.DarkGreen;
            this.btn_Reject.Size = new System.Drawing.Size(161, 41);
            this.btn_Reject.TabIndex = 4;
            this.btn_Reject.Text = "رد کردن";
            // 
            // UC_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.btn_Reject);
            this.Controls.Add(this.btn_Details);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.btn_ChangeStatus);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.lbl_Name);
            this.Name = "UC_Orders";
            this.Size = new System.Drawing.Size(641, 233);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_Status;
        private MyButton btn_ChangeStatus;
        private System.Windows.Forms.PictureBox pb_Image;
        private MyButton btn_Details;
        private MyButton btn_Reject;
    }
}
