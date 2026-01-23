using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        public Task<OperationResult<List<OrderDTO>>> SelectPendingOrdersForSellerAsync(long id, string search);
        public Task<OperationResult<List<OrderDTO>>> SelectNonPendingOrdersForSellerAsync(long id, string search);
        public Task<OperationResult<long>> InsertAsync(FullCartItemDTO fullCartItemDTO);
        public Task<OperationResult<long>> CheckOrderAsync(long farmerId, long SellerId);
    }
}
