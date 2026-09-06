namespace SabzMarket.Application.UseCases.FeaturedSellers.GetFeaturedSeller;

public record GetAllFeaturedSellerOutputDto(
    long SellerId,
    long UserId,
    string ProfileImage,
    string FirstName,
    string LastName);