using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share.Models;

namespace SabzMarket.API.Controllers
{
    public class OrderDetailController:BaseController
    {
        private readonly IOrderDetailService _orderDetailService;
        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }
        [HttpGet]
        public async Task<OperationResult> MarkOrderDetailAsRejectedAsync(long orderDetaileId, int number, int productId)
        {
          var result=await _orderDetailService.MarkOrderDetailAsRejectedAsync(orderDetaileId,number,productId);
            return result;
        }
        [HttpGet]
        public async Task<OperationResult> MarkOrderDetailAsSentAsync(long orderDetaileId)
        {
            var result = await _orderDetailService.MarkOrderDetailAsSentAsync(orderDetaileId);
            return result;
        }
    }
}
