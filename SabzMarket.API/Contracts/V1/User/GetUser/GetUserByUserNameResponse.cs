namespace SabzMarket.API.Contracts.V1.Users.GetUser;

public record GetUserByUserNameResponse(
    long Id,
    string UserName,
    string FirstName,
    string LastName,
    string Email,
    string Phone);