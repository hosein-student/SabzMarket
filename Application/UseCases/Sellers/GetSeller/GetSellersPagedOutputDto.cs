namespace SabzMarket.Application.UseCases.Sellers.GetSeller;

public record GetSellersPagedOutputDto(IReadOnlyList<GetSellerOutputDto> Items, int TotalCount);