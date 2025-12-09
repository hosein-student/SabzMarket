using SabzMarket.Share.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SabzMarket.Share.ViewModels
{
    public class SellerPartialViewModel:BaseValidatoin
    {
        public string? Username { get; set; }
        [StringLength(500, ErrorMessage = Messages.enterTheAddress)]
        public string? Address { get; set; }
        [Required(ErrorMessage = Messages.photoNotSelected)]
        public string? ProfileImage { get; set; }
        [MaxLength(3, ErrorMessage = Messages.enterTheWorkHistory)]
        [MinLength(1, ErrorMessage = Messages.enterTheWorkHistory)]
        public string? WorkHistory { get; set; }
    }
}

