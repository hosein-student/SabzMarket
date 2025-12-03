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
    public partial class UC_Orders : UserControl
    {
        public UC_Orders()
        {
            InitializeComponent();
        }
        public OrderDTO OrderDTO { get; set; }
        public event EventHandler<BuyerDetailsEventArgs> ShowBuyerDetails;
        private void pb_Image_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //ShowInfo("عکس بارگذاری نشد");
                //pb_Profile.Image = Properties.Resources.profile;
            }
        }

        private void UC_Orders_Load(object sender, EventArgs e)
        {
            //
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            BuyerDetailsEventArgs buyerDetails = new BuyerDetailsEventArgs();
            buyerDetails.FarmerViewModel = OrderDTO.farmer;
            ShowBuyerDetails?.Invoke(this, buyerDetails);
        }
    }
}
