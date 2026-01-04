namespace SabzMarketBuyer.UI
{
    partial class FrmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCart));
            pnlCart = new FlowLayoutPanel();
            btnPay = new Button();
            lblTitleTotalAmount = new Label();
            lblTotalAmount = new Label();
            SuspendLayout();
            // 
            // pnlCart
            // 
            pnlCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCart.AutoScroll = true;
            pnlCart.BackColor = Color.Ivory;
            pnlCart.Location = new Point(0, 0);
            pnlCart.Name = "pnlCart";
            pnlCart.Size = new Size(759, 515);
            pnlCart.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPay.Location = new Point(36, 535);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(82, 54);
            btnPay.TabIndex = 1;
            btnPay.Text = "پرداخت";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // lblTitleTotalAmount
            // 
            lblTitleTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitleTotalAmount.AutoSize = true;
            lblTitleTotalAmount.Location = new Point(568, 535);
            lblTitleTotalAmount.Name = "lblTitleTotalAmount";
            lblTitleTotalAmount.Size = new Size(153, 28);
            lblTitleTotalAmount.TabIndex = 2;
            lblTitleTotalAmount.Text = "مبلغ قابل پرداخت";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.ForeColor = Color.Green;
            lblTotalAmount.Location = new Point(216, 535);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(23, 28);
            lblTotalAmount.TabIndex = 3;
            lblTotalAmount.Text = "0";
            // 
            // FrmCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 620);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblTitleTotalAmount);
            Controls.Add(btnPay);
            Controls.Add(pnlCart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCart";
            Text = "سبد خرید ";
            FormClosing += FrmCart_FormClosing;
            Load += FrmCart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel pnlCart;
        private Button btnPay;
        private Label lbl;
        private Label lblTitleTotalAmount;
        private Label lblTotalAmount;
    }
}