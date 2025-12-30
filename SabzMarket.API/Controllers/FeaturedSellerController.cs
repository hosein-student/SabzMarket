using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share.Models;
using SabzMarket.Share.ViewModels;

namespace SabzMarket.API.Controllers
{
    public class FeaturedSellerController:BaseController
    {
        private readonly IFeaturedSellerSevice _featuredSellerSevice;
        public FeaturedSellerController(IFeaturedSellerSevice featuredSellerSevice)
        {
            _featuredSellerSevice = featuredSellerSevice;   
        }
        [HttpGet]
        public async Task<OperationResult<List<SellerFullViewModel>>> GetAllSellerAsync()
        {
            var result=await _featuredSellerSevice.GetAllSellerAsync();
            return result;
        }
    }
}
