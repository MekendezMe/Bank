using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models.Accounts
{
    public class AccountTransaction : BaseEntity
    {
        [Required]
        public long AccountFromId { get; set; }

        public Account? AccountFrom { get; set; }

        [Required]
        public long AccountToId { get; set; }

        public Account? AccountTo { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public double Balance { get; set; }

        [Required]
        public long AccountTransactionTypeId { get; set; }

        public AccountTransactionType? AccountTransactionType { get; set; }
    }
}
