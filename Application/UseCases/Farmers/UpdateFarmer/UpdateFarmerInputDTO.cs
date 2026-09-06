namespace SabzMarket.Application.UseCases.Farmers.UpdateFarmer;

public record UpdateFarmerInputDto(
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