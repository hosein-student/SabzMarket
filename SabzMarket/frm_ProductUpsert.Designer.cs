namespace SabzMarket
{
    partial class frm_ProductUpsert
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProductUpsert));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmb_Categorie = new Guna.UI2.WinForms.Guna2ComboBox();
            lbl_Name = new Label();
            btn_Add = new MyButton();
            txt_Name = new MyTextBox();
            lbl_Categorie = new Label();
            lbl_Number = new Label();
            lbl_Price = new Label();
            lbl_Picture = new Label();
            txt_Number = new MyTextBox();
            txt_Price = new MyTextBox();
            label1 = new Label();
            btn_Close = new MyButton();
            openFileDialog1 = new OpenFileDialog();
            pb_Products = new PictureBox();
            lbl_Description = new Label();
            txt_Description = new MyTextBox();
            ((System.ComponentModel.ISupportInitialize)pb_Products).BeginInit();
            SuspendLayout();
            // 
            // cmb_Categorie
            // 
            cmb_Categorie.BackColor = Color.Transparent;
            cmb_Categorie.CustomizableEdges = customizableEdges1;
            cmb_Categorie.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_Categorie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categorie.FillColor = Color.PaleGreen;
            cmb_Categorie.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_Categorie.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_Categorie.Font = new Font("Segoe UI", 10F);
            cmb_Categorie.ForeColor = Color.DarkGreen;
            cmb_Categorie.ItemHeight = 30;
            cmb_Categorie.Items.AddRange(new object[] { "" });
            cmb_Categorie.Location = new Point(30, 262);
            cmb_Categorie.Margin = new Padding(3, 4, 3, 4);
            cmb_Categorie.Name = "cmb_Categorie";
            cmb_Categorie.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmb_Categorie.Size = new Size(260, 36);
            cmb_Categorie.TabIndex = 1;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Name.Location = new Point(297, 208);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(93, 25);
            lbl_Name.TabIndex = 3;
            lbl_Name.Text = "نام محصول ";
            // 
            // btn_Add
            // 
            btn_Add.BorderRadius = 8;
            btn_Add.CustomizableEdges = customizableEdges3;
            btn_Add.DisabledState.BorderColor = Color.DarkGray;
            btn_Add.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Add.DisabledState.FillColor = Color.LightGray;
            btn_Add.DisabledState.ForeColor = Color.DarkGray;
            btn_Add.FillColor = Color.SeaGreen;
            btn_Add.Font = new Font("Segoe UI", 11F);
            btn_Add.ForeColor = Color.White;
            btn_Add.HoverState.FillColor = Color.MediumSeaGreen;
            btn_Add.Location = new Point(260, 574);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.PressedColor = Color.DarkGreen;
            btn_Add.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_Add.Size = new Size(130, 109);
            btn_Add.TabIndex = 4;
            btn_Add.Text = "اضافه کردن ";
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_Name
            // 
            txt_Name.Cursor = Cursors.IBeam;
            txt_Name.CustomizableEdges = customizableEdges5;
            txt_Name.DefaultText = "";
            txt_Name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Name.FillColor = Color.PaleGreen;
            txt_Name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Name.Font = new Font("Segoe UI", 11F);
            txt_Name.ForeColor = Color.DarkGreen;
            txt_Name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Name.Location = new Point(30, 208);
            txt_Name.Margin = new Padding(4, 6, 4, 6);
            txt_Name.Name = "txt_Name";
            txt_Name.PlaceholderText = "";
            txt_Name.SelectedText = "";
            txt_Name.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_Name.Size = new Size(260, 41);
            txt_Name.TabIndex = 0;
            // 
            // lbl_Categorie
            // 
            lbl_Categorie.AutoSize = true;
            lbl_Categorie.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Categorie.Location = new Point(297, 262);
            lbl_Categorie.Name = "lbl_Categorie";
            lbl_Categorie.Size = new Size(143, 25);
            lbl_Categorie.TabIndex = 6;
            lbl_Categorie.Text = "دست بندی مجصول ";
            // 
            // lbl_Number
            // 
            lbl_Number.AutoSize = true;
            lbl_Number.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Number.Location = new Point(297, 326);
            lbl_Number.Name = "lbl_Number";
            lbl_Number.Size = new Size(107, 25);
            lbl_Number.TabIndex = 6;
            lbl_Number.Text = "تعداد محصول ";
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Price.Location = new Point(297, 380);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(108, 25);
            lbl_Price.TabIndex = 6;
            lbl_Price.Text = "قیمت محصول ";
            // 
            // lbl_Picture
            // 
            lbl_Picture.AutoSize = true;
            lbl_Picture.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Picture.Location = new Point(162, 164);
            lbl_Picture.Name = "lbl_Picture";
            lbl_Picture.Size = new Size(91, 18);
            lbl_Picture.TabIndex = 3;
            lbl_Picture.Text = "تصویر محصول ";
            // 
            // txt_Number
            // 
            txt_Number.Cursor = Cursors.IBeam;
            txt_Number.CustomizableEdges = customizableEdges7;
            txt_Number.DefaultText = "";
            txt_Number.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Number.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Number.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Number.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Number.FillColor = Color.PaleGreen;
            txt_Number.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Number.Font = new Font("Segoe UI", 11F);
            txt_Number.ForeColor = Color.DarkGreen;
            txt_Number.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Number.Location = new Point(30, 326);
            txt_Number.Margin = new Padding(4, 6, 4, 6);
            txt_Number.Name = "txt_Number";
            txt_Number.PlaceholderText = "";
            txt_Number.SelectedText = "";
            txt_Number.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txt_Number.Size = new Size(260, 41);
            txt_Number.TabIndex = 2;
            txt_Number.KeyDown += txt_Number_KeyDown;
            // 
            // txt_Price
            // 
            txt_Price.Cursor = Cursors.IBeam;
            txt_Price.CustomizableEdges = customizableEdges9;
            txt_Price.DefaultText = "";
            txt_Price.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Price.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Price.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Price.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Price.FillColor = Color.PaleGreen;
            txt_Price.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Price.Font = new Font("Segoe UI", 11F);
            txt_Price.ForeColor = Color.DarkGreen;
            txt_Price.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Price.Location = new Point(70, 380);
            txt_Price.Margin = new Padding(4, 6, 4, 6);
            txt_Price.Name = "txt_Price";
            txt_Price.PlaceholderText = "";
            txt_Price.SelectedText = "";
            txt_Price.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txt_Price.Size = new Size(220, 41);
            txt_Price.TabIndex = 3;
            txt_Price.TextChanged += myTextBox3_TextChanged;
            txt_Price.KeyDown += txt_Price_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 388);
            label1.Name = "label1";
            label1.Size = new Size(35, 16);
            label1.TabIndex = 6;
            label1.Text = "تومان";
            // 
            // btn_Close
            // 
            btn_Close.BorderRadius = 8;
            btn_Close.CustomizableEdges = customizableEdges11;
            btn_Close.DisabledState.BorderColor = Color.DarkGray;
            btn_Close.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Close.DisabledState.FillColor = Color.LightGray;
            btn_Close.DisabledState.ForeColor = Color.DarkGray;
            btn_Close.FillColor = Color.SeaGreen;
            btn_Close.Font = new Font("Segoe UI", 11F);
            btn_Close.ForeColor = Color.White;
            btn_Close.HoverState.FillColor = Color.MediumSeaGreen;
            btn_Close.Location = new Point(30, 574);
            btn_Close.Margin = new Padding(3, 4, 3, 4);
            btn_Close.Name = "btn_Close";
            btn_Close.PressedColor = Color.DarkGreen;
            btn_Close.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btn_Close.Size = new Size(130, 109);
            btn_Close.TabIndex = 5;
            btn_Close.Text = "انصراف";
            btn_Close.Click += btn_Close_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pb_Products
            // 
            pb_Products.Image = (Image)resources.GetObject("pb_Products.Image");
            pb_Products.Location = new Point(142, 16);
            pb_Products.Margin = new Padding(3, 4, 3, 4);
            pb_Products.Name = "pb_Products";
            pb_Products.Size = new Size(133, 144);
            pb_Products.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Products.TabIndex = 7;
            pb_Products.TabStop = false;
            pb_Products.Click += pb_Products_Click_1;
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize = true;
            lbl_Description.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Description.Location = new Point(297, 435);
            lbl_Description.Name = "lbl_Description";
            lbl_Description.Size = new Size(82, 25);
            lbl_Description.TabIndex = 8;
            lbl_Description.Text = "توضیحات ";
            // 
            // txt_Description
            // 
            txt_Description.AutoSize = true;
            txt_Description.Cursor = Cursors.IBeam;
            txt_Description.CustomizableEdges = customizableEdges13;
            txt_Description.DefaultText = "";
            txt_Description.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Description.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Description.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Description.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Description.FillColor = Color.PaleGreen;
            txt_Description.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Description.Font = new Font("Segoe UI", 11F);
            txt_Description.ForeColor = Color.DarkGreen;
            txt_Description.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Description.Location = new Point(30, 435);
            txt_Description.Margin = new Padding(4, 6, 4, 6);
            txt_Description.Name = "txt_Description";
            txt_Description.PlaceholderText = "";
            txt_Description.SelectedText = "";
            txt_Description.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txt_Description.Size = new Size(260, 49);
            txt_Description.TabIndex = 4;
            // 
            // frm_ProductUpsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 710);
            Controls.Add(txt_Description);
            Controls.Add(lbl_Description);
            Controls.Add(pb_Products);
            Controls.Add(label1);
            Controls.Add(txt_Price);
            Controls.Add(lbl_Price);
            Controls.Add(lbl_Number);
            Controls.Add(lbl_Categorie);
            Controls.Add(txt_Number);
            Controls.Add(txt_Name);
            Controls.Add(btn_Close);
            Controls.Add(btn_Add);
            Controls.Add(lbl_Picture);
            Controls.Add(lbl_Name);
            Controls.Add(cmb_Categorie);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(461, 757);
            MinimumSize = new Size(461, 47);
            Name = "frm_ProductUpsert";
            Text = "ثبت و ویرایش محصول";
            Load += frm_AddProducts_Load;
            ((System.ComponentModel.ISupportInitialize)pb_Products).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.Label lbl_Description;
        private MyTextBox txt_Description;
    }
}