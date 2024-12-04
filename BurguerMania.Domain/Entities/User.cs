using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Entities
{
    public class User : BaseEntity<GuidKey>
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public virtual ICollection<Order> Orders { get; set; } = [];
    }
}