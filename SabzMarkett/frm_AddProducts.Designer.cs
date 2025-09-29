namespace SabzMarkett
{
    partial class frm_AddProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddProducts));
            this.cmb_Categorie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Add = new SabzMarkett.MyButton();
            this.txt_Name = new SabzMarkett.MyTextBox();
            this.lbl_Categorie = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Picture = new System.Windows.Forms.Label();
            this.txt_Number = new SabzMarkett.MyTextBox();
            this.txt_Price = new SabzMarkett.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new SabzMarkett.MyButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pb_Products = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Categorie
            // 
            this.cmb_Categorie.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Categorie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Categorie.FillColor = System.Drawing.Color.PaleGreen;
            this.cmb_Categorie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Categorie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Categorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Categorie.ForeColor = System.Drawing.Color.DarkGreen;
            this.cmb_Categorie.ItemHeight = 30;
            this.cmb_Categorie.Items.AddRange(new object[] {
            ""});
            this.cmb_Categorie.Location = new System.Drawing.Point(30, 261);
            this.cmb_Categorie.Name = "cmb_Categorie";
            this.cmb_Categorie.Size = new System.Drawing.Size(260, 36);
            this.cmb_Categorie.TabIndex = 1;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(297, 217);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(93, 25);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "نام محصول ";
            // 
            // btn_Add
            // 
            this.btn_Add.BorderRadius = 8;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Add.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Add.Location = new System.Drawing.Point(275, 459);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.PressedColor = System.Drawing.Color.DarkGreen;
            this.btn_Add.Size = new System.Drawing.Size(130, 87);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "اضافه کردن ";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.DefaultText = "";
            this.txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.FillColor = System.Drawing.Color.PaleGreen;
            this.txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Name.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Location = new System.Drawing.Point(30, 217);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PlaceholderText = "";
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(260, 33);
            this.txt_Name.TabIndex = 0;
            // 
            // lbl_Categorie
            // 
            this.lbl_Categorie.AutoSize = true;
            this.lbl_Categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categorie.Location = new System.Drawing.Point(297, 261);
            this.lbl_Categorie.Name = "lbl_Categorie";
            this.lbl_Categorie.Size = new System.Drawing.Size(143, 25);
            this.lbl_Categorie.TabIndex = 6;
            this.lbl_Categorie.Text = "دست بندی مجصول ";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.Location = new System.Drawing.Point(297, 312);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(107, 25);
            this.lbl_Number.TabIndex = 6;
            this.lbl_Number.Text = "تعداد محصول ";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(297, 355);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(108, 25);
            this.lbl_Price.TabIndex = 6;
            this.lbl_Price.Text = "قیمت محصول ";
            // 
            // lbl_Picture
            // 
            this.lbl_Picture.AutoSize = true;
            this.lbl_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Picture.Location = new System.Drawing.Point(162, 131);
            this.lbl_Picture.Name = "lbl_Picture";
            this.lbl_Picture.Size = new System.Drawing.Size(91, 18);
            this.lbl_Picture.TabIndex = 3;
            this.lbl_Picture.Text = "تصویر محصول ";
            // 
            // txt_Number
            // 
            this.txt_Number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Number.DefaultText = "";
            this.txt_Number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Number.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Number.FillColor = System.Drawing.Color.PaleGreen;
            this.txt_Number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Number.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Number.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_Number.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Number.Location = new System.Drawing.Point(30, 312);
            this.txt_Number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.PlaceholderText = "";
            this.txt_Number.SelectedText = "";
            this.txt_Number.Size = new System.Drawing.Size(260, 33);
            this.txt_Number.TabIndex = 2;
            // 
            // txt_Price
            // 
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.DefaultText = "";
            this.txt_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.FillColor = System.Drawing.Color.PaleGreen;
            this.txt_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Price.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Location = new System.Drawing.Point(70, 355);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PlaceholderText = "";
            this.txt_Price.SelectedText = "";
            this.txt_Price.Size = new System.Drawing.Size(220, 33);
            this.txt_Price.TabIndex = 3;
            this.txt_Price.TextChanged += new System.EventHandler(this.myTextBox3_TextChanged);
            this.txt_Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Price_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading Semibold", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "تومان";
            // 
            // btn_Close
            // 
            this.btn_Close.BorderRadius = 8;
            this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Close.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Close.Location = new System.Drawing.Point(30, 459);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PressedColor = System.Drawing.Color.DarkGreen;
            this.btn_Close.Size = new System.Drawing.Size(130, 87);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "انصراف";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pb_Products
            // 
            this.pb_Products.Image = ((System.Drawing.Image)(resources.GetObject("pb_Products.Image")));
            this.pb_Products.Location = new System.Drawing.Point(142, 13);
            this.pb_Products.Name = "pb_Products";
            this.pb_Products.Size = new System.Drawing.Size(133, 115);
            this.pb_Products.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Products.TabIndex = 7;
            this.pb_Products.TabStop = false;
            this.pb_Products.Click += new System.EventHandler(this.pb_Products_Click_1);
            // 
            // frm_AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 568);
            this.Controls.Add(this.pb_Products);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.lbl_Categorie);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Picture);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.cmb_Categorie);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(461, 615);
            this.MinimumSize = new System.Drawing.Size(461, 47);
            this.Name = "frm_AddProducts";
            this.Text = "frm_AddProducts";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Categorie;
        private System.Windows.Forms.Label lbl_Name;
        private MyButton btn_Add;
        private MyTextBox txt_Name;
        private System.Windows.Forms.Label lbl_Categorie;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Picture;
        private MyTextBox txt_Number;
        private MyTextBox txt_Price;
        private System.Windows.Forms.Label label1;
        private MyButton btn_Close;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pb_Products;
    }
}