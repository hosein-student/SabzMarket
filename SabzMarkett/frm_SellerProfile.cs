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
        
        public frm_SellerProfile()
        {
            InitializeComponent();
            
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


        private void btn_registration_Click(object sender, EventArgs e)
        {
        }
    }
}
