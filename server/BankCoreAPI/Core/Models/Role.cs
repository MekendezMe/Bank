using System.ComponentModel.DataAnnotations;

namespace BankCoreAPI.Core.Models
{
    public class Role : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
