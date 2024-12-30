using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models.Cards
{
    public class CardTransactionType : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<CardTransaction> CardTransactions { get; set; }
            = new List<CardTransaction>();
    }
}
