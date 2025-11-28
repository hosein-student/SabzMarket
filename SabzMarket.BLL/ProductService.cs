using SabzMarket.Share;
using SabzMarket.Share.Data;
using SabzMarket.Share.Mappers;
using SabzMarket.Share.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.BLL
{
    public class ProductService:IProductService
    {
       private readonly IErrorService _errorService;
        private readonly IProductRepository _productRepository;
        public ProductService(IErrorService errorService, IProductRepository productRepository) 
        {
            _errorService = errorService;
            _productRepository = productRepository;
        }

        public async Task<OperationResult> CreateProductAsync(ProductViewModel product)
        {
            if (!product.IsValid)
                return OperationResult.Failed(product.ErrorMessage);
            using var savePhoto = new SavePhoto();
            var result2 = await savePhoto.SaveAsync(product.ImageProduct);
            if (!result2.Success)
            {
                var error = result2.Exception.ExceptionToErrorDTO(result2.Message);
                var result1 = await _errorService.LogErrorAsync(error);
                return OperationResult.Failed(result1.Message.ErrorMessage());
            }
            product.ImageProduct = result2.Message;
            ProductDTO productDTO = product.ToProductDTO();
            var result=await _productRepository.InsertAsync(productDTO);
            if(!result.Success)
            {
                var error = result.Exception.ExceptionToErrorDTO(result.Message);
                var result1 = await _errorService.LogErrorAsync(error);
                return OperationResult.Failed(result1.Message.ErrorMessage());
            }
                return OperationResult.Successed(true, Messages.ProductAdded);
            
            
        }
    }
}
