namespace SabzMarket.Application.UseCases.Users.GetUser;

public record GetUserByUserNameOutputDto(
    long Id,
    string? UserName,
    string FirstName,
    string LastName,
    string? Email,
    string Phone);