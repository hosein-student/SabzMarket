using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface ICartItemService
    {
        public Task<OperationResult> AddToCartAsync(CartItemDTO cartItemDTO);
        public Task<OperationResult> DecreaseQuantityAsync(long productId,long farmerId);
        public Task<OperationResult> DeleteAsync(int cartId,long productId,int productNumber);
        public Task<OperationResult<List<FullCartItemDTO>>> GetByFarmerIdAsync(long farmerId);
        public Task<OperationResult> DeleteAfterCheckoutAsync(int cartId);
    }
}
