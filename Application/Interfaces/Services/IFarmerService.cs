using SabzMarket.Share.Models;
using SabzMarket.Share.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IFarmerService
    {
        public Task<OperationResult> CheckUserExistsInFarmerAsync(string username);
        public Task<OperationResult> CreateFarmerAsync(string username, FarmerPartiaViewModel farmer);
        Task<OperationResult<FarmerDTO>> GetByUsernameAsync(string username);
        public Task<OperationResult> UpdateAsync(FarmerFullViweModel farmerViewModel,string username);
    }
}
