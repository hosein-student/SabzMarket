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
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabzMarketBuyer.UI
{
    public partial class FrmMain : FormStyle
    {
        public FrmMain()
        {
            InitializeComponent();
            // pb_Profile.LoadCompleted += Pb_Profile_LoadCompleted;

            this.MouseClick += OpenClosed;
            //foreach (Control ctrl in guna2CustomGradientPanel1.Controls)
            //{
            //    ctrl.MouseClick += OpenClosed;
            //}
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != pnlHamburgerMenu && ctrl != btnShowMenu)
                    ctrl.MouseClick += OpenClosed;
            }
        }

        private void plSetting_MouseDown(object sender, MouseEventArgs e)
        {
            pnlSetting.BackColor = Color.LightGreen;
        }

        private void plSetting_MouseUp(object sender, MouseEventArgs e)
        {
            pnlSetting.BackColor = Color.PaleGreen;
        }

        private void btnSeting_Click(object sender, EventArgs e)
        {
            plSetting_Click(this, EventArgs.Empty);
        }

        private void lblSetting_Click(object sender, EventArgs e)
        {
            plSetting_Click(this, EventArgs.Empty);
        }

        private void plSetting_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.LoodPanel += FrmSettings_LoodPanel;
            frmSettings.ShowDialog();
        }

        private async void FrmSettings_LoodPanel(object? sender, EventArgs e)
        {
            await SetUserHeaderInfo();
        }

        private void btnSeting_MouseUp(object sender, MouseEventArgs e)
        {
            plSetting_MouseUp(sender, e);
        }

        private void btnSeting_MouseDown(object sender, MouseEventArgs e)
        {
            plSetting_MouseDown(sender, e);
        }

        private void lblSetting_MouseDown(object sender, MouseEventArgs e)
        {
            plSetting_MouseDown(sender, e);
        }

        private void lblSetting_MouseUp(object sender, MouseEventArgs e)
        {
            plSetting_MouseUp(sender, e);
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            pnlHamburgerMenu.Visible = true;
        }
        private void OpenClosed(object sender, EventArgs e)
        {
            if (pnlHamburgerMenu.Visible)
            {
                pnlHamburgerMenu.Visible = false;
            }
        }

        private void pbProfile_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ShowInfo("عکس بارگذاری نشد");
                pbProfile.Image = Properties.Resources.profile;
            }
        }
        public async Task SetUserHeaderInfo()
        {
            var client = HttpClientHelper.Instance;
            var rout = string.Format(ApiRoutes.GetFarmerFullByUsername, CurrentUser.UserName);
            var result = await client.GetAsync<OperationResult<FarmerDTO>>(rout);
            if (result == null)
            {
                ShowInfoError(Messages.InternetErrorMessage);
                Application.Exit();
                return;
            }
            if (!result.Success)
            {
                if (!result.Result)
                {
                    ShowInfoError(result.Message!);
                    Application.Exit();
                    return;
                }
                ShowInfo(result.Message!);
                Application.Exit();
                return;
            }
            lblName.Text = $"{result.Data.FirstName} {result.Data.LastName}";
            lblUserName.Text = result.Data.UserName;
            pbProfile.LoadAsync(result.Data.ProfileImage);
            CurrentUser.UserId = result.Data.UserId;
            CurrentUser.FarmerId = result.Data.Id;
        }
        private async void FrmMain_Load(object sender, EventArgs e)
        {
            await SetUserHeaderInfo();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
