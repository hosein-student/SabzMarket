using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share.Models;

namespace SabzMarket.API.Controllers
{
    public class CartItemController : BaseController
    {
        private readonly ICartItemService _cartItemService;
        public CartItemController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;

        }
        [HttpPost]
        public async Task<OperationResult> AddToCartAsync(CartItemDTO cartItemDTO)
        {
            var result = await _cartItemService.AddToCartAsync(cartItemDTO);
            return result;
        }
        [HttpGet]
        public async Task<OperationResult> DecreaseQuantityAsync(long productId, long farmerId)
        {
            var result = await _cartItemService.DecreaseQuantityAsync(productId, farmerId);
            return result;
        }
        [HttpGet]
        public async Task<OperationResult> DeleteAsync(int cartId, long productId, int productNumber)
        {
            var result = await _cartItemService.DeleteAsync(cartId, productId, productNumber);
            return result;
        }
        [HttpGet]
        public Task<OperationResult<List<FullCartItemDTO>>> GetByFarmerIdAsync(long farmerId)
        {
            var result=_cartItemService.GetByFarmerIdAsync(farmerId);
            return result;
        }



    }
}
