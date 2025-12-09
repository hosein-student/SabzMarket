using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share.Models;
using SabzMarket.Share.ViewModels;

namespace SabzMarket.API.Controllers
{
    public class ProductController : BaseController
    {
        public readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public async Task<OperationResult> CreateProductAsync([FromBody] ProductViewModel product)
        {
            var result = await _productService.CreateProductAsync(product);
            return result;
        }
        [HttpGet]
        public async Task<OperationResult<List<ProductDTO>>> GetProductsBySellerAsync(long sellerId)
        {
            var result = await _productService.GetProductsBySellerAsync(sellerId);
            return result;
        }
        [HttpGet]
        public async Task<OperationResult> DeleteAsync(long id)
        {
            var result = await _productService.DeleteAsync(id);
            return result;
        }
        [HttpPost]
        public async Task<OperationResult> UpdateAsync([FromBody] ProductViewModel product)
        {
            var result = await _productService.UpdateAsync(product);
            return result;
        }

    }
}

