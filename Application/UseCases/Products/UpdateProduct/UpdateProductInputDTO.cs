namespace SabzMarket.Application.UseCases.Products.UpdateProduct;

public record UpdateProductInputDto(
    long Id,
    long CategoryId,
    long SellerId,
    string Name,
    string De,
    string? Description,
    int Price,
    int Number,
    string ImageProduct);