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
        public async Task<OperationResult<List<OrderDTO>>> GetOrdersForSellerAsync(long id, bool Pending, string search)
        {
          var result=await  _orderService.GetOrdersForSellerAsync(id,Pending,search);
            return result;
        }
    }
}
