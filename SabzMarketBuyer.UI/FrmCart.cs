using SabzMarket.Share;
using SabzMarket.Share.Models;
using SabzMarketBuyer.UI.Auth;
using SabzMarketBuyer.UI.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabzMarketBuyer.UI
{
    public partial class FrmCart : FormStyle
    {
        public FrmCart()
        {
            InitializeComponent();
        }
        private void RenderProduct(List<FullCartItemDTO> cart)
        {
            pnlCart.Controls.Clear();
            foreach (var item in cart)
            {
                UCCartProduct uCCartProduct = new UCCartProduct();
                uCCartProduct.DecreaseCart += UCCartProduct_DecreaseCart;
                uCCartProduct.DeleteCart += UCCartProduct_DeleteCart;
                uCCartProduct.CartItemDTo = item;
                pnlCart.Controls.Add(uCCartProduct);
            }
        }

        private async void UCCartProduct_DeleteCart(object? sender, ProductEventArgs<UCCartProduct> e)
        {
            var client = HttpClientHelper.Instance;
            var rout = string.Format(ApiRoutes.RemoveCartItem, e.fullCartItemDTO.Id, e.fullCartItemDTO.ProductId, e.fullCartItemDTO.Quantity);
            var result = await client.GetAsync<OperationResult>(rout);
            if (result == null)
            {
                ShowInfoError(Messages.InternetErrorMessage);
                return;
            }
            if (!result.Success)
            {
                ShowInfoError(result.Message!);
                return;
            }
            ShowInfo(result.Message!);
            pnlCart.Controls.Clear();
            FrmCart_Load(sender, EventArgs.Empty);
        }

        private async void UCCartProduct_DecreaseCart(object? sender, ProductEventArgs<UCCartProduct> e)
        {
            lblTotalAmount.Text = (totalAmount - e.fullCartItemDTO.ProductPrice).ToString();
            lblTotalAmount.Text = totalAmount.ToString("N0");
            var client = HttpClientHelper.Instance;
            var rout = string.Format(ApiRoutes.DecreaseQuantity, e.fullCartItemDTO.ProductId, CurrentUser.FarmerId);
            var result = await client.GetAsync<OperationResult>(rout);
            if (result == null)
            {
                ShowInfoError(Messages.InternetErrorMessage);
                return;
            }
            if (!result.Success)
            {
                ShowInfoError(result.Message!);
                return;
            }
            ShowInfo(result.Message!);
        }
        int totalAmount;
        private async void FrmCart_Load(object sender, EventArgs e)
        {
            var client = HttpClientHelper.Instance;
            var rout = string.Format(ApiRoutes.SelectCartByFarmerId, CurrentUser.FarmerId);
            var result = await client.GetAsync<OperationResult<List<FullCartItemDTO>>>(rout);
            if (result == null)
            {
                ShowInfoError(Messages.InternetErrorMessage);
                return;
            }
            if (!result.Success)
            {
                ShowInfoError(result.Message!);
                return;
            }
            if (result.Data != null && result.Data.Count != 0)
            {
                btnPay.Enabled = true;
                RenderProduct(result.Data);
                totalAmount = result.Data?.Sum(x => x.ProductPrice * x.Quantity) ?? 0;
                lblTotalAmount.Text = totalAmount.ToString("N0");
            }
        }

        private async void btnPay_Click(object sender, EventArgs e)
        {
            var client = HttpClientHelper.Instance;
            var rout = string.Format(ApiRoutes.Checkout, CurrentUser.FarmerId);
            var result = await client.GetAsync<OperationResult>(rout);
            if (result == null)
            {
                ShowInfoError(Messages.InternetErrorMessage);
                return;
            }
            if (!result.Success)
            {
                ShowInfoError(result.Message!);
                return;
            }
            ShowInfo(result.Message!);
            pnlCart.Controls.Clear();
            lblTotalAmount.Text = "0";
            FrmCart_Load(sender, EventArgs.Empty);
        }
    }
}
