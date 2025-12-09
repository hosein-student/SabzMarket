using SabzMarket.Share;
using SabzMarket.Share.Models;
using SabzMarket.Share.Requests;
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
    public partial class frm_Settings : FormStyle
    {

        public frm_Settings()
        {
            InitializeComponent();
        }

        private void phb_Profile_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pb_Profile, "لطفا برای انتخاب عکس کلیک کنید.");
        }

        string pathImage = "";
        private void pb_Profile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image.JPG|*.jpg|Image.JPEG|*.jpeg|Image.PNG|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathImage = openFileDialog.FileName;
                pb_Profile.ImageLocation = pathImage;
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

        private async void frm_Settings_Load(object sender, EventArgs e)
        {
            var client = HttpClientHelper.Instance;
            string username = Uri.UnescapeDataString(CurrentUser.UserName!);
            string route = string.Format(RouteConstants.GetSellerByUsername, username);
            var seller = await client
                .GetAsync<OperationResult<SellerFullViewModel>>(route);
            if (seller == null)
            {
                ShowInfoError(Messages.InternetErrorMessage);
                return;
            }
            if (!seller.Success)
            {
                if (!seller.Result)
                {
                    ShowInfoError(seller.Message!);
                    return;
                }
                ShowInfo(seller.Message!);
                return;
            }
            pb_Profile.LoadAsync(seller.Data.ProfileImage);
            pathImage = seller.Data.ProfileImage!;
            txt_FirstName.Text = seller.Data.FirstName;
            txt_LastName.Text = seller.Data.LastName;
            txt_Phone.Text = seller.Data.Phone;
            txt_Email.Text = seller.Data.Email;
            txt_UserName.Text = seller.Data.Username;
            txt_Password.Text = seller.Data.Password;
            txt_Address.Text = seller.Data.Address;
            cmb_WorkHistory.Text = seller.Data.WorkHistory;
        }
        public event EventHandler LoodPanel;

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            var client = HttpClientHelper.Instance;
            string route = string.Format(RouteConstants.UpdateSeller, CurrentUser.UserName);
            UserViewModel userViewModel = new UserViewModel
            {
                FirstName = txt_FirstName.Text,
                LastName = txt_LastName.Text,
                Phone = txt_Phone.Text,
                Email = txt_Email.Text,
                UserName = txt_UserName.Text,
                Password1 = txt_Password.Text,
                Password2 = txt_Password.Text,
            };
            SellerPartialViewModel sellerPartial = new SellerPartialViewModel
            {
                Address = txt_Address.Text,
                Username = txt_UserName.Text,
                ProfileImage = pathImage,
                WorkHistory = cmb_WorkHistory.Text
            };
            if (!userViewModel.IsValid)
            {
                ShowInfo(userViewModel.ErrorMessage);
                return;
            }
            if (!sellerPartial.IsValid)
            {
                ShowInfo(sellerPartial.ErrorMessage);
            }
            RequestPayload payload = new RequestPayload
            {
                SellerPartial = sellerPartial,
                UserViewModel = userViewModel
            };
            var result = await client.PostAsync<OperationResult, RequestPayload>(route, payload);
            if (result == null)
            {
                ShowInfoError(Messages.InternetErrorMessage);
                return;
            }
            if (!result.Success)
            {
                if(!result.Result)
                {
                    ShowInfoError(result.Message!);
                    return;
                }
                ShowInfo(result.Message);
                return;
            }
            ShowInfo(result.Message!);
            LoodPanel?.Invoke(this, EventArgs.Empty);
            CurrentUser.UserName = txt_UserName.Text;
        }

        private void pb_Profile_LoadCompleted_1(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ShowInfo("عکس بارگذاری نشد");
                pb_Profile.Image = Properties.Resources.profile;
            }
        }
    }
}
