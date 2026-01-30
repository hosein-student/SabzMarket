using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface ICartItemRepository
    {
        public Task<OperationResult> InsertAsync(CartItemDTO cartItemDTO);
        public Task<OperationResult> ChangeQuantityAsync(long productId,long farmerId, int number);
        public Task<OperationResult> DeleteAsync(int cartId);
        public Task<OperationResult> ExistProductAsync(long farmerId,long productId);
        public Task<OperationResult> IsCartItemQuantityOneAsync(int id);
        public Task<OperationResult<List<FullCartItemDTO>>> SelectByFarmerIdAsync(long farmerId);
    }
}
