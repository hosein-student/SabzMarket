namespace SabzMarket.API.Contracts.V1.Farmers.UpdateFarmer;

public record UpdateFarmerRequest(
    long UserId,
    long FarmerId,
    string FirstName,
    string LastName,
    string Email,
    string Phone,
    string CurrentUseName,
    string NewUsername,
    string Address,
    string CodePosti,
    string ProfileImage);