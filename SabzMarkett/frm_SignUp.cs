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
        
        public frm_SignUp()
        {
            InitializeComponent();
            
            
        }
        

        private void frm_SignUp_Load(object sender, EventArgs e)
        {
            

        }

        private async void btn_SignUp_Click(object sender, EventArgs e)
        {
            if(txt_FirstName.Text.Length>=3)
            {
                if(!string.IsNullOrWhiteSpace(txt_LastName.Text))
                {
                    if(PhoneNumberValidator.IsValidPhoneNumber(txt_Phone.Text))
                    {
                        if(!string.IsNullOrWhiteSpace(txt_UserName.Text))
                        {
                            bool passwordsMatch = txt_Password1.Text == txt_Password2.Text;
                            bool passwordNotEmpty = !string.IsNullOrEmpty(txt_Password1.Text);
                            if (passwordsMatch& passwordNotEmpty)
                            {
                                UserDTO userDTO = new UserDTO
                                {
                                    FirstName = txt_FirstName.Text,
                                    LastName = txt_LastName.Text,
                                    Phone = txt_Phone.Text,
                                    Email = txt_Email.Text,
                                    UserName = txt_UserName.Text,
                                    Password1 = txt_Password1.Text,
                                    Password2 = txt_Password2.Text
                                };
                                ///ddd
                            }
                            else
                            {
                                ShowInfo(MessageDTO.passwordMatch);
                            }
                        }
                        else
                        {
                            ShowInfo(MessageDTO.Mandatory);
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
           

            // var result=await userService.InsertUserAsync(userDTO);
            //if (result.Success)
            //    ShowInfo(result.Message);
            //else
            //    ShowInfo(result.Message);
            
        }
    }
}
