namespace SabzMarket
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pl_Search = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btn_History = new MyButton();
            btn_Search = new MyButton();
            txt_Search = new MyTextBox();
            pl_Search.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(641, 783);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pl_Search
            // 
            pl_Search.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pl_Search.Controls.Add(btn_History);
            pl_Search.Controls.Add(btn_Search);
            pl_Search.Controls.Add(txt_Search);
            pl_Search.CustomizableEdges = customizableEdges7;
            pl_Search.FillColor = Color.SpringGreen;
            pl_Search.FillColor2 = Color.LemonChiffon;
            pl_Search.FillColor3 = Color.LightGreen;
            pl_Search.FillColor4 = Color.BlanchedAlmond;
            pl_Search.Location = new Point(0, 784);
            pl_Search.Margin = new Padding(3, 4, 3, 4);
            pl_Search.Name = "pl_Search";
            pl_Search.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pl_Search.Size = new Size(641, 56);
            pl_Search.TabIndex = 1;
            // 
            // btn_History
            // 
            btn_History.BorderRadius = 8;
            btn_History.CustomizableEdges = customizableEdges1;
            btn_History.DisabledState.BorderColor = Color.DarkGray;
            btn_History.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_History.DisabledState.FillColor = Color.LightGray;
            btn_History.DisabledState.ForeColor = Color.DarkGray;
            btn_History.FillColor = Color.SeaGreen;
            btn_History.Font = new Font("Segoe UI", 11F);
            btn_History.ForeColor = Color.White;
            btn_History.HoverState.FillColor = Color.MediumSeaGreen;
            btn_History.Location = new Point(12, 7);
            btn_History.Margin = new Padding(3, 4, 3, 4);
            btn_History.Name = "btn_History";
            btn_History.PressedColor = Color.DarkGreen;
            btn_History.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_History.Size = new Size(100, 44);
            btn_History.TabIndex = 3;
            btn_History.Text = "History";
            btn_History.Click += btn_History_Click;
            // 
            // btn_Search
            // 
            btn_Search.BorderRadius = 8;
            btn_Search.CustomizableEdges = customizableEdges3;
            btn_Search.DisabledState.BorderColor = Color.DarkGray;
            btn_Search.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Search.DisabledState.FillColor = Color.LightGray;
            btn_Search.DisabledState.ForeColor = Color.DarkGray;
            btn_Search.FillColor = Color.SeaGreen;
            btn_Search.Font = new Font("Segoe UI", 11F);
            btn_Search.ForeColor = Color.White;
            btn_Search.HoverState.FillColor = Color.MediumSeaGreen;
            btn_Search.Location = new Point(118, 6);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.PressedColor = Color.DarkGreen;
            btn_Search.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_Search.Size = new Size(110, 42);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "جستوجو";
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_Search
            // 
            txt_Search.Cursor = Cursors.IBeam;
            txt_Search.CustomizableEdges = customizableEdges5;
            txt_Search.DefaultText = "";
            txt_Search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Search.FillColor = Color.MintCream;
            txt_Search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Search.Font = new Font("Segoe UI", 11F);
            txt_Search.ForeColor = Color.DarkGreen;
            txt_Search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Search.Location = new Point(245, 7);
            txt_Search.Margin = new Padding(4, 6, 4, 6);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "نام خریدار و یا نام محصول را وارد کنید";
            txt_Search.SelectedText = "";
            txt_Search.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_Search.Size = new Size(383, 39);
            txt_Search.TabIndex = 1;
            // 
            // frm_Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 840);
            Controls.Add(pl_Search);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(659, 1261);
            MinimumSize = new Size(659, 887);
            Name = "frm_Orders";
            Text = "frm_Orders";
            Load += frm_Orders_Load;
            pl_Search.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pl_Search;
        private MyTextBox txt_Search;
        private MyButton btn_Search;
        private MyButton btn_History;
    }
}