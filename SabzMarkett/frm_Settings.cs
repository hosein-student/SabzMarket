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
        
        public frm_Settings()
        {
            InitializeComponent();
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

        private  void frm_Settings_Load(object sender, EventArgs e)
        {
          
        }

        private  void btn_Update_Click(object sender, EventArgs e)
        {
        }
    }
}
