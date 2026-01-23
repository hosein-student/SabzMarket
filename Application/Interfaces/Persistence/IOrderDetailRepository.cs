using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IOrderDetailRepository
    {
        public Task<OperationResult> SetOrderDetailStatusToSentAsync(long orderDetile);
        public Task<OperationResult> SetOrderDetailStatusToRejectedAsync(long orderDetile);
        public Task<OperationResult> HasPendingOrdersForProductAsync(long productId);
        public Task<OperationResult> InsertAsync(FullCartItemDTO fullCartItemDTOs,long orderId);
    }
}
