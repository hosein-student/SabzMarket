using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Application.Interfaces.Repository
{
    public interface IFeaturedSellerRepository
    {
        public Task<OperationResult<List<SellerDTO>>> SelectAllSellerAsync();
    }
}
