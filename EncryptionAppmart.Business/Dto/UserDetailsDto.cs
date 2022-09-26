using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAppmart.Business.Dto
{
    public class UserDetailsDto
    {
        public string? UserId { get; set; }
        public string? Fullname { get; set; }
        public string? InvestmentPlan { get; set; }
        public string? AccountBalance { get; set; }
    }
}
