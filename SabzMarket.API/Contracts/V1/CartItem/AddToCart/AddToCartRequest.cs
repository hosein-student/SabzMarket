namespace SabzMarket.API.Contracts.V1.CartItems.AddToCart;

public record AddToCartRequest(long FarmerId, long ProductId, int Quantity, DateTime AddedDate);