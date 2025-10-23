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
        
        public frm_Login()
        {
            InitializeComponent();
            
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO
            {
                UserName = txt_UserName.Text,
                Password1 = txt_Password.Text
            };
            //api{LoginUser.UserName = txt_UserName.Text;
        //    frm_SellerProfile frm_SellerProfile = new frm_SellerProfile();
        //    this.Hide();
        //    frm_SellerProfile.Show();

        //    LoginUser.UserName = txt_UserName.Text;
        //    frm_Home frm_Home = new frm_Home();
        //    this.Hide();
        //    frm_Home.Show();
        //}




            

        }

        
    }
}
