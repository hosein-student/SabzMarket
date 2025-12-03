using SabzMarket.Share;
using SabzMarket.Share.Data;
using SabzMarket.Share.Mappers;
using SabzMarket.Share.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.BLL
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IErrorRepository _errorRepository;
        public OrderService(IOrderRepository orderRepository, IErrorRepository errorRepository) 
        {
            _errorRepository = errorRepository;
            _orderRepository = orderRepository;
        }

        public async Task<OperationResult<List<OrderDTO>>> GetOrdersForSellerAsync(long id, bool Pending, string search)
        {
          var result=await _orderRepository.SelectOrdersForSellerAsync(id,Pending,search);
            if (!result.Success)
            {
                var error = result.Exception!.ExceptionToErrorDTO(result.Message!);
                var resultError=await _errorRepository.LogErrorAsync(error);
                return OperationResult<List<OrderDTO>>.Failed(resultError.Message!.ErrorMessage());
            }
            return result;
        }
    }
}
