using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SabzMarket.Share;





namespace SabzMarkett
{
    public partial class frm_SignUp :FormStyle
    {
        
        public frm_SignUp()
        {
            InitializeComponent();
            
            
        }
        

        private void frm_SignUp_Load(object sender, EventArgs e)
        {
            

        }

        private  async void btn_SignUp_Click(object sender, EventArgs e)
        {
            var userviewmodel = new UserViewModel()
            {
                FirstName = txt_FirstName.Text,
                LastName = txt_LastName.Text,
                Email = txt_Email.Text,
                UserName = txt_UserName.Text,
                Password1 = txt_Password1.Text,
                Password2 = txt_Password2.Text,
                Phone = txt_Phone.Text
            };
            if(userviewmodel.IsValid)
            {
                var client = HttpClientHelper.Instance;
                var result = await client.PostAsync<OperationResult, UserViewModel>(RouteConstants.SignUp, userviewmodel);
                if (result.Success)
                {
                    MessageBox.Show(result.Message);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
            else
            {
                MessageBox.Show(userviewmodel.ErrorMessage);
            }
            
            


        }
    }
}
