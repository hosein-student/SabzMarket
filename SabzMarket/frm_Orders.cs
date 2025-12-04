using SabzMarket.Share;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SabzMarket
{
    public partial class frm_Orders : FormStyle
    {
        public frm_Orders()
        {
            InitializeComponent();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            frm_History frm_History = new frm_History();
            frm_History.ShowDialog();
        }
        List<OrderDTO> FullOrsers;
        public async Task GetOrder( string search = "")
        {
            var client = HttpClientHelper.Instance;
            string rout = string
                .Format(RouteConstants
                .GetPendingOrdersForSeller, CurrentUser.Id, Uri.EscapeDataString(search));
            var result = await client.GetAsync<OperationResult<List<OrderDTO>>>(rout);
            if (result == null)
            {
                ShowInfoError(Messages.InternetErrorMessage);
                return;
            }
            if (!result.Success)
            {
                if (!result.Result)
                {
                    ShowInfoError(result.Message!);
                    return;
                }
                ShowInfo(result.Message!);
                return;
            }
                FullOrsers = result.Data;
        }


        private async void frm_Orders_Load(object sender, EventArgs e)
        {
            await GetOrder();
            if (FullOrsers != null)
                RenderOrders(FullOrsers);
        }

        private void Orders_ShowBuyerDetails1(object? sender, BuyerDetailsEventArgs e)
        {
            frm_BuyerDetails frm_BuyerDetails = new frm_BuyerDetails();
            frm_BuyerDetails.farmer = e.FarmerViewModel!;
            frm_BuyerDetails.ShowDialog();
        }


        private void RenderOrders(List<OrderDTO> orders)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var order in orders)
            {
                UC_Orders uC_Orders = new UC_Orders();
                uC_Orders.ShowBuyerDetails += Orders_ShowBuyerDetails1;
                uC_Orders.SentOrder += UC_Orders_SentOrder;
                uC_Orders.RejectOrder += UC_Orders_RejectOrder;
                uC_Orders.OrderDTO = order;
                flowLayoutPanel1.Controls.Add(uC_Orders);
            }
        }

        private async void UC_Orders_RejectOrder(object? sender, OrderDetailEventArgs e)
        {
            var client = HttpClientHelper.Instance;
            string rout = string.Format(RouteConstants.OrderDetailRejected, e.Id);
            var result = await client.GetAsync<OperationResult>(rout);
            if (!result.Success)
            {
                if (!result.Result)
                {
                    ShowInfoError(result.Message!);
                    return;
                }
                ShowInfo(result.Message!);
                return;
            }
            ShowInfo(result.Message!);
            e.C_Orders.UpdateStatusUI(OrderStatus.Rejected.ToString());

        }

        private async void UC_Orders_SentOrder(object? sender, OrderDetailEventArgs e)
        {
            var client = HttpClientHelper.Instance;
            string rout = string.Format(RouteConstants.OrderDetailSent, e.Id);
            var result = await client.GetAsync<OperationResult>(rout);
            if (!result.Success)
            {
                if (!result.Result)
                {
                    ShowInfoError(result.Message!);
                    return;
                }
                ShowInfo(result.Message!);
                return;
            }
            ShowInfo(result.Message!);
            e.C_Orders.UpdateStatusUI(OrderStatus.Sent.ToString());
        }

        private async void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                await GetOrder();
                if (FullOrsers != null)
                    RenderOrders(FullOrsers);
            }
            else
            {
                if (FullOrsers != null)
                {
                    RenderOrders(FullOrsers
                        .Where(o => o
                        .product!
                        .Name!
                        .Contains(txt_Search.Text) || o
                        .farmer!
                        .FirstName!
                        .Contains(txt_Search.Text) || o
                        .farmer
                        .LastName!
                        .Contains(txt_Search.Text))
                        .ToList());
                }
            }
        }
    }
}
