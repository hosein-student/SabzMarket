using SabzMarket.Share.Enums;
using SabzMarket.Share.Models;
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
    public partial class UC_HistoryOrders : UserControl
    {
        public OrderDTO order { get; set; }
        public UC_HistoryOrders()
        {
            InitializeComponent();
        }
        public event EventHandler<BuyerDetailsEventArgs> ShowBuyerDetails;
        private void UC_HistoryOrders_Load(object sender, EventArgs e)
        {
            pb_Image.LoadAsync(order.product!.ImageProduct);
            lbl_Name.Text = $"{order.farmer!.FirstName} {order.farmer.LastName}";
            lbl_Number.Text = order.product.Number.ToString();
            lbl_Product.Text = order.product.Name;
            lbl_Status.Text = order.Status==OrderStatus.Sent.ToString()?"ارسال شده":"رد شده";
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            BuyerDetailsEventArgs buyerDetails = new BuyerDetailsEventArgs();
            buyerDetails.FarmerViewModel = order.farmer;
            ShowBuyerDetails?.Invoke(this, buyerDetails);
        }

        private void pb_Image_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                pb_Image.Image = Properties.Resources.DefultProduct;
            }
        }
    }
}
