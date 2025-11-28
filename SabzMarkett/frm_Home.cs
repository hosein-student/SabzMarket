using Guna.UI2.WinForms;
using SabzMarket.Share;
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
        public frm_Home()
        {
            InitializeComponent();
            pb_Profile.LoadCompleted += Pb_Profile_LoadCompleted;

            this.MouseClick += OpenClosed;
            foreach (Control ctrl in guna2CustomGradientPanel1.Controls)
            {
                ctrl.MouseClick += OpenClosed;
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != pln_Menu2 && ctrl != btn_Menu)
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
            this.WindowState = FormWindowState.Maximized;
            var client = HttpClientHelper.Instance;
            string route = string.Format(RouteConstants.GetSellerByUsername, CurrentUser.UserName);
            var seller = await client.GetAsync<OperationResult<SellerFullViewModel>>(route);
            if(seller.Success)
            {
                lbl_Name.Text = $"{seller.Data.FirstName} {seller.Data.LastName}";
                lbl_UserName.Text = seller.Data.Username;
                pb_Profile.LoadAsync(seller.Data.ProfileImage);
            }
            else
            {
                MessageBox.Show(seller.Message);
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
        private void btn_Setting_Click(object sender, EventArgs e)
        {
            frm_Settings frm_Settings = new frm_Settings();
            frm_Settings.LoodPanel += frm_Home_Load;
            frm_Settings.ShowDialog();
        }

        

        private void btn_Orders_Click(object sender, EventArgs e)
        {

            frm_Orders frm_Orders = new frm_Orders();
            frm_Orders.ShowDialog();
        }
        private void btn_Chat_Click(object sender, EventArgs e)
        {
            frm_Chat frm_Chat = new frm_Chat();
            frm_Chat.ShowDialog();
        }
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            frm_AddProducts AddProducts = new frm_AddProducts();
            AddProducts.ShowDialog();
        }

        private void frm_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
