namespace SabzMarketBuyer.UI
{
    partial class FrmFarmerProfile
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
            lblAddress = new Label();
            txtAddress = new TextBox();
            btnSave = new Button();
            txtDataBuilt = new TextBox();
            txtLandArea = new TextBox();
            txtNationalCode = new TextBox();
            txtCodParvaneBHB = new TextBox();
            txtCodePosti = new TextBox();
            lblDataBuilt = new Label();
            lblLandArea = new Label();
            lblNationalCode = new Label();
            lblCodParvaneBHB = new Label();
            lblCodePosti = new Label();
            pbProfile = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            SuspendLayout();
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(245, 124);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(56, 28);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "آدرس";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(11, 118);
            txtAddress.Margin = new Padding(2, 2, 2, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(230, 34);
            txtAddress.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(145, 377);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 65);
            btnSave.TabIndex = 6;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDataBuilt
            // 
            txtDataBuilt.Location = new Point(11, 159);
            txtDataBuilt.Margin = new Padding(2, 2, 2, 2);
            txtDataBuilt.Name = "txtDataBuilt";
            txtDataBuilt.Size = new Size(230, 34);
            txtDataBuilt.TabIndex = 1;
            // 
            // txtLandArea
            // 
            txtLandArea.Location = new Point(11, 200);
            txtLandArea.Margin = new Padding(2, 2, 2, 2);
            txtLandArea.Name = "txtLandArea";
            txtLandArea.Size = new Size(230, 34);
            txtLandArea.TabIndex = 2;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(11, 241);
            txtNationalCode.Margin = new Padding(2, 2, 2, 2);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(230, 34);
            txtNationalCode.TabIndex = 3;
            // 
            // txtCodParvaneBHB
            // 
            txtCodParvaneBHB.Location = new Point(11, 282);
            txtCodParvaneBHB.Margin = new Padding(2, 2, 2, 2);
            txtCodParvaneBHB.Name = "txtCodParvaneBHB";
            txtCodParvaneBHB.Size = new Size(230, 34);
            txtCodParvaneBHB.TabIndex = 4;
            // 
            // txtCodePosti
            // 
            txtCodePosti.Location = new Point(11, 323);
            txtCodePosti.Margin = new Padding(2, 2, 2, 2);
            txtCodePosti.Name = "txtCodePosti";
            txtCodePosti.Size = new Size(230, 34);
            txtCodePosti.TabIndex = 5;
            // 
            // lblDataBuilt
            // 
            lblDataBuilt.AutoSize = true;
            lblDataBuilt.Location = new Point(245, 165);
            lblDataBuilt.Margin = new Padding(2, 0, 2, 0);
            lblDataBuilt.Name = "lblDataBuilt";
            lblDataBuilt.Size = new Size(103, 28);
            lblDataBuilt.TabIndex = 8;
            lblDataBuilt.Text = "زمان احداث";
            // 
            // lblLandArea
            // 
            lblLandArea.AutoSize = true;
            lblLandArea.Location = new Point(245, 206);
            lblLandArea.Margin = new Padding(2, 0, 2, 0);
            lblLandArea.Name = "lblLandArea";
            lblLandArea.Size = new Size(202, 28);
            lblLandArea.TabIndex = 9;
            lblLandArea.Text = "مساحت زمین(متر مربع)";
            // 
            // lblNationalCode
            // 
            lblNationalCode.AutoSize = true;
            lblNationalCode.Location = new Point(245, 244);
            lblNationalCode.Margin = new Padding(2, 0, 2, 0);
            lblNationalCode.Name = "lblNationalCode";
            lblNationalCode.Size = new Size(73, 28);
            lblNationalCode.TabIndex = 10;
            lblNationalCode.Text = "کد ملی";
            // 
            // lblCodParvaneBHB
            // 
            lblCodParvaneBHB.AutoSize = true;
            lblCodParvaneBHB.Location = new Point(245, 288);
            lblCodParvaneBHB.Margin = new Padding(2, 0, 2, 0);
            lblCodParvaneBHB.Name = "lblCodParvaneBHB";
            lblCodParvaneBHB.Size = new Size(204, 28);
            lblCodParvaneBHB.TabIndex = 11;
            lblCodParvaneBHB.Text = "شماره پروانه بهره برداری";
            // 
            // lblCodePosti
            // 
            lblCodePosti.AutoSize = true;
            lblCodePosti.Location = new Point(245, 329);
            lblCodePosti.Margin = new Padding(2, 0, 2, 0);
            lblCodePosti.Name = "lblCodePosti";
            lblCodePosti.Size = new Size(85, 28);
            lblCodePosti.TabIndex = 12;
            lblCodePosti.Text = "کد پستی";
            // 
            // pbProfile
            // 
            pbProfile.Image = Properties.Resources.profile;
            pbProfile.Location = new Point(174, 9);
            pbProfile.Margin = new Padding(2, 2, 2, 2);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(105, 103);
            pbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfile.TabIndex = 13;
            pbProfile.TabStop = false;
            pbProfile.Click += pbProfile_Click;
            pbProfile.MouseHover += pbProfile_MouseHover;
            // 
            // FrmFarmerProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 453);
            Controls.Add(pbProfile);
            Controls.Add(lblCodePosti);
            Controls.Add(lblCodParvaneBHB);
            Controls.Add(lblNationalCode);
            Controls.Add(lblLandArea);
            Controls.Add(lblDataBuilt);
            Controls.Add(txtCodePosti);
            Controls.Add(txtCodParvaneBHB);
            Controls.Add(txtNationalCode);
            Controls.Add(txtLandArea);
            Controls.Add(txtDataBuilt);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MaximumSize = new Size(480, 500);
            MinimumSize = new Size(480, 500);
            Name = "FrmFarmerProfile";
            Text = "FrmFarmerProfile";
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddress;
        private TextBox txtAddress;
        private Button btnSave;
        private TextBox txtDataBuilt;
        private TextBox txtLandArea;
        private TextBox txtNationalCode;
        private TextBox txtCodParvaneBHB;
        private TextBox txtCodePosti;
        private Label lblDataBuilt;
        private Label lblLandArea;
        private Label lblNationalCode;
        private Label lblCodParvaneBHB;
        private Label lblCodePosti;
        private PictureBox pbProfile;
    }
}