using EncryptionAppmart.Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAppmart.Business.Interface
{
    public interface ITransactionService
    {
        UserDetailsDto GetUserAccountBalanceByUserId(string userId);
    }
}
