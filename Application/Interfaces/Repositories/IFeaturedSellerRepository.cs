using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IFeaturedSellerRepository
    {
        public Task<OperationResult<List<SellerDTO>>> SelectAllSellerAsync();
    }
}
