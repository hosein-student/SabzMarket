using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share;
using SabzMarket.Share.Services;

namespace SabzMarket.API.Controllers
{
    public class SellerController:BaseController
    {
        private readonly ISellerService _sellerService;
        public SellerController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }
        [HttpPost]
        public async Task<OperationResult> FillProfile([FromBody]SellerPartialViewModel sellerViewMode2)
        {
            var result=await _sellerService
                .FillProfileAsync(sellerViewMode2);
            return result;
        }
        [HttpGet]
        public async Task<OperationResult> CheckUserInSellerAsync(string username)
        {
           var result=await _sellerService
                .CheckUserExistsInSellerAsync(username);
            return result;
        }
        [HttpGet]
        public async Task<OperationResult<SellerFullViewModel>> GetSellerByUsernameAsync(string username)
        {
            var result=await _sellerService.GetSellerByUsernameAsync(username);
            return result;

        }
        [HttpPost]
        public async Task<OperationResult> UpdateAsync(string username, [FromBody]RequestPayload requestPayload)
        {
           var result=await _sellerService.UpdateAsync(username, requestPayload.UserViewModel , requestPayload.SellerPartial);
            return result;
        }
    }
}
