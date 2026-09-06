namespace SabzMarket.API.Contracts.V1.Farmers.GetFarmer;

public record GetFarmerByUserNameResponse(
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