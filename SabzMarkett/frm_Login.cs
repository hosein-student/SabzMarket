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
    public partial class frm_Login : FormStyle
    {
        UserService userService;
        public frm_Login()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO
            {
                UserName = txt_UserName.Text,
                Password1 = txt_Password.Text
            };
            var resilt = await userService.FoundUserAsync(userDTO);
            if (resilt.Success)
            {
               var result1=await userService.CheckUserToSellerAsync(userDTO);
                if (result1.Success)
                {
                    var result2=await userService.CheckPasswordAsync(userDTO);
                    if(result2.Success)
                    {
                        LoginUser.UserName=txt_UserName.Text;
                        frm_Home frm_Home = new frm_Home();
                        this.Hide();
                        frm_Home.Show();
                    }
                    else
                    {
                        MessageBox.Show(result2.Message);
                    }
                    
                }
                else
                {
                    var result2 = await userService.CheckPasswordAsync(userDTO);
                    if (result2.Success)
                    {
                        LoginUser.UserName = txt_UserName.Text;
                        frm_SellerProfile frm_SellerProfile = new frm_SellerProfile();
                        this.Hide();
                        frm_SellerProfile.Show();
                    }
                    else
                    {
                        MessageBox.Show(result2.Message);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show(resilt.Message);
            }

            

        }

        
    }
}
