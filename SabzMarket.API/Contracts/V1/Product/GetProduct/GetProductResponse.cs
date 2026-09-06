namespace SabzMarket.API.Contracts.V1.Products.GetProduct;

public record GetProductResponse(
    long Id,
    long SellerId,
    long CategoryId,
    string Name,
    string Description,
    int Number,
    int Price,
    string ImageProduct);