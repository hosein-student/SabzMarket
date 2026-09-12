namespace SabzMarket.Application.UseCases.Sellers.GetSeller;

public interface IGetSellerByIdUseCase
{
    Task<GetSellerOutputDto> ExecuteAsync(long id, CancellationToken token);
}