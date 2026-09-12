namespace SabzMarket.Application.UseCases.Sellers.GetSeller;

public record GetSellerOutputDto(
    long Id,
    long UserId,
    string UserName,
    string FirstName,
    string LastName,
    string? Email,
    string Phone,
    string Address,
    string? ProfileImage,
    string WorkHistory);