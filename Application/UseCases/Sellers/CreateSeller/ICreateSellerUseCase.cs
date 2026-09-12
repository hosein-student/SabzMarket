using SabzMarket.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Application.UseCases.Sellers.CreateSeller
{
    public interface ICreateSellerUseCase
    {
        Task ExecuteAsync(CreateSellerInputDto sellerInputDto, string fileName, Stream stream, CancellationToken token);
    }
}