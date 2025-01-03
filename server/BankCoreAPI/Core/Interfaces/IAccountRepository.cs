﻿using BankCoreAPI.Core.Models.Accounts;

namespace BankCoreAPI.Core.Interfaces
{
    public interface IAccountRepository
    {
        Task<Account?> GetAccountByNumberAsync(string number);

        Task<IEnumerable<Account>> GetAccountsByUserIdAsync(long userId);

        Task<IEnumerable<Account>> GetActiveAccountsByUserIdAsync(long userId);

        Task<IEnumerable<Account>> GetAllActiveAccountsAsync();

        Task<IEnumerable<Account>> GetAccountsByTypeAsync(string type);

        Task<IEnumerable<Account>> GetAccountsByTypeAndUserIdAsync(string type, long userId);

        Task<IEnumerable<Account>> GetAccountsByCurrencyAndUserIdAsync(string currency, long userId);
    }
}
