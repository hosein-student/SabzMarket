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
    public partial class frm_Settings : FormStyle
    {
        SellerService sellerService;
        public frm_Settings()
        {
            InitializeComponent();
            sellerService = new SellerService();
            pb_Profile.LoadCompleted += Pb_Profile_LoadCompleted;
        }

        private void phb_Profile_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pb_Profile, "لطفا برای انتخاب عکس کلیک کنید.");
        }

        string pathImage;
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
           // var result=await sellerService.SelectSellerAsync(LoginUser.UserName);
            if(result.Success)
            {
                pb_Profile.LoadAsync(result.Data.ProfileImage);
                txt_FirstName.Text = result.Data.FirstName;
                txt_LastName.Text = result.Data.LastName;
                txt_Password1.Text = result.Data.Password;
                txt_Address.Text = result.Data.Address;
                txt_UserName.Text = result.Data.Username;
                cmb_WorkHistory.Text = result.Data.WorkHistory;
                txt_Phone.Text = result.Data.Phone;
                txt_Email.Text = result.Data.Email;
                pathImage = result.Data.ProfileImage;
            }
            else
            {
                ShowInfo(result.Message);
            }
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text.Length >= 3)
            {
                if (!string.IsNullOrEmpty(txt_LastName.Text))
                {
                    if (PhoneNumberValidator.IsValidPhoneNumber(txt_Phone.Text))
                    {
                        
                        if (!string.IsNullOrEmpty(txt_UserName.Text))
                        {
                            if (!string.IsNullOrEmpty(txt_Password1.Text))
                            {
                                if (!string.IsNullOrEmpty(txt_Address.Text))
                                {
                                    if (!string.IsNullOrEmpty(cmb_WorkHistory.Text))
                                    {

                                        SellerDTO sellerDTO = new SellerDTO
                                        {
                                            FirstName = txt_FirstName.Text,
                                            LastName = txt_LastName.Text,
                                            Password = txt_Password1.Text,
                                            Address = txt_Address.Text,
                                            Email = txt_Email.Text,
                                            Phone = txt_Phone.Text,
                                            Username = txt_UserName.Text,
                                            WorkHistory = cmb_WorkHistory.Text,
                                            ProfileImage = pathImage

                                        };
                                        var result = await sellerService.UpdateSellerAsync(LoginUser.UserName, sellerDTO);
                                        if (result.Success)
                                        {
                                            if (ShowInfo(result.Message) == DialogResult.OK)
                                            {
                                                Application.Exit();
                                            }
                                            else
                                            {
                                                Application.Exit();
                                            }

                                        }
                                        else
                                        {
                                            ShowInfo(result.Message);
                                        }
                                    }
                                    else
                                    {
                                       ShowInfo(MessageDTO.enterTheWorkHistory);
                                    }
                                }
                                else
                                {
                                    ShowInfo(MessageDTO.enterTheAddress);
                                }
                            }
                            else
                            {
                                ShowInfo("رمز عبور را وارد کنید");
                            }
                        }
                        else
                        {
                            ShowInfo(MessageDTO.existingUser);
                        }
                    }
                    else
                    {
                        ShowInfo(MessageDTO.numberInvalid);
                    }
                }
                else
                {
                    ShowInfo(MessageDTO.lastNameInvalid1);
                }
            }
            else
            {
                ShowInfo(MessageDTO.firstNameInvalid2);
            }






           
        }
    }
}
