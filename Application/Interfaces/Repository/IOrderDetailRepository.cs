using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Application.Interfaces.Repository
{
    public interface IOrderDetailRepository
    {
        public Task<OperationResult> SetOrderDetailStatusToSentAsync(long orderDetile);
        public Task<OperationResult> SetOrderDetailStatusToRejectedAsync(long orderDetile);
        public Task<OperationResult> HasPendingOrdersForProductAsync(long productId);
        public Task<OperationResult> InsertAsync(FullCartItemDTO fullCartItemDTOs,long orderId);
    }
}
