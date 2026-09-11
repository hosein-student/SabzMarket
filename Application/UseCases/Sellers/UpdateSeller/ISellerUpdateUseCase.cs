namespace SabzMarket.Application.UseCases.Sellers.UpdateSeller;

public interface ISellerUpdateUseCase
{
    Task ExecuteAsync(SellerUpdateInputDto updateSellerInputDto, Stream stream,
        CancellationToken token);
}