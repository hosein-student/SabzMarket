namespace SabzMarket.API.Contracts.V1.Products.CreateProduct;

public record CreateProductRequest(
    long SellerId,
    long CategoryId,
    string Name,
    string Description,
    int Price,
    int Number,
    string ImageProduct);