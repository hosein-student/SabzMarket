using SabzMarket.Share;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SabzMarket
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

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            int price, number;
            bool convertPrice = int.TryParse(txt_Price.Text.Replace(",", ""), out price);
            bool convertNumber = int.TryParse(txt_Number.Text.Replace(",", ""), out number);
            ProductViewModel productViewModel = new ProductViewModel
            {
                CategoryId = (long)cmb_Categorie.SelectedValue,
                Description = txt_Description.Text,
                Name = txt_Name.Text,
                Price = price,
                ImageProduct = path
                ,
                Number = number
                ,SellerId=CurrentUser.Id
            };
            if (productViewModel.IsValid)
            {
                var client = HttpClientHelper.Instance;
                var result = await client
                    .PostAsync<OperationResult, ProductViewModel>(RouteConstants.CreateProduct, productViewModel);
                ShowInfo(result.Message!);
            }
            else
            {
                ShowInfo(productViewModel.ErrorMessage);
            }

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
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) &&
                (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) &&
                (e.KeyCode != Keys.Back))
            {
                e.SuppressKeyPress = true;
            }
        }



        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        string path;
        private void pb_Products_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "انتخاب عکس";
            openFileDialog1.Filter = "Image.JPG|*.jpg|Image.JPEG|*.jpeg|Image.PNG|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                pb_Products.ImageLocation = path;
            }
            else
            {
                if (path == null)
                    ShowInfo(Messages.photoNotSelected);
            }
        }

        private async void frm_AddProducts_Load(object sender, EventArgs e)
        {
            var client = HttpClientHelper.Instance;
            var result = await client.GetAsync<OperationResult<List<CategorieDTO>>>(RouteConstants.GetCategori);
            cmb_Categorie.DataSource = result.Data;
            cmb_Categorie.DisplayMember = "Name";
            cmb_Categorie.ValueMember = "Id";
        }

        private void txt_Number_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) &&
                (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) &&
                (e.KeyCode != Keys.Back))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
