using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models.Accounts
{
    public class AccountType : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Account> Accounts { get; set; } = new List<Account>();
    }
}
