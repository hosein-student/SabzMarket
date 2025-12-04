using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Data
{
    public interface IOrderRepository
    {
        public Task<OperationResult<List<OrderDTO>>> SelectPendingOrdersForSellerAsync(long id, string search);
        public Task<OperationResult<List<OrderDTO>>> SelectNonPendingOrdersForSellerAsync(long id, string search);
    }
}
