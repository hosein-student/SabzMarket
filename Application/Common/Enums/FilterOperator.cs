using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SabzMarket.Application.Common.Enums;

public enum FilterOperator
{
    [Display(Name = "Equal")] 
    Equal,

    [Display(Name = "بزرگ تر یامساوی")]
    GreaterThanOrEqual,

    [Display(Name = "کوچیک تر یا مساوی")]
    LessThanOrEqual,

    [Display(Name = "Equal")]
    GreaterThan,

    [Display(Name = "Equal")]
    LessThan,

    [Display(Name = "Equal")]
    Contains,

    [Display(Name = "Equal")]
    StartsWith,

    [Display(Name = "Equal")]
    EndsWith
}