using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAppmart.Business.Dto
{
    public class TempDataBase
    {
        public string? UserId { get; set; }
        public string? Fullname { get; set; }
        public string? InvestmentPlan { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
