namespace SabzMarket
{
    partial class UC_Products
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pb_Image = new PictureBox();
            lbl_Number = new Label();
            lbl_Price = new Label();
            btn_Delete = new MyButton();
            btn_Edit = new MyButton();
            lbl_Name = new Label();
            lbl_priceShow = new Label();
            lbl_NumberShow = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_Image).BeginInit();
            SuspendLayout();
            // 
            // pb_Image
            // 
            pb_Image.Location = new Point(9, 19);
            pb_Image.Name = "pb_Image";
            pb_Image.Size = new Size(119, 107);
            pb_Image.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Image.TabIndex = 0;
            pb_Image.TabStop = false;
            pb_Image.LoadCompleted += pb_Image_LoadCompleted;
            // 
            // lbl_Number
            // 
            lbl_Number.AutoSize = true;
            lbl_Number.Font = new Font("Segoe UI", 11F);
            lbl_Number.Location = new Point(482, 91);
            lbl_Number.Name = "lbl_Number";
            lbl_Number.Size = new Size(54, 25);
            lbl_Number.TabIndex = 6;
            lbl_Number.Text = "تعداد";
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Font = new Font("Segoe UI", 11F);
            lbl_Price.Location = new Point(277, 91);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(56, 25);
            lbl_Price.TabIndex = 7;
            lbl_Price.Text = "قیمت";
            // 
            // btn_Delete
            // 
            btn_Delete.BorderRadius = 8;
            btn_Delete.CustomizableEdges = customizableEdges1;
            btn_Delete.DisabledState.BorderColor = Color.DarkGray;
            btn_Delete.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Delete.DisabledState.FillColor = Color.LightGray;
            btn_Delete.DisabledState.ForeColor = Color.DarkGray;
            btn_Delete.FillColor = Color.SeaGreen;
            btn_Delete.Font = new Font("Segoe UI", 11F);
            btn_Delete.ForeColor = Color.Red;
            btn_Delete.HoverState.FillColor = Color.MediumSeaGreen;
            btn_Delete.Location = new Point(149, 157);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.PressedColor = Color.DarkGreen;
            btn_Delete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_Delete.Size = new Size(122, 46);
            btn_Delete.TabIndex = 8;
            btn_Delete.Text = "حذف";
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BorderRadius = 8;
            btn_Edit.CustomizableEdges = customizableEdges3;
            btn_Edit.DisabledState.BorderColor = Color.DarkGray;
            btn_Edit.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Edit.DisabledState.FillColor = Color.LightGray;
            btn_Edit.DisabledState.ForeColor = Color.DarkGray;
            btn_Edit.FillColor = Color.SeaGreen;
            btn_Edit.Font = new Font("Segoe UI", 11F);
            btn_Edit.ForeColor = Color.White;
            btn_Edit.HoverState.FillColor = Color.MediumSeaGreen;
            btn_Edit.Location = new Point(353, 157);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.PressedColor = Color.DarkGreen;
            btn_Edit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_Edit.Size = new Size(123, 46);
            btn_Edit.TabIndex = 9;
            btn_Edit.Text = "ویرایش";
            btn_Edit.Click += btn_Edit_Click;
            // 
            // lbl_Name
            // 
            lbl_Name.BackColor = Color.PaleGreen;
            lbl_Name.Font = new Font("Segoe UI", 12F);
            lbl_Name.Location = new Point(134, 19);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(342, 40);
            lbl_Name.TabIndex = 10;
            // 
            // lbl_priceShow
            // 
            lbl_priceShow.BackColor = Color.PaleGreen;
            lbl_priceShow.Font = new Font("Segoe UI", 12F);
            lbl_priceShow.Location = new Point(134, 83);
            lbl_priceShow.Name = "lbl_priceShow";
            lbl_priceShow.Size = new Size(137, 43);
            lbl_priceShow.TabIndex = 11;
            // 
            // lbl_NumberShow
            // 
            lbl_NumberShow.BackColor = Color.PaleGreen;
            lbl_NumberShow.Font = new Font("Segoe UI", 12F);
            lbl_NumberShow.Location = new Point(339, 83);
            lbl_NumberShow.Name = "lbl_NumberShow";
            lbl_NumberShow.Size = new Size(137, 43);
            lbl_NumberShow.TabIndex = 12;
            // 
            // UC_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_NumberShow);
            Controls.Add(lbl_priceShow);
            Controls.Add(lbl_Name);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Delete);
            Controls.Add(lbl_Price);
            Controls.Add(lbl_Number);
            Controls.Add(pb_Image);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Products";
            Size = new Size(545, 222);
            Load += UC_Products_Load;
            ((System.ComponentModel.ISupportInitialize)pb_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PictureBox pb_Image;
        private Label lbl_Number;
        private Label lbl_Price;
        private MyButton btn_Delete;
        private MyButton btn_Edit;
        private Label lbl_Name;
        private Label lbl_priceShow;
        private Label lbl_NumberShow;
    }
}
