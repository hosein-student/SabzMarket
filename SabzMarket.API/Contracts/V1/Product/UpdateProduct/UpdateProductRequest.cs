namespace SabzMarket.API.Contracts.V1.Products.UpdateProduct;

public record UpdateProductRequest(
    long Id,
    long CategoryId,
    long SellerId,
    string Name,
    string De,
    string? Description,
    int Price,
    int Number,
    string ImageProduct);