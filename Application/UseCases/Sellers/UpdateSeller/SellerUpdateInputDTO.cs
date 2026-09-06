namespace SabzMarket.Application.UseCases.Sellers.UpdateSeller;

public record SellerUpdateInputDto(
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