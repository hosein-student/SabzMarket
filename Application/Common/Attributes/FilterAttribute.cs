using SabzMarket.Application.Common.Enums;

namespace SabzMarket.Application.Common.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class FilterAttribute:Attribute
{
    public string EntityProperty { get; }
    public FilterOperator Operator { get; }

    public FilterAttribute(
        string entityProperty,
        FilterOperator @operator)
    {
        EntityProperty = entityProperty;
        Operator = @operator;
    }
}

//
// [Filter(nameof(Product.Name), FilterOperator.Contains)]
// public string? Search { get; set; }
//
// [Filter(nameof(Product.CategoryId), FilterOperator.Equal)]
// public long? CategoryId { get; set; }
//
// [Filter(nameof(Product.Count), FilterOperator.GreaterThanOrEqual)]
// public long? MinCount { get; set; }
//
// [Filter(nameof(Product.Price), FilterOperator.LessThanOrEqual)]
// public long? MaxPrice { get; set; }