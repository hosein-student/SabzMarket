using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share;
using SabzMarket.Share.Services;

namespace SabzMarket.API.Controllers
{
    public class OrderController:BaseController
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService=orderService;
        }
        [HttpGet]
        public async Task<OperationResult<List<OrderDTO>>> GetPendingOrdersForSellerAsync(long id, string search)
        {
          var result=await  _orderService.GetPendingOrdersForSellerAsync(id,search);
            return result;
        }
        [HttpGet]
        public async Task<OperationResult<List<OrderDTO>>> GetNonPendingOrdersForSellerAsync(long id, string search)
        {
            var result = await _orderService.GetNonPendingOrdersForSellerAsync(id, search);
            return result;
        }
    }
}
