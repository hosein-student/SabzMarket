using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share
{
    public class ApiRoutes
    {
        public const string SignUp = "User/SignUp";
        public const string Login = "User/Login";
        public const string SellerFillProfile = "Seller/CreateSelller";
        public const string CheckUserInSeller = "Seller/CheckUserInSeller?username={0}";
        public const string GetSellerByUsername = "Seller/GetSellerByUsername?username={0}";
        public const string UpdateSeller = "Seller/Update?username={0}";
        public const string GetCategori = "Categori/GetAllCategories";
        public const string CreateProduct = "Product/CreateProduct";
        public const string GetUser = "User/GetUser?username={0}";
        public const string LogError = "Error/LogError";
        public const string GetPendingOrdersForSeller = "Order/GetPendingOrdersForSeller?id={0}&search={1}";
        public const string GetNonPendingOrdersForSeller = "Order/GetNonPendingOrdersForSeller?id={0}&search={1}";
        public const string OrderDetailRejected = "OrderDetail/MarkOrderDetailAsRejected?orderDetaileId={0}&number={1}&productId={2}";
        public const string OrderDetailSent = "OrderDetail/MarkOrderDetailAsSent?orderDetaileId={0}";
        public const string GetProductBySellerId = "Product/GetProductsBySeller?sellerId={0}";
        public const string DeleteProduct = "Product/Delete?id={0}";
        public const string UpdateProduct = "Product/Update";
        //================================================================
        public const string CheckUserInFarmer = "Farmer/CheckUserExistsInFarmer?username={0}";
        public const string CreateFarmer = "Farmer/CreateFarmer?username={0}";
        public const string GetFarmerFullByUsername = "Farmer/GetByUsername?username={0}";
        public const string UpdateFarmer = "Farmer/Update?username={0}";
    }
}
