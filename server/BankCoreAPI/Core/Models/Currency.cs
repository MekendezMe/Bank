using BankCoreAPI.Core.Models.Accounts;
using BankCoreAPI.Core.Models.Cards;
using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models
{
    public class Currency : BaseEntity
    {
        [Required]
        public string Code { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public double ExchangeRate { get; set; }

        public bool IsBaseCurrency { get; set; }

        public ICollection<Account> Accounts { get; set; } = new List<Account>();

        public ICollection<Card> Cards { get; set; } = new List<Card>();
    }
}
