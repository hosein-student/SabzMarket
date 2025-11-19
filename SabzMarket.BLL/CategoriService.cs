using SabzMarket.Share;
using SabzMarket.Share.Data;
using SabzMarket.Share.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.BLL
{
    public class CategoriService : ICategoriService
    {
        public readonly ICategorieRepository _categorieRepository;
        public readonly IErrorRepository _errorRepository;
        public CategoriService(ICategorieRepository categorieRepository, IErrorRepository errorRepository) 
        {
            _categorieRepository = categorieRepository;
            _errorRepository = errorRepository;
        }
        public async Task<OperationResult<List<CategorieDTO>>> GetAllCategoriesAsync()
        {
            var result = await _categorieRepository.SelectAsync();
            if (result.Success)
            {
                return result;
            }
            else
            {
                var result1 = await _errorRepository.LogErrorAsync(result.Exception, result.Message);
                return OperationResult<List<CategorieDTO>>.Failed(result.Message.ErrorMessage());
            }
            
        }
    }
}
