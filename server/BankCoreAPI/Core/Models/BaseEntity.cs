using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();

        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    }
}
