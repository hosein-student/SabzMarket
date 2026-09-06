namespace SabzMarket.API.Contracts.V1.Sellers.GetSeller;

public record GetSellerResponse(
    long Id,
    long UserId,
    string UserName,
    string FirstName,
    string LastName,
    string Email,
    string Phone,
    string Address,
    string ProfileImage,
    string WorkHistory);