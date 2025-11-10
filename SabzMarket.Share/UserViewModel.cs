using SabzMarket.Share.CustomeAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share
{
    public class UserViewModel : BaseValidatoin
    {
        [MaxLength(50, ErrorMessage = Messages.firstNameInvalid2)]
        [MinLength(3, ErrorMessage = Messages.firstNameInvalid1)]
        public string FirstName { get; set; }
        [MaxLength(50, ErrorMessage = Messages.lastNameInvalid2)]
        [MinLength(2, ErrorMessage = Messages.lastNameInvalid1)]
        public string LastName { get; set; }
        [NumberValidation]
        public string Phone { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = Messages.Mandatory)]
        public string UserName { get; set; }
        [ComparePassword]
        public string Password1 { get; set; }
        public string Password2 { get; set; }
    }
}
