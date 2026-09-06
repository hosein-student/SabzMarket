namespace SabzMarket.Application.UseCases.Farmers.GetFarmer;

public record GetFarmerByUsernameOutputDto(
    long Id,
    long UserId,
    string Username,
    string Address,
    string CodePosti,
    string CodParvaneBhb,
    string DataBuilt,
    int LandArea,
    string NationalCode,
    string ProfileImage,
    string Email,
    string FirstName,
    string LastName,
    string Phone);