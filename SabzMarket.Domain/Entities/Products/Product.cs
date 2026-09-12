using SabzMarket.Domain.Entities.Base;
using SabzMarket.Domain.Entities.Categories;
using SabzMarket.Domain.Entities.Sellers;
using SabzMarket.Domain.Exceptions;

namespace SabzMarket.Domain.Entities.Products;

public class Product : BaseEntity
{
    public long SellerId { get; private set; }
    public long CategoryId { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Price { get; private set; }
    public int Number { get; private set; }
    public string ImageProduct { get; private set; }
    public bool IsDeleted { get; private set; } = false;

    public Seller? Seller { get; private init; }
    public Category? Category { get; private init; }

    private Product()
    {
    }

    public Product(long sellerId, long categoryId, string name, int price, int number, string imageProduct,
        string description)
    {
        if (sellerId <= 0)
            throw new DomainException(ProductDomainMessages.SellerIdRequired);

        if (categoryId <= 0)
            throw new DomainException(ProductDomainMessages.CategoryIdRequired);

        if (price <= 0)
            throw new DomainException(ProductDomainMessages.PriceRequired);

        if (number <= 0)
            throw new DomainException(ProductDomainMessages.NumberRequired);

        if (string.IsNullOrWhiteSpace(name))
            throw new DomainException(ProductDomainMessages.NameRequired);

        if (string.IsNullOrWhiteSpace(imageProduct))
            throw new DomainException(ProductDomainMessages.ImageProductRequired);

        SellerId = sellerId;
        CategoryId = categoryId;
        Name = name;
        Price = price;
        Number = number;
        ImageProduct = imageProduct;
        Description = description;
    }

    public void Delete() => IsDeleted = true;
}