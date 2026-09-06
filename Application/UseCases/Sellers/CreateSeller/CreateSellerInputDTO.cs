namespace SabzMarket.Application.UseCases.Sellers.CreateSeller;

public record CreateSellerInputDto(long Id, string Username, string Address, string ProfileImage, string WorkHistory);