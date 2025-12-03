using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Data
{
    public interface IOrderRepository
    {
        public Task<OperationResult<List<OrderDTO>>> SelectOrdersForSellerAsync(long id, bool Pending, string search);
    }
}
