using SabzMarketShare.CustomeAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketShare
{
    public class SellerViewModel:BaseValidatoin
    {
        [MaxLength(50,ErrorMessage = MessageDTO.firstNameInvalid2)]
        [MinLength(3,ErrorMessage =MessageDTO.firstNameInvalid1)]
        public string FirstName { get; set; }
        [MaxLength(50,ErrorMessage =MessageDTO.lastNameInvalid2)]
        [MinLength(2,ErrorMessage = MessageDTO.lastNameInvalid1)]
        public string LastName { get; set; }
        public string Email { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage =MessageDTO.numberInvalid1)]
        [NumberValidationAtrrribute]
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [StringLength(500,ErrorMessage =MessageDTO.enterTheAddress)]
        public string Address { get; set; }
        [Required(ErrorMessage=MessageDTO.photoNotSelected)]
        public string ProfileImage { get; set; }
        [MaxLength(3,ErrorMessage = MessageDTO.enterTheWorkHistory)]
        [MinLength(1,ErrorMessage = MessageDTO.enterTheWorkHistory)]
        public string WorkHistory { get; set; }
    }
}
