using AutoMapper;
using BankCoreAPI.Core.Models.Accounts;
using BankCoreAPI.DTOs.Account;

namespace BankCoreAPI.Core.Mappings
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<Account, AccountDTO>();
            CreateMap<AccountDTO, Account>();
            CreateMap<AccountTransaction, AccountTransactionDTO>();
            CreateMap<AccountTransactionDTO, AccountTransaction>();
        }
    }
}
