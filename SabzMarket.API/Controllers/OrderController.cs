using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share.Models;

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
        [HttpGet]
        public async Task<OperationResult> CheckoutAsync(long farmerId)
        {
           var result=await _orderService.CheckoutAsync(farmerId);
            return result;  
        }
    }
}
