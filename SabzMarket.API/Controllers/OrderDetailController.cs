using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share;
using SabzMarket.Share.Services;

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
        public async Task<OperationResult> MarkOrderDetailAsRejectedAsync(long orderDetaileId)
        {
          var result=await _orderDetailService.MarkOrderDetailAsRejectedAsync(orderDetaileId);
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
