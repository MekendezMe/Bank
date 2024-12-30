using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models.Accounts
{
    public class AccountTransactionType : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<AccountTransaction> AccountTransactions { get; set; }
            = new List<AccountTransaction>();
    }
}
