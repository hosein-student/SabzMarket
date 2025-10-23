using SabzMarketShare.CustomeAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketShare
{
    public class UserViewModel:BaseValidatoin
    {
        [MaxLength(50, ErrorMessage = MessageDTO.firstNameInvalid2)]
        [MinLength(3, ErrorMessage = MessageDTO.firstNameInvalid1)]
        public string FirstName { get; set; }
        [MaxLength(50, ErrorMessage = MessageDTO.lastNameInvalid2)]
        [MinLength(2, ErrorMessage = MessageDTO.lastNameInvalid1)]
        public string LastName { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = MessageDTO.numberInvalid1)]
        [NumberValidationAtrrribute]
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
    }
}
