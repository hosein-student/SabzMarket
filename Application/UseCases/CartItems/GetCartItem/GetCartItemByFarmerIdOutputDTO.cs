namespace SabzMarket.Application.UseCases.CartItems.GetCartItem;

public record GetCartItemByFarmerIdOutputDto(
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