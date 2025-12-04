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
    public partial class frm_History : FormStyle
    {
        public frm_History()
        {
            InitializeComponent();
        }

        private void RenderOrders(List<OrderDTO> orders)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var order in orders)
            {
                UC_HistoryOrders uC_History = new UC_HistoryOrders();
                uC_History.order = order;
                uC_History.ShowBuyerDetails += UC_History_ShowBuyerDetails;
                flowLayoutPanel1.Controls.Add(uC_History);
            }
        }

        private void UC_History_ShowBuyerDetails(object? sender, BuyerDetailsEventArgs e)
        {
            frm_BuyerDetails frm_BuyerDetails = new frm_BuyerDetails();
            frm_BuyerDetails.farmer = e.FarmerViewModel!;
            frm_BuyerDetails.ShowDialog();
        }

        List<OrderDTO> FullOrsers;
        public async Task GetOrder(string search = "")
        {
            var client = HttpClientHelper.Instance;
            string rout = string
                .Format(RouteConstants
                .GetNonPendingOrdersForSeller, CurrentUser.Id, Uri.EscapeDataString(search));
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
        private async void frm_History_Load(object sender, EventArgs e)
        {
            await GetOrder();
            if (FullOrsers != null)
                RenderOrders(FullOrsers);
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
