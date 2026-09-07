using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SabzMarket.Application.Common.Enums;

public enum FilterOperator
{
    [Display(Name = "Equal")] 
    Equal,

    [Display(Name = "بزرگ تر یامساوی")]
    GreaterThanOrEqual,

    [Display(Name = "کوچیک تر یا مساوی")] // بزرگ‌تر یا مساوی
    LessThanOrEqual,

    [Display(Name = "Equal")] // کوچک‌تر یا مساوی
    GreaterThan,

    [Display(Name = "Equal")] // بزرگ‌تر
    LessThan,

    [Display(Name = "Equal")] // کوچک‌تر
    Contains,

    [Display(Name = "Equal")] // شاملِ
    StartsWith,

    [Display(Name = "Equal")] // شروع می‌شود با
    EndsWith // تمام می‌شود با
}