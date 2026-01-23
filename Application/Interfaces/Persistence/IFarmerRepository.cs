using SabzMarket.Share.Models;
using SabzMarket.Share.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IFarmerRepository
    {
        public Task<OperationResult> UserExistsInFarmerAsync(string username);
        public Task<OperationResult> InsertAsync(string username,FarmerDTO farmer);
        public Task<OperationResult<FarmerDTO>> SelectByUsernameAsync(string username);
        public Task<OperationResult> UpdateAsync(FarmerDTO farmerDTO);
    }
}
