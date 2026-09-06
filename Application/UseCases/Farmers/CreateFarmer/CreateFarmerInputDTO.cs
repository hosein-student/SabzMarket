namespace SabzMarket.Application.UseCases.Farmers.CreateFarmer;

public record CreateFarmerInputDto(
    string Address,
    string DataBuilt,
    int LandArea,
    string NationalCode,
    string CodParvaneBhb,
    string ProfileImage,
    string CodePosti);