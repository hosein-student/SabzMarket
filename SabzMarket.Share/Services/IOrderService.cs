using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Services
{
    public interface IOrderService
    {
        public Task<OperationResult<List<OrderDTO>>> GetPendingOrdersForSellerAsync(long id, string search);
        public Task<OperationResult<List<OrderDTO>>> GetNonPendingOrdersForSellerAsync(long id, string search);
    }
}

