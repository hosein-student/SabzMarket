using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Telerik.WinControls.UI.ValueMapper;

namespace SabzMarkett
{
    public partial class frm_AddProducts : FormStyle
    {
        public frm_AddProducts()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pb_Products, "لطفا برای انتخاب عکس کلیک کنید.");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
          
        }

        private void myTextBox3_TextChanged(object sender, EventArgs e)
        {
            // موقعیت فعلی مکان‌نما
            int selectionStart = txt_Price.SelectionStart;
            // حذف جداکننده‌های قبلی
            string plainText = txt_Price.Text.Replace(",", "").Replace(".", "");
            // فرمت هزارگان (اینجا با جداکننده , – می‌تونی Culture رو تغییر بدی)
            if (!long.TryParse(plainText, out long value))
            { }
              
            txt_Price.Text = string.Format("{0:N0}", value);
            // برگرداندن مکان‌نما به جای درست
            txt_Price.SelectionStart = txt_Price.Text.Length;
        }

        private void txt_Price_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)&&
                (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)&&
                (e.KeyCode != Keys.Back))
            {
                e.SuppressKeyPress = true;
            }
        }

       

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void pb_Products_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "انتخاب عکس";
            openFileDialog1.Filter = "Image.JPG|*.jpg|Image.JPEG|*.jpeg|Image.PNG|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                MessageBox.Show("لطفا عکس را درست انتخاب کنید ");
            }
        }
    }
}
