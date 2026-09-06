namespace SabzMarket.Application.UseCases.Products.GetProduct;

public record GetProductOutputDto(
    long Id,
    long SellerId,
    long CategoryId,
    string Name,
    string Description,
    int Number,
    int Price,
    string ImageProduct);