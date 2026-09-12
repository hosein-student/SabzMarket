namespace SabzMarket.Application.UseCases.Sellers.GetSeller;

public interface ISearchSellersUseCase
{
    Task<GetSellersPagedOutputDto> ExecuteAsync(SearchSellerFilterInputDto inputDto, CancellationToken token);
}