namespace SabzMarkett
{
    partial class frm_Orders
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Search = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_History = new SabzMarkett.MyButton();
            this.myButton1 = new SabzMarkett.MyButton();
            this.txt_Search = new SabzMarkett.MyTextBox();
            this.btn_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(641, 672);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Controls.Add(this.btn_History);
            this.btn_Search.Controls.Add(this.myButton1);
            this.btn_Search.Controls.Add(this.txt_Search);
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Search.FillColor = System.Drawing.Color.SpringGreen;
            this.btn_Search.FillColor2 = System.Drawing.Color.LemonChiffon;
            this.btn_Search.FillColor3 = System.Drawing.Color.LightGreen;
            this.btn_Search.FillColor4 = System.Drawing.Color.BlanchedAlmond;
            this.btn_Search.Location = new System.Drawing.Point(0, 629);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(641, 43);
            this.btn_Search.TabIndex = 1;
            // 
            // btn_History
            // 
            this.btn_History.BorderRadius = 8;
            this.btn_History.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_History.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_History.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.btn_History.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_History.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_History.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_History.ForeColor = System.Drawing.Color.White;
            this.btn_History.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_History.Location = new System.Drawing.Point(5, 4);
            this.btn_History.Name = "btn_History";
            this.btn_History.PressedColor = System.Drawing.Color.DarkGreen;
            this.btn_History.Size = new System.Drawing.Size(100, 35);
            this.btn_History.TabIndex = 3;
            this.btn_History.Text = "History";
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // myButton1
            // 
            this.myButton1.BorderRadius = 8;
            this.myButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.myButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.myButton1.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.myButton1.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.myButton1.FillColor = System.Drawing.Color.SeaGreen;
            this.myButton1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.myButton1.Location = new System.Drawing.Point(118, 5);
            this.myButton1.Name = "myButton1";
            this.myButton1.PressedColor = System.Drawing.Color.DarkGreen;
            this.myButton1.Size = new System.Drawing.Size(110, 34);
            this.myButton1.TabIndex = 2;
            this.myButton1.Text = "جستوجو";
            // 
            // txt_Search
            // 
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FillColor = System.Drawing.Color.MintCream;
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Search.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Location = new System.Drawing.Point(239, 5);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderText = "نام خریدار و یا نام محصول را وارد کنید";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(383, 31);
            this.txt_Search.TabIndex = 1;
            // 
            // frm_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 672);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(659, 1018);
            this.MinimumSize = new System.Drawing.Size(659, 719);
            this.Name = "frm_Orders";
            this.Text = "frm_Orders";
            this.btn_Search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel btn_Search;
        private MyTextBox txt_Search;
        private MyButton myButton1;
        private MyButton btn_History;
    }
}