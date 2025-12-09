using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share.Models;
using System.Buffers.Text;

namespace SabzMarket.API.Controllers
{
    public class ErrorController:BaseController
    {
        public readonly IErrorService _errorService;
        public ErrorController(IErrorService errorService) 
        {
            _errorService = errorService;
        }
        [HttpPost]
        public async Task<OperationResult> LogErrorAsync([FromBody]ErrorLogDTO error)
        {
            var result=await _errorService.LogErrorAsync(error);
            return result;
        }
    }
}
