using Application.Interfaces.Services;
using SabzMarket.Application.Interfaces.Repository;
using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.BLL
{
    public class ErrorService : IErrorService
    {
        public readonly IErrorRepository _errorRepository;
        public ErrorService(IErrorRepository errorRepository) 
        {
            _errorRepository = errorRepository;
        }
        public async Task<OperationResult> LogErrorAsync(ErrorLogDTO error)
        {
           var result= await _errorRepository.LogErrorAsync(error);
            return result;
        }
    }
}
