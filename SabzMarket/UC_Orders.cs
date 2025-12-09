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
                pb_Image.Image = Properties.Resources.DefultProduct;
            }
        }

        private void UC_Orders_Load(object sender, EventArgs e)
        {
            lbl_Name.Text = $"{OrderDTO.farmer!.FirstName} {OrderDTO.farmer!.LastName}";
            lbl_Number.Text = OrderDTO.product!.Number.ToString();
            lbl_ProductName.Text = OrderDTO.product.Name;
            pb_Image.Load(OrderDTO.product.ImageProduct);
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            BuyerDetailsEventArgs buyerDetails = new BuyerDetailsEventArgs();
            buyerDetails.FarmerViewModel = OrderDTO.farmer;
            ShowBuyerDetails?.Invoke(this, buyerDetails);
        }
        public event EventHandler<OrderDetailEventArgs> RejectOrder;
        public event EventHandler<OrderDetailEventArgs> SentOrder;
        private void btn_Reject_Click(object sender, EventArgs e)
        {
            OrderDetailEventArgs orderDetail = new OrderDetailEventArgs(OrderDTO,this);
            RejectOrder?.Invoke(this, orderDetail);
        }
        public void UpdateStatusUI(string status)
        {
            lbl_Status.Text = status;

            if (status == OrderStatus.Sent.ToString())
            {
                lbl_Status.Text = "ارسال شده";
                lbl_Status.ForeColor = Color.Green;
                btn_Sent.Visible = false;
                btn_Reject.Visible = false;
            }
            else
            {
                lbl_Status.ForeColor = Color.Red;
                lbl_Status.Text = "رد شده";
                btn_Sent.Visible = false;
                btn_Reject.Visible = false;
            }
        }
        private void btn_Sent_Click(object sender, EventArgs e)
        {
            OrderDetailEventArgs orderDetail = new OrderDetailEventArgs(OrderDTO,this);
            SentOrder?.Invoke(this, orderDetail);
        }
    }
}
