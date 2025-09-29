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
    public partial class frm_SignUp :FormStyle
    {
        UserService userService;
        public frm_SignUp()
        {
            InitializeComponent();
            userService = new UserService();
            
        }
        

        private void frm_SignUp_Load(object sender, EventArgs e)
        {
            

        }

        private async void btn_SignUp_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO
            {
                FirstName=txt_FirstName.Text,
                LastName=txt_LastName.Text, 
                Phone=txt_Phone.Text,
                Email=txt_Email.Text,
                UserName=txt_UserName.Text,
                Password1 = txt_Password1.Text,
                Password2 = txt_Password2.Text
            };

             var result=await userService.InsertUserAsync(userDTO);
            if (result.Success)
                MessageBox.Show(result.Message);
            else
                MessageBox.Show(result.Message);
            
        }
    }
}
