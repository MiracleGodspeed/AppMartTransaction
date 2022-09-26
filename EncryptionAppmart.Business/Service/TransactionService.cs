using EncryptionAppmart.Business.Dto;
using EncryptionAppmart.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAppmart.Business.Service
{
    public class TransactionService : ITransactionService
    {
        public TransactionService()
        {

        }
        public UserDetailsDto GetUserAccountBalanceByUserId(string userId)
        {
            return MakeBelieveDataBase(userId);
        }


        //Make believe usertransaction table from a database
        public UserDetailsDto MakeBelieveDataBase(string userId)
        {
            List<TempDataBase> transactionDataBase = new List<TempDataBase>();

            TempDataBase user1 = new TempDataBase()
            {
                Fullname = "Godspeed Miracle",
                AccountBalance = 7000,
                InvestmentPlan = "Gold Plan",
                UserId = "4536-6738-8273"
            };
            transactionDataBase.Add(user1);

            TempDataBase user2 = new TempDataBase()
            {
                Fullname = "Okonkwo Femi",
                AccountBalance = 9000,
                InvestmentPlan = "Silver Plan",
                UserId = "7736-2238-4473"
            };
            transactionDataBase.Add(user2);

            TempDataBase user3 = new TempDataBase()
            {
                Fullname = "Emeka Progress",
                AccountBalance = 10500,
                InvestmentPlan = "Bronze Plan",
                UserId = "1234-3030-8273"
            };
            transactionDataBase.Add(user3);

            var getUser = transactionDataBase.Where(x => x.UserId == userId)
                .Select(f => new UserDetailsDto
                {
                    Fullname = EncryptionDecryptionUtility.EncryptData(f.Fullname),
                    AccountBalance = EncryptionDecryptionUtility.EncryptData(f.AccountBalance.ToString()),
                    InvestmentPlan = EncryptionDecryptionUtility.EncryptData(f.InvestmentPlan),
                    UserId = EncryptionDecryptionUtility.EncryptData(f.UserId),
                })
                .FirstOrDefault();

            return getUser;

        }
    }

}
