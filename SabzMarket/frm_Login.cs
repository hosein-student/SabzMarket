using SabzMarket.Share;
using SabzMarket.Share.Models;
using SabzMarket.Share.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabzMarket
{
    public partial class frm_Login : FormStyle
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            UserViewModel user = new UserViewModel
            {
                UserName = txt_UserName.Text,
                Password1 = txt_Password.Text
            };
            var client = HttpClientHelper.Instance;
            var result = await client.PostAsync<OperationResult, UserViewModel>(RouteConstants.Login, user);
            
            if (result == null)
            {
                ShowInfoError(Messages.InternetErrorMessage);
                return;
            }

            if (!result!.Success)
            {
                if (result.Result)
                {
                    ShowInfo(result.Message!);
                    return;
                }
                    ShowInfoError(result.Message!);
                return;
            }
            CurrentUser.UserName = txt_UserName.Text;
            string userName = Uri.EscapeDataString(txt_UserName.Text);
            var rout = string.Format(RouteConstants.CheckUserInSeller, userName);
            var result1 = await client.GetAsync<OperationResult>(rout);
            if (result1 == null)
            {
                ShowInfoError(Messages.InternetErrorMessage);
                return;
            }
            if (!result1!.Success)
            {
                if (result1.Result)
                {
                    frm_SellerProfile frm_SellerProfile = new frm_SellerProfile();
                    this.Hide();
                    frm_SellerProfile.Show();
                    return;
                }
                    ShowInfoError(result1.Message!);
                return;
            }
                frm_Home frm_Home = new frm_Home();
                this.Hide();
                frm_Home.Show();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            frm_SignUp frm = new frm_SignUp();
            frm.ShowDialog();
        }
    }
}
