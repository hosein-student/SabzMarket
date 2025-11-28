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
    public class ProductRepository : IProductRepository
    {
        private readonly SabzMarketDbContext _Context;
        public ProductRepository(SabzMarketDbContext context) 
        {
            _Context = context;
        }
        public async Task<OperationResult> InsertAsync(ProductDTO product)
        {
            try
            {
                Product product1 = new Product
                {
                    CategorieId = product.CategoryId,
                    Description = product.Description,
                    ImageProduct = product.ImageProduct
               ,
                    Price = product.Price,
                    Number = product.Number,
                    ProductName = product.Name,
                    SellerId = product.SellerId,
                };
                _Context.Products.Add(product1);
                await _Context.SaveChangesAsync();
                return OperationResult.Successed();
            }
            catch (Exception ex)
            {
                return OperationResult.Failed(GetType().Name, ex);
            }

           

        }
    }
}
