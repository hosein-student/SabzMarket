using SabzMarket.Share.CustomeAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share
{
    public class SellerFullViewModel:BaseValidatoin
    {
        [MaxLength(50, ErrorMessage = Messages.firstNameInvalid2)]
        [MinLength(3, ErrorMessage = Messages.firstNameInvalid1)]
        public string? FirstName { get; set; }
        [MaxLength(50, ErrorMessage = Messages.lastNameInvalid2)]
        [MinLength(2, ErrorMessage = Messages.lastNameInvalid1)]
        public string? LastName { get; set; }
        public string? Email { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = Messages.numberInvalid1)]
        [NumberValidationAttribute]
        public string? Phone { get; set; }
        public string Username { get; set; }
        public string? Password { get; set; }
        [StringLength(500, ErrorMessage = Messages.enterTheAddress)]
        public string Address { get; set; }
        [Required(ErrorMessage = Messages.photoNotSelected)]
        public string ProfileImage { get; set; }
        [MaxLength(3, ErrorMessage = Messages.enterTheWorkHistory)]
        [MinLength(1, ErrorMessage = Messages.enterTheWorkHistory)]
        public string WorkHistory { get; set; }
    }
}
