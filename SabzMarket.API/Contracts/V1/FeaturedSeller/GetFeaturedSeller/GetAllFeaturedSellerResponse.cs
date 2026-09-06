namespace SabzMarket.API.Contracts.V1.FeaturedSellers.GetFeaturedSeller;

public record GetAllFeaturedSellerResponse(
    long SellerId,
    long UserId,
    string ProfileImage,
    string FirstName,
    string LastName);