using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share;
using SabzMarket.Share.Services;

namespace SabzMarket.API.Controllers
{
    public class ProductController:BaseController
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
    }
}

