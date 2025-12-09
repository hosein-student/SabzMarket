using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using SabzMarket.Share;
using SabzMarket.Share.ErrorHandling;
using SabzMarket.Share.Mappers;
using SabzMarket.Share.Models;
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
        private readonly IErrorService _errorService;
        public OrderService(IOrderRepository orderRepository, IErrorService errorService) 
        {
            _errorService = errorService;
            _orderRepository = orderRepository;
        }

        public async Task<OperationResult<List<OrderDTO>>> GetNonPendingOrdersForSellerAsync(long id, string search)
        {
            var result = await _orderRepository.SelectNonPendingOrdersForSellerAsync(id, search);
            if (!result.Success)
            {
                var error = result.Exception!.ExceptionToErrorDTO(result.Message!);
                var resultError = await _errorService.LogErrorAsync(error);
                return OperationResult<List<OrderDTO>>.Failed(resultError.Message!.ErrorMessage());
            }
            if (result.Data == null)
            {
                return OperationResult<List<OrderDTO>>.FailedResult(Messages.NullOrder);
            }
            return result;
        }

        public async Task<OperationResult<List<OrderDTO>>> GetPendingOrdersForSellerAsync(long id, string search)
        {
          var result=await _orderRepository.SelectPendingOrdersForSellerAsync(id,search);
            if (!result.Success)
            {
                var error = result.Exception!.ExceptionToErrorDTO(result.Message!);
                var resultError=await _errorService.LogErrorAsync(error);
                return OperationResult<List<OrderDTO>>.Failed(resultError.Message!.ErrorMessage());
            }
            if (result.Data == null)
            {
                return OperationResult<List<OrderDTO>>.FailedResult(Messages.NullOrder);
            }
            return result;
        }
    }
}
