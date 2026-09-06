namespace SabzMarket.API.Contracts.V1.CartItems.GetCartItem;

public record GetCartItemByFarmerIdResponse(
    int Id,
    long OrderId,
    long FarmerId,
    long SellerId,
    long ProductId,
    int Quantity,
    DateTime AddedDate,
    string ProductImage,
    string ProductName,
    int ProductPrice,
    int ProductNumber);