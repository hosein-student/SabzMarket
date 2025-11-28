using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share
{
    public class RouteConstants
    {
        public const string BaseUrl = "https://localhost:7267/";
        public const string SignUp = "User/SignUp";
        public const string Login = "User/Login";
        public const string SellerFillProfile = "Seller/FillProfile";
        public const string CheckUserInSeller = "Seller/CheckUserInSeller?username={0}";
        public const string GetSellerByUsername = "Seller/GetSellerByUsername?username={0}";
        public const string UpdateSeller = "Seller/Update?username={0}";
        public const string GetCategori = "Categori/GetAllCategories";
        public const string CreateProduct = "Product/CreateProduct";
        public const string GetUser = "User/GetUser?username={0}";
        public const string LogError = "Error/LogError";
    }
}
