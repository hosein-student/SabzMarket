using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share
{
    public class FarmerDTOForSeller
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? ProfileImage { get; set; }
        public string? Phone { get; set; }
        public string? CodePosti { get; set; }
    }
}
