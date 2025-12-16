using SabzMarket.Share;
using SabzMarket.Share.Models;
using SabzMarket.Share.ViewModels;
using SabzMarketBuyer.UI.Auth;
using SabzMarketBuyer.UI.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabzMarketBuyer.UI
{
    public partial class FrmLogin : FormStyle
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            UserViewModel user = new UserViewModel
            {
                UserName = txtUsername.Text,
                Password1 = txtPassword.Text
            };
            var client = HttpClientHelper.Instance;
            var result = await client.PostAsync<OperationResult, UserViewModel>(ApiRoutes.Login, user);

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
            CurrentUser.UserName = txtUsername.Text;
            string userName = Uri.EscapeDataString(txtUsername.Text);
            var rout = string.Format(ApiRoutes.CheckUserInFarmer, userName);
            var result2 = await client.GetAsync<OperationResult>(rout);
            if (result2 == null)
            {
                ShowInfoError(Messages.InternetErrorMessage);
                return;
            }
            if (!result2!.Success)
            {
                if (result2.Result)
                {
                    FrmFarmerProfile frmFarmerProfile = new FrmFarmerProfile();
                    this.Hide();
                    frmFarmerProfile.Show();
                    return;
                }
                ShowInfoError(result2.Message!);
                return;
            }
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSingUp frmSingUp = new FrmSingUp();
            frmSingUp.ShowDialog();
        }
    }
}
