namespace SabzMarket
{
    partial class frm_History
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_History));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pl_Search = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btn_Search = new MyButton();
            txt_Search = new MyTextBox();
            pl_Search.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Honeydew;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(514, 769);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pl_Search
            // 
            pl_Search.Controls.Add(btn_Search);
            pl_Search.Controls.Add(txt_Search);
            pl_Search.CustomizableEdges = customizableEdges5;
            pl_Search.Dock = DockStyle.Bottom;
            pl_Search.FillColor = Color.SpringGreen;
            pl_Search.FillColor2 = Color.LemonChiffon;
            pl_Search.FillColor3 = Color.LightGreen;
            pl_Search.FillColor4 = Color.BlanchedAlmond;
            pl_Search.Location = new Point(0, 769);
            pl_Search.Margin = new Padding(3, 4, 3, 4);
            pl_Search.Name = "pl_Search";
            pl_Search.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pl_Search.Size = new Size(514, 47);
            pl_Search.TabIndex = 0;
            // 
            // btn_Search
            // 
            btn_Search.BorderRadius = 8;
            btn_Search.CustomizableEdges = customizableEdges1;
            btn_Search.DisabledState.BorderColor = Color.DarkGray;
            btn_Search.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Search.DisabledState.FillColor = Color.LightGray;
            btn_Search.DisabledState.ForeColor = Color.DarkGray;
            btn_Search.FillColor = Color.SeaGreen;
            btn_Search.Font = new Font("Segoe UI", 11F);
            btn_Search.ForeColor = Color.White;
            btn_Search.HoverState.FillColor = Color.MediumSeaGreen;
            btn_Search.Location = new Point(3, 3);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.PressedColor = Color.DarkGreen;
            btn_Search.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_Search.Size = new Size(110, 42);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "جستوجو";
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_Search
            // 
            txt_Search.Cursor = Cursors.IBeam;
            txt_Search.CustomizableEdges = customizableEdges3;
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
            txt_Search.Location = new Point(120, 4);
            txt_Search.Margin = new Padding(4, 6, 4, 6);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "نام خریدار و یا نام محصول را وارد کنید";
            txt_Search.SelectedText = "";
            txt_Search.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_Search.Size = new Size(390, 38);
            txt_Search.TabIndex = 1;
            // 
            // frm_History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 816);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pl_Search);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(532, 863);
            MinimumSize = new Size(532, 863);
            Name = "frm_History";
            Text = "سابقه ی سفارشات";
            Load += frm_History_Load;
            pl_Search.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pl_Search;
        private MyButton btn_Search;
        private MyTextBox txt_Search;
    }
}