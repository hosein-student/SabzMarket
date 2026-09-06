namespace SabzMarket.API.Contracts.V1.Sellers.CreateSeller;

public record CreateSellerRequest(long Id, string Username, string Address, string ProfileImage, string WorkHistory);