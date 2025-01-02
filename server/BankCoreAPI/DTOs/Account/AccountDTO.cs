using BankCoreAPI.Core.Models.Accounts;
using BankCoreAPI.DTOs.User;

namespace BankCoreAPI.DTOs.Account
{
    public class AccountDTO
    {
        public long UserId { get; set; }
        public UserDTO? User { get; set; }

        public long AccountTypeId { get; set; }

        public AccountType? AccountType { get; set; }

        public string Number { get; set; } = string.Empty;

        public double Balance { get; set; }

        public string Currency { get; set; } = string.Empty;

        public double InterestRate { get; set; }

        public double InterestAmount { get; set; }

        public DateTime? LastInterestPaid { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime? BlockedAt { get; set; }

        public ICollection<AccountTransactionDTO> AccountFromTransactions { get; set; }
            = new List<AccountTransactionDTO>();

        public ICollection<AccountTransactionDTO> AccountToTransactions { get; set; }
           = new List<AccountTransactionDTO>();
    }
}
