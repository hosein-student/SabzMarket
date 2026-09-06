namespace SabzMarket.API.Contracts.V1.Sellers.UpdateSeller;

public record UpdateSellerRequest(
    long Id,
    long UserId,
    string FirstName,
    string LastName,
    string Email,
    string Phone,
    string CurrentUsername,
    string NewUsername,
    string Address,
    string ProfileImage,
    string WorkHistory);