using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IOrderDetailService
    {
        public Task<OperationResult> MarkOrderDetailAsSentAsync(long orderDetaileId);
        public Task<OperationResult> MarkOrderDetailAsRejectedAsync(long orderDetaileId, int number, int productId);
        public Task<OperationResult> InsertAsync(FullCartItemDTO fullCartItemDTOs, long orderId);
    }
}
