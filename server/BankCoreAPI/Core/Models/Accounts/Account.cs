using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models.Accounts
{
    public class Account : BaseEntity
    {
        public User? User { get; set; }

        [Required]
        public long UserId { get; set; }

        public AccountType? AccountType { get; set; }

        [Required]
        public long AccountTypeId { get; set; }

        [Required]
        public string Number { get; set; } = string.Empty;

        [Required]
        public double Balance { get; set; }

        [Required]
        public long CurrencyId { get; set; }

        public Currency? Currency { get; set; }

        [Required]
        public double InterestRate { get; set; }

        [Required]
        public double InterestAmount { get; set; }

        public DateTime? LastInterestPaid { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public ICollection<AccountTransaction> AccountFromTransactions { get; set; }
            = new List<AccountTransaction>();

        public ICollection<AccountTransaction> AccountToTransactions { get; set; }
           = new List<AccountTransaction>();
    }
}
