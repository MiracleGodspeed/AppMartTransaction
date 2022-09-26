using EncryptionAppmart.Business.Dto;
using EncryptionAppmart.Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EncryptionAppmart.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public UserTransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("[action]")]
        public UserDetailsDto UserTransactionDetails(string userId) => _transactionService.GetUserAccountBalanceByUserId(userId);
    }
}
