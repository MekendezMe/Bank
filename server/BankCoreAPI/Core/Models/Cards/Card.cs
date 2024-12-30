using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models.Cards
{
    public class Card : BaseEntity
    {
        public User? User { get; set; }

        [Required]
        public long UserId { get; set; }

        public CardType? CardType { get; set; }

        [Required]
        public long CardTypeId { get; set; }

        [Required]
        public string Number { get; set; } = string.Empty;

        [Required]
        public string Code { get; set; } = string.Empty;

        [Required]
        public double Balance { get; set; }

        [Required]
        public long CurrencyId { get; set; }

        public Currency? Currency { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsActivate { get; set; }

        public ICollection<CardTransaction> CardFromTransactions { get; set; }
            = new List<CardTransaction>();
        public ICollection<CardTransaction> CardToTransactions { get; set; }
            = new List<CardTransaction>();
    }
}
