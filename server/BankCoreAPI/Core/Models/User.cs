using BankCoreAPI.Core.Models.Accounts;
using BankCoreAPI.Core.Models.Cards;
using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models
{
    public class User : BaseEntity
    {
        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string HashPassword { get; set; } = string.Empty;

        [Required]
        public long RoleId { get; set; }

        public Role? Role { get; set; }

        [Required]
        public string MobilePhone { get; set; } = string.Empty;

        public DateTime? ConfirmedAt { get; set; }

        public bool Deleted { get; set; } = false;

        public ICollection<Account> Accounts { get; set; } = new List<Account>();

        public ICollection<Card> Cards { get; set; } = new List<Card>();
    }
}
