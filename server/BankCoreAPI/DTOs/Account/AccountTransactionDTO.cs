using BankCoreAPI.Core.Models.Accounts;

namespace BankCoreAPI.DTOs.Account
{
    public class AccountTransactionDTO
    {
        public long AccountFromId { get; set; }
        public AccountDTO? AccountFrom { get; set; }

        public long AccountToId { get; set; }

        public AccountDTO? AccountTo { get; set; }

        public double Amount { get; set; }

        public double Balance { get; set; }

        public long AccountTransactionTypeId { get; set; }

        public AccountTransactionType? AccountTransactionType { get; set; }
    }
}
