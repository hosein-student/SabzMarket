using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Services
{
    public interface IOrderService
    {
        public Task<OperationResult<List<OrderDTO>>>GetOrdersForSellerAsync(long id, bool Pending, string search);
    }
}
