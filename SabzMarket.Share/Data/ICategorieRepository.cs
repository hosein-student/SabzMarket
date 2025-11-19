using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Data
{
    public interface ICategorieRepository
    {
        public Task<OperationResult<List<CategorieDTO>>> SelectAsync();

    }
}
