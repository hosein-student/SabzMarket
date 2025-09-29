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
    public partial class frm_SellerProfile : FormStyle
    {
        SellerService sellerService;
        
        public frm_SellerProfile()
        {
            InitializeComponent();
            sellerService = new SellerService();
            
        }

        private void Frm_SellerProfile_Load(object sender, EventArgs e)
        {

        }

        private void phb_Profile_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pb_Profile, "لطفا برای انتخاب عکس کلیک کنید.");
        }
        string pathImage;
        private void phb_Profile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image.JPG|*.jpg|Image.JPEG|*.jpeg|Image.PNG|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathImage = openFileDialog.FileName;
                pb_Profile.ImageLocation = pathImage;
            }
        }


        private async void btn_registration_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Address.Text))
            {
                if (!string.IsNullOrWhiteSpace(cob_WorkHistory.Text))
                {
                    if (!string.IsNullOrWhiteSpace(pathImage))
                    {

                        SellerDTO sellerDTO = new SellerDTO
                        {
                            Address = txt_Address.Text,
                            ProfileImage = pathImage,
                            WorkHistory = cob_WorkHistory.Text
                        };
                        var result = await sellerService.InsertSelllerAsync(LoginUser.UserName, sellerDTO);
                        if (result.Success)
                        {
                            frm_Home frm_Home = new frm_Home();
                            this.Hide();
                            frm_Home.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(result.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show(MessageDTO.photoNotSelected);
                    }
                }
                else
                {
                    MessageBox.Show(MessageDTO.enterTheWorkHistory);
                }
            }
            else
            {
                MessageBox.Show(MessageDTO.enterTheAddress);
                txt_Address.Focus();
            }
        }
    }
}
