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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IErrorService _errorService;
        public OrderDetailService(IOrderDetailRepository orderDetailRepository, IErrorService errorService)
        {
            _orderDetailRepository = orderDetailRepository;
            _errorService = errorService;
        }
        public async Task<OperationResult> MarkOrderDetailAsRejectedAsync(long orderDetaileId)
        {
            var result = await _orderDetailRepository.SetOrderDetailStatusToRejectedAsync(orderDetaileId);
            if (!result.Success)
            {
                var error = result.Exception!.ExceptionToErrorDTO(result.Message!);
                var errorResult = await _errorService.LogErrorAsync(error);
                return OperationResult.Failed(errorResult.Message!.ErrorMessage());
            }
            return OperationResult.SuccessedResult(true, Messages.RejectedOrder);

        }

        public async Task<OperationResult> MarkOrderDetailAsSentAsync(long orderDetaileId)
        {
            var result = await _orderDetailRepository.SetOrderDetailStatusToSentAsync(orderDetaileId);
            if (!result.Success)
            {
                var error = result.Exception!.ExceptionToErrorDTO(result.Message!);
                var errorResult = await _errorService.LogErrorAsync(error);
                return OperationResult.Failed(errorResult.Message!.ErrorMessage());
            }
            return OperationResult.SuccessedResult(true, Messages.SentOrder);
        }
    }
}
