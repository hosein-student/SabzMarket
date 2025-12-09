using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share.Models;

namespace SabzMarket.API.Controllers
{
    public class CategoriController : BaseController
    {
        public readonly ICategoriService _categoriService;
        public CategoriController(ICategoriService categoriService) 
        {
            _categoriService = categoriService;
        }
        [HttpGet]
        public async Task <OperationResult<List<CategorieDTO>>> GetAllCategoriesAsync()
        {
             var result= await _categoriService.GetAllCategoriesAsync();
            return result;
        }


    }
}
