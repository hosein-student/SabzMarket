using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SabzMarket.Share.Mappers
{
    public static class ProductMapper
    {
        public static ProductDTO ToProductDTO(this ProductViewModel product)
        {
            return new ProductDTO
            {
                CategoryId = product.CategoryId,
                Description = product.Description,
                Id = product.Id,
                ImageProduct = product.ImageProduct,
                Name = product.Name,
                Number = product.Number,    
                Price = product.Price,
                SellerId = product.SellerId 
            };
        }
        public static ProductViewModel ToProductViewModel(this ProductDTO product)
        {
            return new ProductViewModel
            {
                CategoryId = product.CategoryId,
                Description = product.Description,
                Id = product.Id,
                ImageProduct = product.ImageProduct,
                Name = product.Name,
                Number = product.Number,
                Price = product.Price,
                SellerId = product.SellerId
            };
        }
    }
}
