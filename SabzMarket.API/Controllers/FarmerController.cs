using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share.Models;
using SabzMarket.Share.ViewModels;

namespace SabzMarket.API.Controllers
{
    public class FarmerController:BaseController
    {
        private readonly IFarmerService _farmerService;
        public FarmerController(IFarmerService farmerService) 
        {
            _farmerService = farmerService;
        }
        [HttpGet]
        public async Task<OperationResult> CheckUserExistsInFarmerAsync(string username)
        {
            var result = await _farmerService.CheckUserExistsInFarmerAsync(username);
            return result;
        }
        [HttpPost]
        public async Task<OperationResult> CreateFarmerAsync(string username, [FromBody]FarmerPartiaViewModel farmer)
        {
            var result=await _farmerService.CreateFarmerAsync(username, farmer);
            return result;
        }
        [HttpGet]
       public async Task<OperationResult<FarmerDTO>> GetByUsernameAsync(string username)
        {
            var result=await _farmerService.GetByUsernameAsync(username);
            return result;
        }
        [HttpPost]
        public async Task<OperationResult> UpdateAsync([FromBody]FarmerFullViweModel farmerViewModel,string username)
        {
            var result=await _farmerService.UpdateAsync(farmerViewModel,username);
            return result;
        }

    }
}
