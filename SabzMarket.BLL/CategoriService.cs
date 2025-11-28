using SabzMarket.Share;
using SabzMarket.Share.Data;
using SabzMarket.Share.Services;
using SabzMarket.Share.Mappers;
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
        public readonly IErrorService _errorService;
        public CategoriService(ICategorieRepository categorieRepository, IErrorService errorService) 
        {
            _categorieRepository = categorieRepository;
            _errorService = errorService;
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
                var error = result.Exception!.ExceptionToErrorDTO(result.Message!);
                var result1 = await _errorService.LogErrorAsync(error);
                return OperationResult<List<CategorieDTO>>.Failed(result.Message!.ErrorMessage());
            }
            
        }
    }
}
