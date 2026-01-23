using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface ICategorieRepository
    {
        public Task<OperationResult<List<CategorieDTO>>> SelectAsync();

    }
}
