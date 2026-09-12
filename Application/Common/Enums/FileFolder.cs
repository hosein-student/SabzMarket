using System.ComponentModel.DataAnnotations;

namespace SabzMarket.Application.Common.Enums;

public enum FileFolder
{
    [Display(Name = "پروفایل کشاورز")] FarmerProfile,
    [Display(Name = "پروفایل فروشنده")] SellerProfile,
    [Display(Name = "تصویر محصول")] ProductImage
}