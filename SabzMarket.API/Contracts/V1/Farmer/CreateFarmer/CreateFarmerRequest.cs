namespace SabzMarket.API.Contracts.V1.Farmers.CreateFarmer;

public record CreateFarmerRequest(
    string Address,
    string DataBuilt,
    int LandArea,
    string NationalCode,
    string CodParvaneBhb,
    string ProfileImage,
    string CodePosti);