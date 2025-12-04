using Microsoft.EntityFrameworkCore;
using SabzMarket.Share;
using SabzMarket.Share.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.DAL
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly SabzMarketDbContext _context;
        public OrderDetailRepository(SabzMarketDbContext context)
        {
            _context = context;
        }

        public async Task<OperationResult> SetOrderDetailStatusToRejectedAsync(long orderDetaileId)
        {
            try
            {
                var result = await _context.OrderDetails
                    .Where(o => o.Id == orderDetaileId)
                    .SingleAsync();
                result!.Status = OrderStatus.Rejected.ToString();
                _context.SaveChanges();
                return OperationResult.SuccessedResult();
            }
            catch (Exception ex)
            {
                return OperationResult.Failed(GetType().Name,ex);
            }
        }

        public async Task<OperationResult> SetOrderDetailStatusToSentAsync(long orderDetaileId)
        {
            try
            {
                var result = await _context.OrderDetails
                    .Where(o => o.Id == orderDetaileId)
                    .SingleAsync();
                result!.Status = OrderStatus.Sent.ToString();
                _context.SaveChanges();
                return OperationResult.SuccessedResult();
            }
            catch (Exception ex)
            {
                return OperationResult.Failed(GetType().Name, ex);
            }
        }
    }
}
