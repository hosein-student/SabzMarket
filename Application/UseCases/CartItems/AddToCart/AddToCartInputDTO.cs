namespace SabzMarket.Application.UseCases.CartItems.AddToCart;

public record AddToCartInputDto(long FarmerId, long ProductId, int Quantity, DateTime AddedDate);