using Microsoft.EntityFrameworkCore;
using SabzMarket.DAL.Entities;
using SabzMarket.Share;
using SabzMarket.Share.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.DAL
{
    public class CategorieRepository : ICategorieRepository
    {
        public readonly SabzMarketDbContext _context;
        public CategorieRepository(SabzMarketDbContext context) 
        {
            _context = context;
        }
        async Task<OperationResult<List<CategorieDTO>>> ICategorieRepository.SelectAsync()
        {
            try
            {
                var result = await _context.Categories.Select(x => new CategorieDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                }).ToListAsync();
                return OperationResult<List<CategorieDTO>>.SuccessedResult(result);
            }
            catch (Exception ex)
            {
                return OperationResult<List<CategorieDTO>>.Failed(GetType().Name, ex);
            }
            
        }
    }
}
