using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models.Cards
{
    public class CardType : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Card> Cards { get; set; } = new List<Card>();
    }
}
