using Guna.UI2.WinForms;
using SabzMarketBLL;
using SabzMarketShare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabzMarkett
{
    public partial class frm_Home : FormStyle
    {
        SellerService sellerService;
        public frm_Home()
        {
            InitializeComponent();
            pb_Profile.LoadCompleted += Pb_Profile_LoadCompleted;
            sellerService =new SellerService();
            
            this.MouseClick += OpenClosed;
            foreach (Control ctrl in guna2CustomGradientPanel1.Controls)
            {
                    ctrl.MouseClick += OpenClosed;
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != pln_Menu2&& ctrl != btn_Menu)
                    ctrl.MouseClick += OpenClosed;
            }
        }

        private void Pb_Profile_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ShowInfo("عکس بارگذاری نشد");
                pb_Profile.Image = Properties.Resources.profile;
            }
        }


        private async void frm_Home_Load(object sender, EventArgs e)
        {
            var seller= await sellerService.SelectSellerAsync(LoginUser.UserName);
            if (seller.Success)
            {
                lbl_Name.Text = $"{seller.Data.FirstName}  {seller.Data.LastName}";
                lbl_UserName.Text = $"@{LoginUser.UserName}";
                pb_Profile.LoadAsync(seller.Data.ProfileImage);
            }
            else
            {
                ShowInfo(seller.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pln_Menu2.Visible = true;
        }

        private void OpenClosed(object sender, EventArgs e)
        {
            if (pln_Menu2.Visible)
            {
                pln_Menu2.Visible = false;
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frm_Settings frm_Settings = new frm_Settings();
            frm_Settings.ShowDialog();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            frm_AddProducts AddProducts=new frm_AddProducts();
            AddProducts.ShowDialog();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            frm_Orders frm_Orders=new frm_Orders();
            frm_Orders.ShowDialog();    
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            frm_Chat frm_Chat=new frm_Chat();
            frm_Chat.ShowDialog();
        }

       
    }
}
